namespace Power_Control_v2
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroTabControl1 = new MetroFramework.Controls.MetroTabControl();
            this.tabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.ctlEnableManual = new MetroFramework.Controls.MetroRadioButton();
            this.tabPage2 = new MetroFramework.Controls.MetroTabPage();
            this.ctlLabelInterval = new MetroFramework.Controls.MetroLabel();
            this.ctlTrackBarInterval = new MetroFramework.Controls.MetroTrackBar();
            this.metroTile1 = new MetroFramework.Controls.MetroTile();
            this.ctrlTileAdd = new MetroFramework.Controls.MetroTile();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ctlEnableAutomatic = new MetroFramework.Controls.MetroRadioButton();
            this.metroTabPage1 = new MetroFramework.Controls.MetroTabPage();
            this.tmrAutomation = new System.Windows.Forms.Timer(this.components);
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.metroTabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroTabControl1
            // 
            this.metroTabControl1.Controls.Add(this.tabPage1);
            this.metroTabControl1.Controls.Add(this.tabPage2);
            this.metroTabControl1.Controls.Add(this.metroTabPage1);
            this.metroTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroTabControl1.Location = new System.Drawing.Point(20, 60);
            this.metroTabControl1.Name = "metroTabControl1";
            this.metroTabControl1.SelectedIndex = 2;
            this.metroTabControl1.Size = new System.Drawing.Size(663, 380);
            this.metroTabControl1.TabIndex = 0;
            this.metroTabControl1.UseSelectable = true;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.ctlEnableManual);
            this.tabPage1.HorizontalScrollbar = true;
            this.tabPage1.HorizontalScrollbarBarColor = true;
            this.tabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage1.HorizontalScrollbarSize = 10;
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(655, 338);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Manual";
            this.tabPage1.VerticalScrollbar = true;
            this.tabPage1.VerticalScrollbarBarColor = true;
            this.tabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage1.VerticalScrollbarSize = 10;
            // 
            // ctlEnableManual
            // 
            this.ctlEnableManual.AutoSize = true;
            this.ctlEnableManual.Checked = true;
            this.ctlEnableManual.Location = new System.Drawing.Point(4, 4);
            this.ctlEnableManual.Name = "ctlEnableManual";
            this.ctlEnableManual.Size = new System.Drawing.Size(142, 15);
            this.ctlEnableManual.TabIndex = 0;
            this.ctlEnableManual.TabStop = true;
            this.ctlEnableManual.Text = "Enable manual control";
            this.ctlEnableManual.UseSelectable = true;
            this.ctlEnableManual.CheckedChanged += new System.EventHandler(this.ctlEnableManual_CheckedChanged);
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage2.Controls.Add(this.ctlLabelInterval);
            this.tabPage2.Controls.Add(this.ctlTrackBarInterval);
            this.tabPage2.Controls.Add(this.metroTile1);
            this.tabPage2.Controls.Add(this.ctrlTileAdd);
            this.tabPage2.Controls.Add(this.metroLabel1);
            this.tabPage2.Controls.Add(this.ctlEnableAutomatic);
            this.tabPage2.HorizontalScrollbar = true;
            this.tabPage2.HorizontalScrollbarBarColor = true;
            this.tabPage2.HorizontalScrollbarHighlightOnWheel = false;
            this.tabPage2.HorizontalScrollbarSize = 10;
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(639, 338);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Automation";
            this.tabPage2.VerticalScrollbar = true;
            this.tabPage2.VerticalScrollbarBarColor = true;
            this.tabPage2.VerticalScrollbarHighlightOnWheel = false;
            this.tabPage2.VerticalScrollbarSize = 10;
            // 
            // ctlLabelInterval
            // 
            this.ctlLabelInterval.AutoSize = true;
            this.ctlLabelInterval.Location = new System.Drawing.Point(244, 26);
            this.ctlLabelInterval.Name = "ctlLabelInterval";
            this.ctlLabelInterval.Size = new System.Drawing.Size(71, 19);
            this.ctlLabelInterval.TabIndex = 5;
            this.ctlLabelInterval.Text = "10 seconds";
            // 
            // ctlTrackBarInterval
            // 
            this.ctlTrackBarInterval.BackColor = System.Drawing.Color.Transparent;
            this.ctlTrackBarInterval.Location = new System.Drawing.Point(87, 26);
            this.ctlTrackBarInterval.Maximum = 60;
            this.ctlTrackBarInterval.Minimum = 1;
            this.ctlTrackBarInterval.Name = "ctlTrackBarInterval";
            this.ctlTrackBarInterval.Size = new System.Drawing.Size(151, 19);
            this.ctlTrackBarInterval.TabIndex = 3;
            this.ctlTrackBarInterval.Text = "metroTrackBar1";
            this.ctlTrackBarInterval.Value = 10;
            this.ctlTrackBarInterval.Scroll += new System.Windows.Forms.ScrollEventHandler(this.metroTrackBar1_Scroll);
            // 
            // metroTile1
            // 
            this.metroTile1.ActiveControl = null;
            this.metroTile1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroTile1.Location = new System.Drawing.Point(376, 3);
            this.metroTile1.Name = "metroTile1";
            this.metroTile1.Size = new System.Drawing.Size(127, 85);
            this.metroTile1.TabIndex = 2;
            this.metroTile1.Text = "Save";
            this.metroTile1.TileImage = global::Power_Control_v2.Properties.Resources.Save;
            this.metroTile1.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroTile1.UseSelectable = true;
            this.metroTile1.UseTileImage = true;
            this.metroTile1.Click += new System.EventHandler(this.metroTile1_Click);
            // 
            // ctrlTileAdd
            // 
            this.ctrlTileAdd.ActiveControl = null;
            this.ctrlTileAdd.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlTileAdd.Location = new System.Drawing.Point(509, 3);
            this.ctrlTileAdd.Name = "ctrlTileAdd";
            this.ctrlTileAdd.Size = new System.Drawing.Size(127, 85);
            this.ctrlTileAdd.TabIndex = 2;
            this.ctrlTileAdd.Text = "Add process to list";
            this.ctrlTileAdd.TileImage = global::Power_Control_v2.Properties.Resources.Add;
            this.ctrlTileAdd.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ctrlTileAdd.UseSelectable = true;
            this.ctrlTileAdd.UseTileImage = true;
            this.ctrlTileAdd.Click += new System.EventHandler(this.ctrlTileAdd_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(11, 26);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(52, 19);
            this.metroLabel1.TabIndex = 4;
            this.metroLabel1.Text = "Interval";
            // 
            // ctlEnableAutomatic
            // 
            this.ctlEnableAutomatic.AutoSize = true;
            this.ctlEnableAutomatic.ForeColor = System.Drawing.SystemColors.ControlText;
            this.ctlEnableAutomatic.Location = new System.Drawing.Point(3, 3);
            this.ctlEnableAutomatic.Name = "ctlEnableAutomatic";
            this.ctlEnableAutomatic.Size = new System.Drawing.Size(156, 15);
            this.ctlEnableAutomatic.TabIndex = 1;
            this.ctlEnableAutomatic.Text = "Enable automatic control";
            this.ctlEnableAutomatic.UseSelectable = true;
            this.ctlEnableAutomatic.CheckedChanged += new System.EventHandler(this.ctlEnableAutomatic_CheckedChanged);
            // 
            // metroTabPage1
            // 
            this.metroTabPage1.HorizontalScrollbarBarColor = true;
            this.metroTabPage1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.HorizontalScrollbarSize = 10;
            this.metroTabPage1.Location = new System.Drawing.Point(4, 38);
            this.metroTabPage1.Name = "metroTabPage1";
            this.metroTabPage1.Size = new System.Drawing.Size(655, 338);
            this.metroTabPage1.TabIndex = 2;
            this.metroTabPage1.Text = "About";
            this.metroTabPage1.VerticalScrollbarBarColor = true;
            this.metroTabPage1.VerticalScrollbarHighlightOnWheel = false;
            this.metroTabPage1.VerticalScrollbarSize = 10;
            // 
            // tmrAutomation
            // 
            this.tmrAutomation.Enabled = true;
            this.tmrAutomation.Interval = 10000;
            this.tmrAutomation.Tick += new System.EventHandler(this.tmrAutomation_Tick);
            // 
            // notifyIcon1
            // 
            this.notifyIcon1.Text = "Power Control v2";
            this.notifyIcon1.Visible = true;
            this.notifyIcon1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon1_MouseClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImagePadding = new System.Windows.Forms.Padding(24);
            this.BackLocation = MetroFramework.Forms.BackLocation.TopRight;
            this.BackMaxSize = 32;
            this.ClientSize = new System.Drawing.Size(703, 460);
            this.Controls.Add(this.metroTabControl1);
            this.Name = "frmMain";
            this.Text = "Power Control v2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Shown += new System.EventHandler(this.frmMain_Shown);
            this.metroTabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTabControl metroTabControl1;
        private MetroFramework.Controls.MetroTabPage tabPage1;
        private MetroFramework.Controls.MetroTabPage tabPage2;
        private MetroFramework.Controls.MetroRadioButton ctlEnableManual;
        private MetroFramework.Controls.MetroRadioButton ctlEnableAutomatic;
        private MetroFramework.Controls.MetroTile ctrlTileAdd;
        private MetroFramework.Controls.MetroLabel ctlLabelInterval;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTrackBar ctlTrackBarInterval;
        private System.Windows.Forms.Timer tmrAutomation;
        private MetroFramework.Controls.MetroTabPage metroTabPage1;
        private MetroFramework.Controls.MetroTile metroTile1;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
    }
}

