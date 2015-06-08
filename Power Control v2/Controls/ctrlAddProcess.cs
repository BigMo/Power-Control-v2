using MetroFramework.Controls;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Control_v2.Controls
{
    class ctrlAddProcess : MetroUserControl
    {
        #region CONTROLS

        private MetroTile ctrlTileIcon;
        private MetroCheckBox ctrlCheckBoxName;
        private MetroLabel ctrlLabelPath;
        #endregion

        #region PROPERTIES
        public string ProcessName { get; private set; }
        public bool Checked 
        {
            get { return ctrlCheckBoxName.Checked; }
            set { ctrlCheckBoxName.Checked = value; }
        }
        #endregion

        #region EVENTS
        public event EventHandler CheckedChangedEvent;
        protected virtual void OnCheckedChangedEvent(EventArgs e)
        {
            if (CheckedChangedEvent != null)
                CheckedChangedEvent(this, e);
        }
        #endregion

        #region METHODS
        private void InitializeComponent()
        {
            this.ctrlLabelPath = new MetroFramework.Controls.MetroLabel();
            this.ctrlTileIcon = new MetroFramework.Controls.MetroTile();
            this.ctrlCheckBoxName = new MetroFramework.Controls.MetroCheckBox();
            this.SuspendLayout();
            // 
            // ctrlLabelPath
            // 
            this.ctrlLabelPath.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlLabelPath.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ctrlLabelPath.Location = new System.Drawing.Point(66, 31);
            this.ctrlLabelPath.Name = "ctrlLabelPath";
            this.ctrlLabelPath.Size = new System.Drawing.Size(162, 19);
            this.ctrlLabelPath.TabIndex = 1;
            this.ctrlLabelPath.Text = "<Path>";
            // 
            // ctrlTileIcon
            // 
            this.ctrlTileIcon.ActiveControl = null;
            this.ctrlTileIcon.Location = new System.Drawing.Point(3, 3);
            this.ctrlTileIcon.Name = "ctrlTileIcon";
            this.ctrlTileIcon.Size = new System.Drawing.Size(48, 48);
            this.ctrlTileIcon.TabIndex = 0;
            this.ctrlTileIcon.TileImage = global::Power_Control_v2.Properties.Resources.Question;
            this.ctrlTileIcon.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ctrlTileIcon.UseSelectable = true;
            this.ctrlTileIcon.UseTileImage = true;
            // 
            // ctrlCheckBoxName
            // 
            this.ctrlCheckBoxName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlCheckBoxName.FontSize = MetroFramework.MetroCheckBoxSize.Tall;
            this.ctrlCheckBoxName.Location = new System.Drawing.Point(66, 6);
            this.ctrlCheckBoxName.Name = "ctrlCheckBoxName";
            this.ctrlCheckBoxName.Size = new System.Drawing.Size(162, 22);
            this.ctrlCheckBoxName.TabIndex = 2;
            this.ctrlCheckBoxName.Text = "<ProcessName>";
            this.ctrlCheckBoxName.UseSelectable = true;
            this.ctrlCheckBoxName.CheckedChanged += new System.EventHandler(this.ctrlCheckBoxName_CheckedChanged);
            // 
            // ctrlAddProcess
            // 
            this.Controls.Add(this.ctrlCheckBoxName);
            this.Controls.Add(this.ctrlLabelPath);
            this.Controls.Add(this.ctrlTileIcon);
            this.Name = "ctrlAddProcess";
            this.Size = new System.Drawing.Size(231, 54);
            this.ResumeLayout(false);

        }
        #endregion

        #region CONSTRUCTOR
        public ctrlAddProcess(string processName, string path, Bitmap icon)
        {
            InitializeComponent();
            this.ProcessName = processName;
            if (icon != null)
                ctrlTileIcon.TileImage = icon;
            ctrlCheckBoxName.Text = processName;
            ctrlLabelPath.Text = path;
        }
        #endregion

        private void ctrlCheckBoxName_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChangedEvent(new EventArgs());
        }
    }
}
