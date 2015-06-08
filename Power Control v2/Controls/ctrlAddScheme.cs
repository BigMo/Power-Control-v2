using MetroFramework.Controls;
using Power_Control_v2.PowerCfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Control_v2.Controls
{
    class ctrlAddScheme : MetroUserControl
    {
        #region CONTROLS

        private MetroTile ctrlTileIcon;
        private MetroCheckBox ctrlCheckBoxName;
        private MetroLabel ctrlLabelGuid;
        #endregion

        #region PROPERTIES
        public Scheme ProcessScheme { get; private set; }
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
            this.ctrlLabelGuid = new MetroFramework.Controls.MetroLabel();
            this.ctrlCheckBoxName = new MetroFramework.Controls.MetroCheckBox();
            this.ctrlTileIcon = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // ctrlLabelGuid
            // 
            this.ctrlLabelGuid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlLabelGuid.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ctrlLabelGuid.Location = new System.Drawing.Point(66, 31);
            this.ctrlLabelGuid.Name = "ctrlLabelGuid";
            this.ctrlLabelGuid.Size = new System.Drawing.Size(162, 19);
            this.ctrlLabelGuid.TabIndex = 1;
            this.ctrlLabelGuid.Text = "<Path>";
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
            this.ctrlCheckBoxName.Text = "<SchemeName>";
            this.ctrlCheckBoxName.UseSelectable = true;
            this.ctrlCheckBoxName.CheckedChanged += new System.EventHandler(this.ctrlCheckBoxName_CheckedChanged);
            // 
            // ctrlTileIcon
            // 
            this.ctrlTileIcon.ActiveControl = null;
            this.ctrlTileIcon.Location = new System.Drawing.Point(3, 3);
            this.ctrlTileIcon.Name = "ctrlTileIcon";
            this.ctrlTileIcon.Size = new System.Drawing.Size(48, 48);
            this.ctrlTileIcon.TabIndex = 0;
            this.ctrlTileIcon.TileImage = global::Power_Control_v2.Properties.Resources.Clipboard;
            this.ctrlTileIcon.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ctrlTileIcon.UseSelectable = true;
            this.ctrlTileIcon.UseTileImage = true;
            // 
            // ctrlAddScheme
            // 
            this.Controls.Add(this.ctrlCheckBoxName);
            this.Controls.Add(this.ctrlLabelGuid);
            this.Controls.Add(this.ctrlTileIcon);
            this.Name = "ctrlAddScheme";
            this.Size = new System.Drawing.Size(231, 54);
            this.ResumeLayout(false);

        }
        #endregion

        #region CONSTRUCTOR
        public ctrlAddScheme(Scheme scheme)
        {
            InitializeComponent();
            this.ProcessScheme = scheme;
            this.ctrlCheckBoxName.Text = scheme.Name;
            this.ctrlLabelGuid.Text = scheme.Guid;
        }
        #endregion

        private void ctrlCheckBoxName_CheckedChanged(object sender, EventArgs e)
        {
            OnCheckedChangedEvent(new EventArgs());
        }
    }
}
