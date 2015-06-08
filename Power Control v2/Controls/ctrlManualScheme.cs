using MetroFramework.Controls;
using Power_Control_v2.PowerCfg;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Power_Control_v2.Controls
{
    class ctrlManualScheme : MetroUserControl
    {
        #region CONTROLS
        private MetroLabel ctrlLabelName;
        private MetroTile ctrlTileAction;
        private MetroLabel ctrlLabelGuid;
        #endregion
        #region PROPERTIES
        public Scheme Scheme { get; set; }
        #endregion
        #region EVENTS
        public event EventHandler SetActiveEvent;
        protected virtual void OnSetActiveEvent(EventArgs e)
        {
            if (SetActiveEvent != null)
                SetActiveEvent(this, e);
        }
        #endregion
        #region CONSTRUCTOR
        public ctrlManualScheme(Scheme scheme)
        {
            InitializeComponent();
            this.Scheme = scheme;
            this.ctrlLabelGuid.Text = scheme.Guid;
            this.ctrlLabelName.Text = scheme.Name;
            GetActive();
        }
        #endregion
        #region METHODS
        private void InitializeComponent()
        {
            this.ctrlTileAction = new MetroFramework.Controls.MetroTile();
            this.ctrlLabelName = new MetroFramework.Controls.MetroLabel();
            this.ctrlLabelGuid = new MetroFramework.Controls.MetroLabel();
            this.SuspendLayout();
            // 
            // ctrlTileAction
            // 
            this.ctrlTileAction.ActiveControl = null;
            this.ctrlTileAction.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlTileAction.Location = new System.Drawing.Point(333, 3);
            this.ctrlTileAction.Name = "ctrlTileAction";
            this.ctrlTileAction.Size = new System.Drawing.Size(92, 85);
            this.ctrlTileAction.TabIndex = 0;
            this.ctrlTileAction.Text = "Set active";
            this.ctrlTileAction.TileImage = global::Power_Control_v2.Properties.Resources.Play_button;
            this.ctrlTileAction.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ctrlTileAction.UseSelectable = true;
            this.ctrlTileAction.UseTileImage = true;
            this.ctrlTileAction.Click += new System.EventHandler(this.ctrlTileAction_Click);
            // 
            // ctrlLabelName
            // 
            this.ctrlLabelName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlLabelName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.ctrlLabelName.Location = new System.Drawing.Point(6, 6);
            this.ctrlLabelName.Name = "ctrlLabelName";
            this.ctrlLabelName.Size = new System.Drawing.Size(321, 25);
            this.ctrlLabelName.TabIndex = 1;
            this.ctrlLabelName.Text = "<SchemeName>";
            // 
            // ctrlLabelGuid
            // 
            this.ctrlLabelGuid.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlLabelGuid.FontSize = MetroFramework.MetroLabelSize.Small;
            this.ctrlLabelGuid.Location = new System.Drawing.Point(6, 31);
            this.ctrlLabelGuid.Name = "ctrlLabelGuid";
            this.ctrlLabelGuid.Size = new System.Drawing.Size(321, 19);
            this.ctrlLabelGuid.TabIndex = 1;
            this.ctrlLabelGuid.Text = "<SchemeGuid>";
            // 
            // ctrlManualScheme
            // 
            this.Controls.Add(this.ctrlLabelGuid);
            this.Controls.Add(this.ctrlLabelName);
            this.Controls.Add(this.ctrlTileAction);
            this.MinimumSize = new System.Drawing.Size(257, 91);
            this.Name = "ctrlManualScheme";
            this.Size = new System.Drawing.Size(428, 91);
            this.ResumeLayout(false);

        }

        public bool SetActive()
        {
            Wrapper.Instance.SetActiveScheme(this.Scheme);
            bool active = GetActive();
            OnSetActiveEvent(new EventArgs());
            return active;
        }

        public bool GetActive()
        {
            bool active = Wrapper.Instance.CurrentScheme.Guid == this.Scheme.Guid;
            if (active)
            {
                this.ctrlTileAction.TileImage = Power_Control_v2.Properties.Resources.Apply;
                this.ctrlTileAction.Text = "Is active";
                this.ctrlTileAction.Enabled = false;
            }
            else
            {
                this.ctrlTileAction.TileImage = Power_Control_v2.Properties.Resources.Play_button;
                this.ctrlTileAction.Text = "Set active";
                this.ctrlTileAction.Enabled = true;
            }
            return active;
        }

        private void ctrlTileAction_Click(object sender, EventArgs e)
        {
            SetActive();
        }
        #endregion
    }
}
