using MetroFramework.Forms;
using Power_Control_v2.Controls;
using Power_Control_v2.IO;
using Power_Control_v2.PowerCfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Control_v2
{
    public partial class frmMain : MetroForm
    {
        private Scheme[] schemes;
        private ctrlManualScheme[] controlsSchemes;
        private List<ctrlAutomaticProcess> controlsProcesses;
        public frmMain()
        {
            InitializeComponent();

            schemes = Wrapper.Instance.GetAllSchemes();
            Wrapper.Instance.RefreshInfo();
            controlsSchemes = new ctrlManualScheme[schemes.Length];
            controlsProcesses = new List<ctrlAutomaticProcess>();

            Console.WriteLine("{0} schemes found!", schemes.Length.ToString());
            for (int i = 0; i < schemes.Length; i++)
            {
                Console.WriteLine("[{0}] {1} {2}", i.ToString(), schemes[i].Name, schemes[i].Guid);
                controlsSchemes[i] = new ctrlManualScheme(schemes[i]);
                controlsSchemes[i].SetActiveEvent += frmMain_SetActiveEvent;

                if (i == 0)
                    AddControl(tabPage1, ctlEnableManual, controlsSchemes[i], 8);
                else
                    AddControl(tabPage1, controlsSchemes[i - 1], controlsSchemes[i], 8);
            }
            Scheme activeScheme = Wrapper.Instance.CurrentScheme;
            Console.WriteLine("Active scheme: {0} {1}", activeScheme.Name, activeScheme.Guid);
            Wrapper.Instance.CurrentSchemeChangedEvent += Wrapper_CurrentSchemeChangedEvent;
            SetIcon("PC");
        }

        void Wrapper_CurrentSchemeChangedEvent(object sender, EventArgs e)
        {
            foreach (ctrlManualScheme control in controlsSchemes)
                control.GetActive();
            SetIcon(Wrapper.Instance.CurrentScheme.Name);

        }
        void frmMain_SetActiveEvent(object sender, EventArgs e)
        {
            foreach (ctrlManualScheme control in controlsSchemes)
                if (control != sender)
                    control.GetActive();
        }

        private void SetIcon(string text)
        {
            Bitmap bmp = CreateIcon(text);
            this.BackImage = bmp;
            Icon icn = Icon.FromHandle(bmp.GetHicon());
            this.Icon = icn;
            notifyIcon1.Icon = Icon;
        }
        private Bitmap CreateIcon(string text)
        {
            Bitmap bmp = new Bitmap(64, 64);

            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.Transparent);
                g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.HighQuality;

                using (SolidBrush brush = new SolidBrush(Color.FromArgb(0, 174, 219)))
                {
                    g.FillEllipse(brush, 1, 1, bmp.Width - 2, bmp.Height - 2);
                }

                using (Font fnt = new Font(this.Font.FontFamily, bmp.Height * 0.4f))
                {
                    SizeF size = g.MeasureString(text.Substring(0, 2), fnt);

                    g.DrawString(
                        text.Substring(0, 2),
                        fnt, Brushes.White,
                        bmp.Width / 2f - size.Width / 2f,
                        bmp.Height / 2f - size.Height / 2f);
                }
            }
            return bmp;

        }

        private void AddControl(Control container, Control lastControl, Control thisControl, int margin)
        {
            container.Controls.Add(thisControl);
            thisControl.Location = new Point(margin, lastControl.Location.Y + lastControl.Size.Height + margin);
            thisControl.Size = new Size(container.Width - margin * 2, thisControl.Height);
            thisControl.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
        }

        private void ctlEnableManual_CheckedChanged(object sender, EventArgs e)
        {
            if (ctlEnableManual.Checked)
                ctlEnableAutomatic.Checked = false;
        }

        private void ctlEnableAutomatic_CheckedChanged(object sender, EventArgs e)
        {
            if (ctlEnableAutomatic.Checked)
                ctlEnableManual.Checked = false;
        }

        private void metroTrackBar1_Scroll(object sender, ScrollEventArgs e)
        {
            ctlLabelInterval.Text = string.Format("{0} seconds", ctlTrackBarInterval.Value.ToString());
            tmrAutomation.Interval = ctlTrackBarInterval.Value * 1000;
        }

        private void ctrlTileAdd_Click(object sender, EventArgs e)
        {
            using (frmAddProcess frm = new frmAddProcess(schemes))
            {
                if (frm.ShowDialog() != System.Windows.Forms.DialogResult.OK)
                    return;
                string[] processNames = frm.ProcessNames;
                ctrlAutomaticProcess[] procs = new ctrlAutomaticProcess[processNames.Length];
                for (int i = 0; i < procs.Length; i++)
                {
                    procs[i] = new ctrlAutomaticProcess(processNames[i], frm.ProcessScheme, frm.ProcessPriority);
                    procs[i].RemoveButtonPressedEvent += proc_RemoveButtonPressedEvent;
                    controlsProcesses.Add(procs[i]);
                }
                RefreshAutomaticProcesses();
            }
        }

        private void RefreshAutomaticProcesses()
        {
            foreach (ctrlAutomaticProcess control in controlsProcesses)
                tabPage2.Controls.Remove(control);
            controlsProcesses.Sort((x, y) => (x.ProcessName.CompareTo(y.ProcessName)));
            for (int i = 0; i < controlsProcesses.Count; i++)
            {
                if (i == 0)
                    AddControl(tabPage2, ctrlTileAdd, controlsProcesses[i], 8);
                else
                    AddControl(tabPage2, controlsProcesses[i - 1], controlsProcesses[i], 8);
            }
        }
        void proc_RemoveButtonPressedEvent(object sender, EventArgs e)
        {
            controlsProcesses.Remove((ctrlAutomaticProcess)sender);
            tabPage2.Controls.Remove((ctrlAutomaticProcess)sender);
            RefreshAutomaticProcesses();
        }

        private void tmrAutomation_Tick(object sender, EventArgs e)
        {
            Wrapper.Instance.RefreshInfo();
            foreach (ctrlAutomaticProcess control in controlsProcesses)
            {
                control.CheckRunning();
            }
            if (ctlEnableManual.Checked)
                return;
            if (controlsProcesses.Count == 0)
                return;

            if (!controlsProcesses.Exists(x => x.ProcessRunning))
                return;

            IEnumerable<ctrlAutomaticProcess> running = controlsProcesses.Where(x => x.ProcessRunning);
            int maxPriority = running.Max(x => x.ProcessPriority);
            ctrlAutomaticProcess proc = controlsProcesses.First(x => x.ProcessPriority == maxPriority);

            Scheme currentScheme = Wrapper.Instance.CurrentScheme;
            if (currentScheme.Guid != proc.ProcessScheme.Guid)
                Wrapper.Instance.SetActiveScheme(proc.ProcessScheme);
        }

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveSettings();
        }

        private void SaveSettings()
        {
            AutomationProcess[] procs = new AutomationProcess[controlsProcesses.Count];
            for (int i = 0; i < procs.Length; i++)
            {
                procs[i] = new AutomationProcess()
                {
                    Priority = controlsProcesses[i].ProcessPriority,
                    ProcessName = controlsProcesses[i].ProcessName,
                    SchemeGuid = controlsProcesses[i].ProcessScheme.Guid
                };
            }
            SaveData data = new SaveData()
            {
                Processes = procs,
                AutomationInterval = ctlTrackBarInterval.Value,
                AutomationEnabled = ctlEnableAutomatic.Checked,
            };
            File.WriteAllBytes("save.dat", data.ToBytes());
        }

        private void frmMain_Shown(object sender, EventArgs e)
        {
            if (File.Exists("save.dat"))
            {
                try
                {
                    SaveData data = SaveData.FromBytes(File.ReadAllBytes("save.dat"));
                    #region Get processes
                    List<string> lost = new List<string>();
                    foreach (AutomationProcess proc in data.Processes)
                    {
                        if (schemes.Count(x => x.Guid == proc.SchemeGuid) > 0)
                        {
                            controlsProcesses.Add(new ctrlAutomaticProcess(proc.ProcessName, schemes.First(x => x.Guid == proc.SchemeGuid), proc.Priority));
                            controlsProcesses[controlsProcesses.Count - 1].RemoveButtonPressedEvent += proc_RemoveButtonPressedEvent;
                        }
                        else
                        {
                            lost.Add(proc.ProcessName);
                        }
                    }
                    if (controlsProcesses.Count > 0)
                        RefreshAutomaticProcesses();
                    if (lost.Count > 0)
                    {
                        StringBuilder builder = new StringBuilder();
                        builder.AppendLine("There were one or more processes missing a valid scheme:");
                        foreach (string proc in lost)
                            builder.AppendFormat("\t{0}\n", proc);
                        MetroFramework.MetroMessageBox.Show(this, builder.ToString(), "Missing scheme");
                    }
                    #endregion
                    ctlTrackBarInterval.Value = data.AutomationInterval;
                    ctlLabelInterval.Text = string.Format("{0} seconds", data.AutomationInterval.ToString());
                    ctlEnableAutomatic.Checked = data.AutomationEnabled;
                    tmrAutomation.Interval = data.AutomationInterval * 1000;
                    if (data.AutomationEnabled)
                        metroTabControl1.SelectedIndex = 1;
                    else
                        metroTabControl1.SelectedIndex = 0;
                }
                catch (Exception ex)
                {
                    MetroFramework.MetroMessageBox.Show(this, string.Format("An error appreared while loading automation-processes:\n{0}", ex.Message), "Error");
                }
            }
        }

        private void metroTile1_Click(object sender, EventArgs e)
        {
            try
            {
                SaveSettings();
                MetroFramework.MetroMessageBox.Show(this, "Settings saved!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MetroFramework.MetroMessageBox.Show(this, string.Format("An error appreared while saving settings:\n{0}", ex.Message), "Error");
            }
        }

        private void notifyIcon1_MouseClick(object sender, MouseEventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Show();
                this.WindowState = FormWindowState.Normal;
            } 
            else if(this.WindowState == FormWindowState.Normal)
            {
                this.Hide();
                this.WindowState = FormWindowState.Minimized;
            }
        }
    }
}
