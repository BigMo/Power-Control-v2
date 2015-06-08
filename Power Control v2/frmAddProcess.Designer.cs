namespace Power_Control_v2
{
    partial class frmAddProcess
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
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.ctrlButtonOkay = new MetroFramework.Controls.MetroButton();
            this.ctrlButtonCancel = new MetroFramework.Controls.MetroButton();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.metroPanel2 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.ctrlPriority = new MetroFramework.Controls.MetroTrackBar();
            this.ctrlLabelPriority = new MetroFramework.Controls.MetroLabel();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.metroPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.AutoScroll = true;
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbar = true;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 0);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(594, 279);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbar = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(4, 4);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(65, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Processes";
            // 
            // ctrlButtonOkay
            // 
            this.ctrlButtonOkay.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ctrlButtonOkay.Enabled = false;
            this.ctrlButtonOkay.Location = new System.Drawing.Point(542, 528);
            this.ctrlButtonOkay.Name = "ctrlButtonOkay";
            this.ctrlButtonOkay.Size = new System.Drawing.Size(75, 23);
            this.ctrlButtonOkay.TabIndex = 1;
            this.ctrlButtonOkay.Text = "Okay";
            this.ctrlButtonOkay.UseSelectable = true;
            this.ctrlButtonOkay.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // ctrlButtonCancel
            // 
            this.ctrlButtonCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctrlButtonCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.ctrlButtonCancel.Location = new System.Drawing.Point(23, 528);
            this.ctrlButtonCancel.Name = "ctrlButtonCancel";
            this.ctrlButtonCancel.Size = new System.Drawing.Size(75, 23);
            this.ctrlButtonCancel.TabIndex = 1;
            this.ctrlButtonCancel.Text = "Cancel";
            this.ctrlButtonCancel.UseSelectable = true;
            this.ctrlButtonCancel.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitContainer1.Location = new System.Drawing.Point(23, 63);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.metroPanel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.metroPanel2);
            this.splitContainer1.Size = new System.Drawing.Size(594, 427);
            this.splitContainer1.SplitterDistance = 279;
            this.splitContainer1.TabIndex = 2;
            // 
            // metroPanel2
            // 
            this.metroPanel2.AutoScroll = true;
            this.metroPanel2.Controls.Add(this.metroLabel2);
            this.metroPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel2.HorizontalScrollbar = true;
            this.metroPanel2.HorizontalScrollbarBarColor = true;
            this.metroPanel2.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel2.HorizontalScrollbarSize = 10;
            this.metroPanel2.Location = new System.Drawing.Point(0, 0);
            this.metroPanel2.Name = "metroPanel2";
            this.metroPanel2.Size = new System.Drawing.Size(594, 144);
            this.metroPanel2.TabIndex = 1;
            this.metroPanel2.VerticalScrollbar = true;
            this.metroPanel2.VerticalScrollbarBarColor = true;
            this.metroPanel2.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel2.VerticalScrollbarSize = 10;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(4, 4);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(60, 19);
            this.metroLabel2.TabIndex = 2;
            this.metroLabel2.Text = "Schemes";
            // 
            // metroLabel3
            // 
            this.metroLabel3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(27, 498);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(51, 19);
            this.metroLabel3.TabIndex = 2;
            this.metroLabel3.Text = "Priority";
            // 
            // ctrlPriority
            // 
            this.ctrlPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctrlPriority.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPriority.Location = new System.Drawing.Point(84, 496);
            this.ctrlPriority.Name = "ctrlPriority";
            this.ctrlPriority.Size = new System.Drawing.Size(211, 23);
            this.ctrlPriority.TabIndex = 3;
            this.ctrlPriority.Text = "metroTrackBar1";
            this.ctrlPriority.Scroll += new System.Windows.Forms.ScrollEventHandler(this.ctrlPriority_Scroll);
            // 
            // ctrlLabelPriority
            // 
            this.ctrlLabelPriority.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ctrlLabelPriority.AutoSize = true;
            this.ctrlLabelPriority.Location = new System.Drawing.Point(301, 498);
            this.ctrlLabelPriority.Name = "ctrlLabelPriority";
            this.ctrlLabelPriority.Size = new System.Drawing.Size(23, 19);
            this.ctrlLabelPriority.TabIndex = 2;
            this.ctrlLabelPriority.Text = "50";
            // 
            // frmAddProcess
            // 
            this.AcceptButton = this.ctrlButtonOkay;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.ctrlButtonCancel;
            this.ClientSize = new System.Drawing.Size(640, 574);
            this.Controls.Add(this.ctrlPriority);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.ctrlLabelPriority);
            this.Controls.Add(this.ctrlButtonCancel);
            this.Controls.Add(this.metroLabel3);
            this.Controls.Add(this.ctrlButtonOkay);
            this.Name = "frmAddProcess";
            this.Text = "Power Control v2 - Select process";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.metroPanel2.ResumeLayout(false);
            this.metroPanel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton ctrlButtonOkay;
        private MetroFramework.Controls.MetroButton ctrlButtonCancel;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private MetroFramework.Controls.MetroPanel metroPanel2;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroTrackBar ctrlPriority;
        private MetroFramework.Controls.MetroLabel ctrlLabelPriority;

    }
}