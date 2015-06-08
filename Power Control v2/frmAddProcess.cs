using MetroFramework.Forms;
using Power_Control_v2.Controls;
using Power_Control_v2.PowerCfg;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Power_Control_v2
{
    public partial class frmAddProcess : MetroForm
    {
        private List<ctrlAddProcess> controlsProcesses;
        private List<ctrlAddScheme> controlsSchemes;

        public string[] ProcessNames
        {
            get
            {
                IEnumerable<ctrlAddProcess> selected = controlsProcesses.Where(x => x.Checked);
                ctrlAddProcess[] arr = selected.ToArray();
                string[] names = new string[arr.Length];
                for (int i = 0; i < names.Length; i++)
                    names[i] = arr[i].ProcessName;
                return names;
            }
        }
        public int CheckedProcesses
        {
            get
            {
                return controlsProcesses.Count(x => x.Checked);
            }
        }
        public Scheme ProcessScheme { get; private set; }
        public int ProcessPriority { get { return ctrlPriority.Value; } }

        public frmAddProcess(Scheme[] schemes)
        {
            InitializeComponent();
            this.DialogResult = System.Windows.Forms.DialogResult.Abort;
            #region Processes
            controlsProcesses = new List<ctrlAddProcess>();
            foreach (Process proc in Process.GetProcesses())
            {
                //try
                //{
                    if (controlsProcesses.Exists((x) => (x.ProcessName == proc.ProcessName)))
                        continue;

                    string path = "-";
                    Bitmap icon = null;
                    try
                    {
                        path = proc.MainModule.FileName;
                        icon = Bitmap.FromHicon(Icon.ExtractAssociatedIcon(path).Handle);
                    }
                    catch { }
                    controlsProcesses.Add(new ctrlAddProcess(proc.ProcessName, path, icon));
                //}
                //catch (System.ComponentModel.Win32Exception Ex) { Console.WriteLine("Skipping (WIN32) {0}", proc.ProcessName); }
                //catch (Exception ex) { Console.WriteLine("Skipping {0}", proc.ProcessName); }
            }
            controlsProcesses.Sort((x, y) => (x.ProcessName.CompareTo(y.ProcessName)));
            foreach(ctrlAddProcess control in controlsProcesses)
            {
                control.CheckedChangedEvent += controlProcesses_CheckedChangedEvent;
                if (metroPanel1.Controls.Count == 0)
                    AddControl(metroPanel1, metroLabel1, control, 8);
                else
                    AddControl(metroPanel1, metroPanel1.Controls[metroPanel1.Controls.Count - 1], control, 8);
            }
            #endregion
            #region Schemes
            controlsSchemes = new List<ctrlAddScheme>();
            for(int i = 0; i < schemes.Length;i++)
            {
                controlsSchemes.Add(new ctrlAddScheme(schemes[i]));
                controlsSchemes[i].CheckedChangedEvent += controlSchemes_CheckedChangedEvent;
            }
            controlsSchemes.Sort((x, y) => (x.Name.CompareTo(y.Name)));
            foreach(ctrlAddScheme control in controlsSchemes)
            {
                if (metroPanel2.Controls.Count == 0)
                    AddControl(metroPanel2, metroLabel2, control, 8);
                else
                    AddControl(metroPanel2, metroPanel2.Controls[metroPanel2.Controls.Count - 1], control, 8);
            }
            
            #endregion
        }

        void controlSchemes_CheckedChangedEvent(object sender, EventArgs e)
        {
            if (((ctrlAddScheme)sender).Checked)
            {
                foreach (ctrlAddScheme control in controlsSchemes)
                    if (control != sender)
                        control.Checked = false;
                ProcessScheme = ((ctrlAddScheme)sender).ProcessScheme;
            }
            CheckForOkay();
        }

        void controlProcesses_CheckedChangedEvent(object sender, EventArgs e)
        {
            CheckForOkay();
        }

        private void CheckForOkay()
        {
            ctrlButtonOkay.Enabled = (controlsProcesses.Exists((x) => (x.Checked)) && controlsSchemes.Exists((x) => (x.Checked))); 
        }

        private void AddControl(Control container, Control lastControl, Control thisControl, int margin)
        {
            container.Controls.Add(thisControl);
            thisControl.Location = new Point(margin, lastControl.Location.Y + lastControl.Size.Height + margin);
            thisControl.Size = new Size(container.Width - margin * 2, thisControl.Height);
            thisControl.Anchor = AnchorStyles.Left | AnchorStyles.Top | AnchorStyles.Right;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Close();
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ctrlPriority_Scroll(object sender, ScrollEventArgs e)
        {
            ctrlLabelPriority.Text = ctrlPriority.Value.ToString();
        }
    }
}
