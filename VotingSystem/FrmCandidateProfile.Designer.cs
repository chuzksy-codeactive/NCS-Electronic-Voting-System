namespace VotingSystem
{
    partial class FrmCandidateProfile
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
            this.profileTab = new MetroFramework.Controls.MetroTabControl();
            this.positionTab = new MetroFramework.Controls.MetroTabPage();
            this.lblManifesto = new MetroFramework.Controls.MetroLabel();
            this.lblEmail = new MetroFramework.Controls.MetroLabel();
            this.lblPhonenumber = new MetroFramework.Controls.MetroLabel();
            this.lblFullname = new MetroFramework.Controls.MetroLabel();
            this.lblCandidatePin = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnClose = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.profileTab.SuspendLayout();
            this.positionTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(345, 7);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(83, 102);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 14;
            this.picImage.TabStop = false;
            // 
            // profileTab
            // 
            this.profileTab.Controls.Add(this.positionTab);
            this.profileTab.FontSize = MetroFramework.MetroTabControlSize.Tall;
            this.profileTab.FontWeight = MetroFramework.MetroTabControlWeight.Bold;
            this.profileTab.Location = new System.Drawing.Point(24, 31);
            this.profileTab.Name = "profileTab";
            this.profileTab.SelectedIndex = 0;
            this.profileTab.Size = new System.Drawing.Size(449, 295);
            this.profileTab.TabIndex = 8;
            this.profileTab.UseCustomBackColor = true;
            this.profileTab.UseSelectable = true;
            // 
            // positionTab
            // 
            this.positionTab.Controls.Add(this.picImage);
            this.positionTab.Controls.Add(this.lblManifesto);
            this.positionTab.Controls.Add(this.lblEmail);
            this.positionTab.Controls.Add(this.lblPhonenumber);
            this.positionTab.Controls.Add(this.lblFullname);
            this.positionTab.Controls.Add(this.lblCandidatePin);
            this.positionTab.Controls.Add(this.metroLabel5);
            this.positionTab.Controls.Add(this.metroLabel4);
            this.positionTab.Controls.Add(this.metroLabel3);
            this.positionTab.Controls.Add(this.metroLabel2);
            this.positionTab.Controls.Add(this.metroLabel1);
            this.positionTab.HorizontalScrollbarBarColor = true;
            this.positionTab.HorizontalScrollbarHighlightOnWheel = false;
            this.positionTab.HorizontalScrollbarSize = 10;
            this.positionTab.Location = new System.Drawing.Point(4, 44);
            this.positionTab.Name = "positionTab";
            this.positionTab.Size = new System.Drawing.Size(441, 247);
            this.positionTab.TabIndex = 0;
            this.positionTab.Text = "position";
            this.positionTab.UseCustomBackColor = true;
            this.positionTab.VerticalScrollbarBarColor = true;
            this.positionTab.VerticalScrollbarHighlightOnWheel = false;
            this.positionTab.VerticalScrollbarSize = 10;
            // 
            // lblManifesto
            // 
            this.lblManifesto.Location = new System.Drawing.Point(145, 155);
            this.lblManifesto.Name = "lblManifesto";
            this.lblManifesto.Size = new System.Drawing.Size(283, 87);
            this.lblManifesto.TabIndex = 11;
            this.lblManifesto.Text = "Candidate Pin:";
            this.lblManifesto.UseCustomBackColor = true;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(145, 122);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(94, 19);
            this.lblEmail.TabIndex = 10;
            this.lblEmail.Text = "Candidate Pin:";
            this.lblEmail.UseCustomBackColor = true;
            // 
            // lblPhonenumber
            // 
            this.lblPhonenumber.AutoSize = true;
            this.lblPhonenumber.Location = new System.Drawing.Point(145, 89);
            this.lblPhonenumber.Name = "lblPhonenumber";
            this.lblPhonenumber.Size = new System.Drawing.Size(94, 19);
            this.lblPhonenumber.TabIndex = 9;
            this.lblPhonenumber.Text = "Candidate Pin:";
            this.lblPhonenumber.UseCustomBackColor = true;
            // 
            // lblFullname
            // 
            this.lblFullname.AutoSize = true;
            this.lblFullname.Location = new System.Drawing.Point(145, 57);
            this.lblFullname.Name = "lblFullname";
            this.lblFullname.Size = new System.Drawing.Size(94, 19);
            this.lblFullname.TabIndex = 8;
            this.lblFullname.Text = "Candidate Pin:";
            this.lblFullname.UseCustomBackColor = true;
            // 
            // lblCandidatePin
            // 
            this.lblCandidatePin.AutoSize = true;
            this.lblCandidatePin.Location = new System.Drawing.Point(145, 23);
            this.lblCandidatePin.Name = "lblCandidatePin";
            this.lblCandidatePin.Size = new System.Drawing.Size(94, 19);
            this.lblCandidatePin.TabIndex = 7;
            this.lblCandidatePin.Text = "Candidate Pin:";
            this.lblCandidatePin.UseCustomBackColor = true;
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel5.Location = new System.Drawing.Point(55, 156);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(79, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Manifesto:";
            this.metroLabel5.UseCustomBackColor = true;
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel4.Location = new System.Drawing.Point(29, 123);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(107, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Email Address:";
            this.metroLabel4.UseCustomBackColor = true;
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel3.Location = new System.Drawing.Point(28, 90);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(108, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Phonenumber:";
            this.metroLabel3.UseCustomBackColor = true;
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel2.Location = new System.Drawing.Point(12, 57);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(125, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Candidate Name:";
            this.metroLabel2.UseCustomBackColor = true;
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.metroLabel1.Location = new System.Drawing.Point(30, 24);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(106, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Candidate Pin:";
            this.metroLabel1.UseCustomBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(398, 346);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 9;
            this.btnClose.Text = "Close";
            this.btnClose.UseSelectable = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FrmCandidateProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 395);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.profileTab);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCandidateProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Candidate Profile";
            this.Load += new System.EventHandler(this.FrmCandidateProfile_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.profileTab.ResumeLayout(false);
            this.positionTab.ResumeLayout(false);
            this.positionTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picImage;
        private MetroFramework.Controls.MetroTabControl profileTab;
        private MetroFramework.Controls.MetroTabPage positionTab;
        private MetroFramework.Controls.MetroLabel lblManifesto;
        private MetroFramework.Controls.MetroLabel lblEmail;
        private MetroFramework.Controls.MetroLabel lblPhonenumber;
        private MetroFramework.Controls.MetroLabel lblFullname;
        private MetroFramework.Controls.MetroLabel lblCandidatePin;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnClose;
    }
}