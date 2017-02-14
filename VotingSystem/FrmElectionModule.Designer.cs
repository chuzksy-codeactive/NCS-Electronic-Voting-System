namespace VotingSystem
{
    partial class FrmElectionModule
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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.CheckBoxAutoOn = new MetroFramework.Controls.MetroCheckBox();
            this.btnEnum = new MetroFramework.Controls.MetroButton();
            this.btnInit = new MetroFramework.Controls.MetroButton();
            this.cmbDeviceName = new MetroFramework.Controls.MetroComboBox();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnScan = new MetroFramework.Controls.MetroButton();
            this.panel2 = new MetroFramework.Controls.MetroPanel();
            this.lblName = new MetroFramework.Controls.MetroLabel();
            this.lblVoterPin = new MetroFramework.Controls.MetroLabel();
            this.metroPanel3 = new MetroFramework.Controls.MetroPanel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.cmbElectionId = new MetroFramework.Controls.MetroComboBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.btnCastVote = new MetroFramework.Controls.MetroButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.Status = new System.Windows.Forms.ToolStripStatusLabel();
            this.metroPanel = new MetroFramework.Controls.MetroPanel();
            this.linkLabel1 = new MetroFramework.Controls.MetroLink();
            this.linkLabel2 = new MetroFramework.Controls.MetroLink();
            this.linkLabel3 = new MetroFramework.Controls.MetroLink();
            this.linkLabel4 = new MetroFramework.Controls.MetroLink();
            this.radioButton4 = new MetroFramework.Controls.MetroRadioButton();
            this.radioButton1 = new MetroFramework.Controls.MetroRadioButton();
            this.radioButton2 = new MetroFramework.Controls.MetroRadioButton();
            this.radioButton3 = new MetroFramework.Controls.MetroRadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.metroPanel3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.metroPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(14, 16);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(83, 95);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(364, 16);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 95);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.CheckBoxAutoOn);
            this.metroPanel1.Controls.Add(this.btnEnum);
            this.metroPanel1.Controls.Add(this.btnInit);
            this.metroPanel1.Controls.Add(this.cmbDeviceName);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(27, 86);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(459, 76);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // CheckBoxAutoOn
            // 
            this.CheckBoxAutoOn.AutoSize = true;
            this.CheckBoxAutoOn.Location = new System.Drawing.Point(16, 48);
            this.CheckBoxAutoOn.Name = "CheckBoxAutoOn";
            this.CheckBoxAutoOn.Size = new System.Drawing.Size(216, 15);
            this.CheckBoxAutoOn.TabIndex = 3;
            this.CheckBoxAutoOn.Text = "Enable AutoOn Event (FDU03, FDU04";
            this.CheckBoxAutoOn.UseSelectable = true;
            this.CheckBoxAutoOn.CheckedChanged += new System.EventHandler(this.CheckBoxAutoOn_CheckedChanged);
            // 
            // btnEnum
            // 
            this.btnEnum.Location = new System.Drawing.Point(349, 17);
            this.btnEnum.Name = "btnEnum";
            this.btnEnum.Size = new System.Drawing.Size(78, 23);
            this.btnEnum.TabIndex = 2;
            this.btnEnum.Text = "Enum Device";
            this.btnEnum.UseSelectable = true;
            this.btnEnum.Click += new System.EventHandler(this.btnEnum_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(278, 17);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(65, 23);
            this.btnInit.TabIndex = 1;
            this.btnInit.Text = "Init Device";
            this.btnInit.UseSelectable = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // cmbDeviceName
            // 
            this.cmbDeviceName.FormattingEnabled = true;
            this.cmbDeviceName.ItemHeight = 23;
            this.cmbDeviceName.Location = new System.Drawing.Point(104, 11);
            this.cmbDeviceName.Name = "cmbDeviceName";
            this.cmbDeviceName.Size = new System.Drawing.Size(168, 29);
            this.cmbDeviceName.TabIndex = 0;
            this.cmbDeviceName.UseSelectable = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(13, 19);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(90, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Device Name:";
            // 
            // btnScan
            // 
            this.btnScan.Location = new System.Drawing.Point(27, 168);
            this.btnScan.Name = "btnScan";
            this.btnScan.Size = new System.Drawing.Size(75, 23);
            this.btnScan.TabIndex = 1;
            this.btnScan.Text = "Scan";
            this.btnScan.UseSelectable = true;
            this.btnScan.Click += new System.EventHandler(this.btnScan_Click);
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblName);
            this.panel2.Controls.Add(this.lblVoterPin);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.picImage);
            this.panel2.HorizontalScrollbarBarColor = true;
            this.panel2.HorizontalScrollbarHighlightOnWheel = false;
            this.panel2.HorizontalScrollbarSize = 10;
            this.panel2.Location = new System.Drawing.Point(27, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(459, 129);
            this.panel2.TabIndex = 2;
            this.panel2.VerticalScrollbarBarColor = true;
            this.panel2.VerticalScrollbarHighlightOnWheel = false;
            this.panel2.VerticalScrollbarSize = 10;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblName.Location = new System.Drawing.Point(105, 42);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 25);
            this.lblName.TabIndex = 7;
            this.lblName.Text = "Voter Fullname";
            // 
            // lblVoterPin
            // 
            this.lblVoterPin.AutoSize = true;
            this.lblVoterPin.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.lblVoterPin.Location = new System.Drawing.Point(105, 16);
            this.lblVoterPin.Name = "lblVoterPin";
            this.lblVoterPin.Size = new System.Drawing.Size(83, 25);
            this.lblVoterPin.TabIndex = 6;
            this.lblVoterPin.Text = "Voter PIN";
            // 
            // metroPanel3
            // 
            this.metroPanel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel3.Controls.Add(this.metroLabel2);
            this.metroPanel3.Controls.Add(this.cmbElectionId);
            this.metroPanel3.HorizontalScrollbarBarColor = true;
            this.metroPanel3.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel3.HorizontalScrollbarSize = 10;
            this.metroPanel3.Location = new System.Drawing.Point(27, 347);
            this.metroPanel3.Name = "metroPanel3";
            this.metroPanel3.Size = new System.Drawing.Size(210, 129);
            this.metroPanel3.TabIndex = 3;
            this.metroPanel3.VerticalScrollbarBarColor = true;
            this.metroPanel3.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel3.VerticalScrollbarSize = 10;
            this.metroPanel3.Visible = false;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(14, 14);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(120, 19);
            this.metroLabel2.TabIndex = 76;
            this.metroLabel2.Text = "Select Election Post";
            // 
            // cmbElectionId
            // 
            this.cmbElectionId.FormattingEnabled = true;
            this.cmbElectionId.ItemHeight = 23;
            this.cmbElectionId.Location = new System.Drawing.Point(14, 39);
            this.cmbElectionId.Name = "cmbElectionId";
            this.cmbElectionId.Size = new System.Drawing.Size(189, 29);
            this.cmbElectionId.TabIndex = 0;
            this.cmbElectionId.UseSelectable = true;
            this.cmbElectionId.SelectedIndexChanged += new System.EventHandler(this.cmbElectionId_SelectedIndexChanged);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(411, 494);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 6;
            this.metroButton1.Text = "Cancel";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnCastVote
            // 
            this.btnCastVote.Location = new System.Drawing.Point(330, 494);
            this.btnCastVote.Name = "btnCastVote";
            this.btnCastVote.Size = new System.Drawing.Size(75, 23);
            this.btnCastVote.TabIndex = 5;
            this.btnCastVote.Text = "Cast Vote";
            this.btnCastVote.UseSelectable = true;
            this.btnCastVote.Click += new System.EventHandler(this.btnCastVote_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Status});
            this.statusStrip1.Location = new System.Drawing.Point(20, 547);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(477, 22);
            this.statusStrip1.TabIndex = 76;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // Status
            // 
            this.Status.Name = "Status";
            this.Status.Size = new System.Drawing.Size(118, 17);
            this.Status.Text = "toolStripStatusLabel1";
            // 
            // metroPanel
            // 
            this.metroPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel.Controls.Add(this.linkLabel1);
            this.metroPanel.Controls.Add(this.linkLabel2);
            this.metroPanel.Controls.Add(this.linkLabel3);
            this.metroPanel.Controls.Add(this.linkLabel4);
            this.metroPanel.Controls.Add(this.radioButton4);
            this.metroPanel.Controls.Add(this.radioButton1);
            this.metroPanel.Controls.Add(this.radioButton2);
            this.metroPanel.Controls.Add(this.radioButton3);
            this.metroPanel.HorizontalScrollbarBarColor = true;
            this.metroPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel.HorizontalScrollbarSize = 10;
            this.metroPanel.Location = new System.Drawing.Point(244, 347);
            this.metroPanel.Name = "metroPanel";
            this.metroPanel.Size = new System.Drawing.Size(242, 129);
            this.metroPanel.TabIndex = 4;
            this.metroPanel.VerticalScrollbarBarColor = true;
            this.metroPanel.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel.VerticalScrollbarSize = 10;
            this.metroPanel.Visible = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.Location = new System.Drawing.Point(162, 88);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(72, 23);
            this.linkLabel1.TabIndex = 92;
            this.linkLabel1.Text = "View";
            this.linkLabel1.UseSelectable = true;
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // linkLabel2
            // 
            this.linkLabel2.Location = new System.Drawing.Point(162, 62);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(72, 23);
            this.linkLabel2.TabIndex = 91;
            this.linkLabel2.Text = "View";
            this.linkLabel2.UseSelectable = true;
            this.linkLabel2.Click += new System.EventHandler(this.linkLabel2_Click);
            // 
            // linkLabel3
            // 
            this.linkLabel3.Location = new System.Drawing.Point(162, 36);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(72, 23);
            this.linkLabel3.TabIndex = 90;
            this.linkLabel3.Text = "View";
            this.linkLabel3.UseSelectable = true;
            this.linkLabel3.Click += new System.EventHandler(this.linkLabel3_Click);
            // 
            // linkLabel4
            // 
            this.linkLabel4.Location = new System.Drawing.Point(162, 8);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(72, 23);
            this.linkLabel4.TabIndex = 89;
            this.linkLabel4.Text = "View";
            this.linkLabel4.UseSelectable = true;
            this.linkLabel4.Click += new System.EventHandler(this.linkLabel4_Click);
            // 
            // radioButton4
            // 
            this.radioButton4.AutoSize = true;
            this.radioButton4.Location = new System.Drawing.Point(3, 12);
            this.radioButton4.Name = "radioButton4";
            this.radioButton4.Size = new System.Drawing.Size(127, 15);
            this.radioButton4.TabIndex = 0;
            this.radioButton4.Text = "metroRadioButton4";
            this.radioButton4.UseSelectable = true;
            this.radioButton4.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(3, 39);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(127, 15);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.Text = "metroRadioButton1";
            this.radioButton1.UseSelectable = true;
            this.radioButton1.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(3, 66);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(127, 15);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "metroRadioButton2";
            this.radioButton2.UseSelectable = true;
            this.radioButton2.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(3, 92);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(127, 15);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "metroRadioButton3";
            this.radioButton3.UseSelectable = true;
            this.radioButton3.CheckedChanged += new System.EventHandler(this.radioButton4_CheckedChanged);
            // 
            // FrmElectionModule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::VotingSystem.Properties.Resources.elections__8_;
            this.BackImagePadding = new System.Windows.Forms.Padding(160, 16, 0, 0);
            this.BackMaxSize = 32;
            this.ClientSize = new System.Drawing.Size(517, 589);
            this.Controls.Add(this.metroPanel);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnCastVote);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.metroPanel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.btnScan);
            this.Controls.Add(this.metroPanel1);
            this.Name = "FrmElectionModule";
            this.Text = "Cast Election ";
            this.Load += new System.EventHandler(this.FrmElectionModule_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.metroPanel3.ResumeLayout(false);
            this.metroPanel3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.metroPanel.ResumeLayout(false);
            this.metroPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.PictureBox pictureBox1;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroCheckBox CheckBoxAutoOn;
        private MetroFramework.Controls.MetroButton btnEnum;
        private MetroFramework.Controls.MetroButton btnInit;
        private MetroFramework.Controls.MetroComboBox cmbDeviceName;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnScan;
        private MetroFramework.Controls.MetroPanel panel2;
        private MetroFramework.Controls.MetroLabel lblName;
        private MetroFramework.Controls.MetroLabel lblVoterPin;
        private MetroFramework.Controls.MetroPanel metroPanel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroComboBox cmbElectionId;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroButton btnCastVote;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel Status;
        private MetroFramework.Controls.MetroPanel metroPanel;
        private MetroFramework.Controls.MetroLink linkLabel1;
        private MetroFramework.Controls.MetroLink linkLabel2;
        private MetroFramework.Controls.MetroLink linkLabel3;
        private MetroFramework.Controls.MetroLink linkLabel4;
        private MetroFramework.Controls.MetroRadioButton radioButton4;
        private MetroFramework.Controls.MetroRadioButton radioButton3;
        private MetroFramework.Controls.MetroRadioButton radioButton2;
        private MetroFramework.Controls.MetroRadioButton radioButton1;
    }
}