using MetroFramework.Controls;
using Power_Control_v2.PowerCfg;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Control_v2.Controls
{
    class ctrlAutomaticProcess : MetroUserControl
    {
        #region CONTROLS
        private MetroLabel ctrlLabelProcessName;
        private MetroLabel ctrlLabelSchemeName;
        private MetroTile ctrlTileRemove;
        private MetroTile ctrlTileRunning;
        private MetroLabel ctrlLabelPriority;
        private MetroLabel metroLabel1;
        private MetroTrackBar metroTrackBar1;
        #endregion

        #region VARIABLES
        private bool processRunning;
        private int priority;
        #endregion

        #region PROPERTIES
        public Scheme ProcessScheme { get; private set; }
        public string ProcessName { get; private set; }
        public int ProcessPriority
        {
            get
            {
                return priority;
            }
            private set
            {
                priority = value;
                metroTrackBar1.Value = priority;
                ctrlLabelPriority.Text = priority.ToString();
            }
        }
        public bool ProcessRunning
        {
            get 
            {
                return processRunning;
            }
            private set 
            {
                if (processRunning != value)
                {
                    processRunning = value;
                    OnProcessRunningChangedEvent(new EventArgs());
                }
            }
        }
        #endregion

        #region EVENTS
        public event EventHandler ProcessRunningChangedEvent;
        protected virtual void OnProcessRunningChangedEvent(EventArgs e)
        {
            if (ProcessRunningChangedEvent != null)
                ProcessRunningChangedEvent(this, e);
        }
        public event EventHandler RemoveButtonPressedEvent;
        protected virtual void OnRemoveButtonPressedEvent(EventArgs e)
        {
            if (RemoveButtonPressedEvent != null)
                RemoveButtonPressedEvent(this, e);
        }
        #endregion

        #region CONSTRUCTOR
        public ctrlAutomaticProcess(string processName, Scheme scheme, int priority)
        {
            InitializeComponent();
            this.ProcessName = processName;
            this.ProcessScheme = scheme;
            this.ProcessPriority = priority;
            this.ctrlLabelProcessName.Text = this.ProcessName;
            this.ctrlLabelSchemeName.Text = this.ProcessScheme.Name;
            this.ctrlLabelPriority.Text = this.ProcessPriority.ToString();
            this.processRunning = false;
        }
        #endregion

        #region METHODS
        private void InitializeComponent()
        {
            this.ctrlLabelProcessName = new MetroFramework.Controls.MetroLabel();
            this.ctrlLabelSchemeName = new MetroFramework.Controls.MetroLabel();
            this.ctrlTileRunning = new MetroFramework.Controls.MetroTile();
            this.ctrlTileRemove = new MetroFramework.Controls.MetroTile();
            this.ctrlLabelPriority = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroTrackBar1 = new MetroFramework.Controls.MetroTrackBar();
            this.SuspendLayout();
            // 
            // ctrlLabelProcessName
            // 
            this.ctrlLabelProcessName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlLabelProcessName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ctrlLabelProcessName.Location = new System.Drawing.Point(6, 6);
            this.ctrlLabelProcessName.Name = "ctrlLabelProcessName";
            this.ctrlLabelProcessName.Size = new System.Drawing.Size(310, 25);
            this.ctrlLabelProcessName.TabIndex = 1;
            this.ctrlLabelProcessName.Text = "<ProcessName>";
            // 
            // ctrlLabelSchemeName
            // 
            this.ctrlLabelSchemeName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlLabelSchemeName.Location = new System.Drawing.Point(6, 31);
            this.ctrlLabelSchemeName.Name = "ctrlLabelSchemeName";
            this.ctrlLabelSchemeName.Size = new System.Drawing.Size(310, 19);
            this.ctrlLabelSchemeName.TabIndex = 1;
            this.ctrlLabelSchemeName.Text = "<SchemeName>";
            // 
            // ctrlTileRunning
            // 
            this.ctrlTileRunning.ActiveControl = null;
            this.ctrlTileRunning.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlTileRunning.Location = new System.Drawing.Point(322, 3);
            this.ctrlTileRunning.Name = "ctrlTileRunning";
            this.ctrlTileRunning.Size = new System.Drawing.Size(92, 85);
            this.ctrlTileRunning.TabIndex = 0;
            this.ctrlTileRunning.Text = "Not running";
            this.ctrlTileRunning.TileImage = global::Power_Control_v2.Properties.Resources.Delete;
            this.ctrlTileRunning.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ctrlTileRunning.UseSelectable = true;
            this.ctrlTileRunning.UseTileImage = true;
            // 
            // ctrlTileRemove
            // 
            this.ctrlTileRemove.ActiveControl = null;
            this.ctrlTileRemove.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlTileRemove.Location = new System.Drawing.Point(420, 3);
            this.ctrlTileRemove.Name = "ctrlTileRemove";
            this.ctrlTileRemove.Size = new System.Drawing.Size(92, 85);
            this.ctrlTileRemove.TabIndex = 0;
            this.ctrlTileRemove.Text = "Remove";
            this.ctrlTileRemove.TileImage = global::Power_Control_v2.Properties.Resources.Recycle_bin;
            this.ctrlTileRemove.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ctrlTileRemove.UseSelectable = true;
            this.ctrlTileRemove.UseTileImage = true;
            this.ctrlTileRemove.Click += new System.EventHandler(this.ctrlTileRemove_Click);
            // 
            // ctrlLabelPriority
            // 
            this.ctrlLabelPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlLabelPriority.Location = new System.Drawing.Point(274, 50);
            this.ctrlLabelPriority.Name = "ctrlLabelPriority";
            this.ctrlLabelPriority.Size = new System.Drawing.Size(42, 19);
            this.ctrlLabelPriority.TabIndex = 1;
            this.ctrlLabelPriority.Text = "0";
            // 
            // metroLabel1
            // 
            this.metroLabel1.Location = new System.Drawing.Point(6, 50);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(58, 19);
            this.metroLabel1.TabIndex = 1;
            this.metroLabel1.Text = "Priority";
            // 
            // metroTrackBar1
            // 
            this.metroTrackBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTrackBar1.BackColor = System.Drawing.Color.Transparent;
            this.metroTrackBar1.Location = new System.Drawing.Point(70, 50);
            this.metroTrackBar1.Name = "metroTrackBar1";
            this.metroTrackBar1.Size = new System.Drawing.Size(198, 19);
            this.metroTrackBar1.TabIndex = 2;
            this.metroTrackBar1.Text = "metroTrackBar1";
            this.metroTrackBar1.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // ctrlAutomaticProcess
            // 
            this.Controls.Add(this.metroTrackBar1);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.ctrlLabelPriority);
            this.Controls.Add(this.ctrlLabelSchemeName);
            this.Controls.Add(this.ctrlLabelProcessName);
            this.Controls.Add(this.ctrlTileRunning);
            this.Controls.Add(this.ctrlTileRemove);
            this.Name = "ctrlAutomaticProcess";
            this.Size = new System.Drawing.Size(515, 91);
            this.ResumeLayout(false);

        }

        private void ctrlTileRemove_Click(object sender, EventArgs e)
        {
            OnRemoveButtonPressedEvent(new EventArgs());
        }
        public void CheckRunning()
        {
            if (Process.GetProcessesByName(this.ProcessName).Length > 0)
            {
                ctrlTileRunning.Text = "Running";
                ctrlTileRunning.TileImage = Power_Control_v2.Properties.Resources.Play_button;
                this.ProcessRunning = true;
            }
            else
            {
                ctrlTileRunning.Text = "Not running";
                ctrlTileRunning.TileImage = Power_Control_v2.Properties.Resources.Delete;
                this.ProcessRunning = false;
            }
        }
        #endregion

        private void metroTrackBar1_Scroll(object sender, System.Windows.Forms.ScrollEventArgs e)
        {
            this.ProcessPriority = metroTrackBar1.Value;
        }
    }
}
