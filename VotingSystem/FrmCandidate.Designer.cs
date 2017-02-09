namespace VotingSystem
{
    partial class FrmCandidate
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel7 = new MetroFramework.Controls.MetroLabel();
            this.txtFirstname = new MetroFramework.Controls.MetroTextBox();
            this.txtLastname = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.txtPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtManifesto = new MetroFramework.Controls.MetroTextBox();
            this.cmbGender = new MetroFramework.Controls.MetroComboBox();
            this.cmbPost = new MetroFramework.Controls.MetroComboBox();
            this.btnWebCam = new MetroFramework.Controls.MetroButton();
            this.btnUpload = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            this.listView1 = new MetroFramework.Controls.MetroListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(908, 41);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(44, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(49, 29);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 20;
            this.metroLabel1.Text = "Firstname:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(52, 58);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 21;
            this.metroLabel2.Text = "Lastname:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(62, 93);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 22;
            this.metroLabel3.Text = "Gender:";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(74, 122);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 23;
            this.metroLabel4.Text = "Email:";
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(18, 151);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(100, 19);
            this.metroLabel5.TabIndex = 24;
            this.metroLabel5.Text = "Phone number:";
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(61, 186);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(57, 19);
            this.metroLabel6.TabIndex = 25;
            this.metroLabel6.Text = "Position:";
            // 
            // metroLabel7
            // 
            this.metroLabel7.AutoSize = true;
            this.metroLabel7.Location = new System.Drawing.Point(53, 220);
            this.metroLabel7.Name = "metroLabel7";
            this.metroLabel7.Size = new System.Drawing.Size(66, 19);
            this.metroLabel7.TabIndex = 26;
            this.metroLabel7.Text = "Manifesto";
            // 
            // txtFirstname
            // 
            // 
            // 
            // 
            this.txtFirstname.CustomButton.Image = null;
            this.txtFirstname.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtFirstname.CustomButton.Name = "";
            this.txtFirstname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstname.CustomButton.TabIndex = 1;
            this.txtFirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstname.CustomButton.UseSelectable = true;
            this.txtFirstname.CustomButton.Visible = false;
            this.txtFirstname.Lines = new string[0];
            this.txtFirstname.Location = new System.Drawing.Point(125, 25);
            this.txtFirstname.MaxLength = 32767;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PasswordChar = '\0';
            this.txtFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstname.SelectedText = "";
            this.txtFirstname.SelectionLength = 0;
            this.txtFirstname.SelectionStart = 0;
            this.txtFirstname.ShortcutsEnabled = true;
            this.txtFirstname.Size = new System.Drawing.Size(222, 23);
            this.txtFirstname.TabIndex = 0;
            this.txtFirstname.Tag = "Firstname";
            this.txtFirstname.UseSelectable = true;
            this.txtFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstname_KeyPress);
            // 
            // txtLastname
            // 
            // 
            // 
            // 
            this.txtLastname.CustomButton.Image = null;
            this.txtLastname.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtLastname.CustomButton.Name = "";
            this.txtLastname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastname.CustomButton.TabIndex = 1;
            this.txtLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastname.CustomButton.UseSelectable = true;
            this.txtLastname.CustomButton.Visible = false;
            this.txtLastname.Lines = new string[0];
            this.txtLastname.Location = new System.Drawing.Point(125, 54);
            this.txtLastname.MaxLength = 32767;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastname.SelectedText = "";
            this.txtLastname.SelectionLength = 0;
            this.txtLastname.SelectionStart = 0;
            this.txtLastname.ShortcutsEnabled = true;
            this.txtLastname.Size = new System.Drawing.Size(222, 23);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.Tag = "Lastname";
            this.txtLastname.UseSelectable = true;
            this.txtLastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastname_KeyPress);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(124, 118);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(222, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Tag = "Email";
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtPhoneNumber
            // 
            // 
            // 
            // 
            this.txtPhoneNumber.CustomButton.Image = null;
            this.txtPhoneNumber.CustomButton.Location = new System.Drawing.Point(200, 1);
            this.txtPhoneNumber.CustomButton.Name = "";
            this.txtPhoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumber.CustomButton.TabIndex = 1;
            this.txtPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumber.CustomButton.UseSelectable = true;
            this.txtPhoneNumber.CustomButton.Visible = false;
            this.txtPhoneNumber.Lines = new string[0];
            this.txtPhoneNumber.Location = new System.Drawing.Point(124, 147);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.ShortcutsEnabled = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(222, 23);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.Tag = "Phonenumber";
            this.txtPhoneNumber.UseSelectable = true;
            this.txtPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            // 
            // txtManifesto
            // 
            // 
            // 
            // 
            this.txtManifesto.CustomButton.Image = null;
            this.txtManifesto.CustomButton.Location = new System.Drawing.Point(126, 2);
            this.txtManifesto.CustomButton.Name = "";
            this.txtManifesto.CustomButton.Size = new System.Drawing.Size(93, 93);
            this.txtManifesto.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtManifesto.CustomButton.TabIndex = 1;
            this.txtManifesto.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtManifesto.CustomButton.UseSelectable = true;
            this.txtManifesto.CustomButton.Visible = false;
            this.txtManifesto.Lines = new string[0];
            this.txtManifesto.Location = new System.Drawing.Point(125, 211);
            this.txtManifesto.MaxLength = 32767;
            this.txtManifesto.Multiline = true;
            this.txtManifesto.Name = "txtManifesto";
            this.txtManifesto.PasswordChar = '\0';
            this.txtManifesto.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtManifesto.SelectedText = "";
            this.txtManifesto.SelectionLength = 0;
            this.txtManifesto.SelectionStart = 0;
            this.txtManifesto.ShortcutsEnabled = true;
            this.txtManifesto.Size = new System.Drawing.Size(222, 98);
            this.txtManifesto.TabIndex = 6;
            this.txtManifesto.UseSelectable = true;
            this.txtManifesto.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtManifesto.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 23;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(125, 83);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(221, 29);
            this.cmbGender.TabIndex = 2;
            this.cmbGender.Tag = "Gender";
            this.cmbGender.UseSelectable = true;
            // 
            // cmbPost
            // 
            this.cmbPost.FormattingEnabled = true;
            this.cmbPost.ItemHeight = 23;
            this.cmbPost.Location = new System.Drawing.Point(124, 176);
            this.cmbPost.Name = "cmbPost";
            this.cmbPost.Size = new System.Drawing.Size(221, 29);
            this.cmbPost.TabIndex = 5;
            this.cmbPost.Tag = "Position";
            this.cmbPost.UseSelectable = true;
            // 
            // btnWebCam
            // 
            this.btnWebCam.Location = new System.Drawing.Point(443, 31);
            this.btnWebCam.Name = "btnWebCam";
            this.btnWebCam.Size = new System.Drawing.Size(61, 23);
            this.btnWebCam.TabIndex = 7;
            this.btnWebCam.Text = "WebCam";
            this.btnWebCam.UseSelectable = true;
            this.btnWebCam.Click += new System.EventHandler(this.btnWebcam_Click);
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(443, 60);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(61, 23);
            this.btnUpload.TabIndex = 8;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseSelectable = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnWebCam);
            this.metroPanel1.Controls.Add(this.btnUpload);
            this.metroPanel1.Controls.Add(this.cmbGender);
            this.metroPanel1.Controls.Add(this.picImage);
            this.metroPanel1.Controls.Add(this.cmbPost);
            this.metroPanel1.Controls.Add(this.metroLabel1);
            this.metroPanel1.Controls.Add(this.metroLabel2);
            this.metroPanel1.Controls.Add(this.metroLabel3);
            this.metroPanel1.Controls.Add(this.txtManifesto);
            this.metroPanel1.Controls.Add(this.metroLabel4);
            this.metroPanel1.Controls.Add(this.txtPhoneNumber);
            this.metroPanel1.Controls.Add(this.metroLabel5);
            this.metroPanel1.Controls.Add(this.txtEmail);
            this.metroPanel1.Controls.Add(this.metroLabel6);
            this.metroPanel1.Controls.Add(this.txtLastname);
            this.metroPanel1.Controls.Add(this.metroLabel7);
            this.metroPanel1.Controls.Add(this.txtFirstname);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 83);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(522, 343);
            this.metroPanel1.TabIndex = 2;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(353, 25);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(84, 92);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 10;
            this.picImage.TabStop = false;
            this.picImage.Tag = "Passport";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(23, 432);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 3;
            this.btnNew.Text = "New Record";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(104, 432);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(185, 432);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(266, 432);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.listView1.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(553, 83);
            this.listView1.Name = "listView1";
            this.listView1.OwnerDraw = true;
            this.listView1.Size = new System.Drawing.Size(399, 343);
            this.listView1.TabIndex = 41;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.UseSelectable = true;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Name";
            this.columnHeader5.Width = 147;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Gender";
            this.columnHeader6.Width = 71;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Email Address";
            this.columnHeader7.Width = 132;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Position";
            this.columnHeader8.Width = 110;
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = global::VotingSystem.Properties.Resources.application_form_magnify;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(204, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = global::VotingSystem.Properties.Resources.search_accounts1;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(679, 41);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Enter Candidate PIN to Search";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(228, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Enter Candidate PIN to Search";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // FrmCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 509);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "FrmCandidate";
            this.Text = "Register New Candidate";
            this.Load += new System.EventHandler(this.FrmCandidate_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroLabel metroLabel7;
        private MetroFramework.Controls.MetroTextBox txtFirstname;
        private MetroFramework.Controls.MetroTextBox txtLastname;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumber;
        private MetroFramework.Controls.MetroTextBox txtManifesto;
        private MetroFramework.Controls.MetroComboBox cmbGender;
        private MetroFramework.Controls.MetroComboBox cmbPost;
        private MetroFramework.Controls.MetroButton btnWebCam;
        private MetroFramework.Controls.MetroButton btnUpload;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
    }
}