namespace VotingSystem
{
    partial class FrmVotersRegistration
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.txtSearch = new MetroFramework.Controls.MetroTextBox();
            this.btnSearch = new MetroFramework.Controls.MetroButton();
            this.tbRegistration = new MetroFramework.Controls.MetroTabControl();
            this.tbVoterInfo = new MetroFramework.Controls.MetroTabPage();
            this.panel2 = new MetroFramework.Controls.MetroPanel();
            this.statusBar = new System.Windows.Forms.Label();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cmbDeviceName = new MetroFramework.Controls.MetroComboBox();
            this.pnlBiometric = new MetroFramework.Controls.MetroPanel();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnRegister = new MetroFramework.Controls.MetroButton();
            this.metroLabel8 = new MetroFramework.Controls.MetroLabel();
            this.btnCaptureR3 = new MetroFramework.Controls.MetroButton();
            this.btnCaptureR2 = new MetroFramework.Controls.MetroButton();
            this.btnCaptureR1 = new MetroFramework.Controls.MetroButton();
            this.pgbR3 = new MetroFramework.Controls.MetroProgressBar();
            this.pgbR2 = new MetroFramework.Controls.MetroProgressBar();
            this.pgbR1 = new MetroFramework.Controls.MetroProgressBar();
            this.imgR1 = new System.Windows.Forms.PictureBox();
            this.imgR2 = new System.Windows.Forms.PictureBox();
            this.imgR3 = new System.Windows.Forms.PictureBox();
            this.btnUpload = new MetroFramework.Controls.MetroButton();
            this.btnWebCam = new MetroFramework.Controls.MetroButton();
            this.metroLabel6 = new MetroFramework.Controls.MetroLabel();
            this.txtPhoneNumber = new MetroFramework.Controls.MetroTextBox();
            this.txtEmail = new MetroFramework.Controls.MetroTextBox();
            this.cmbGender = new MetroFramework.Controls.MetroComboBox();
            this.txtLastname = new MetroFramework.Controls.MetroTextBox();
            this.txtFirstname = new MetroFramework.Controls.MetroTextBox();
            this.metroLabel5 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel4 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel3 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel2 = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.btnNew = new MetroFramework.Controls.MetroButton();
            this.btnSubmit = new MetroFramework.Controls.MetroButton();
            this.btnUpdate = new MetroFramework.Controls.MetroButton();
            this.btnDelete = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.tbRegistration.SuspendLayout();
            this.tbVoterInfo.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlBiometric.SuspendLayout();
            this.metroPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgR1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgR3)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(117, 170);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(103, 124);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 10;
            this.picImage.TabStop = false;
            this.picImage.Tag = "Image";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // txtSearch
            // 
            // 
            // 
            // 
            this.txtSearch.CustomButton.Image = null;
            this.txtSearch.CustomButton.Location = new System.Drawing.Point(260, 2);
            this.txtSearch.CustomButton.Name = "";
            this.txtSearch.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtSearch.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtSearch.CustomButton.TabIndex = 1;
            this.txtSearch.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtSearch.CustomButton.UseSelectable = true;
            this.txtSearch.CustomButton.Visible = false;
            this.txtSearch.DisplayIcon = true;
            this.txtSearch.Icon = global::VotingSystem.Properties.Resources.search;
            this.txtSearch.Lines = new string[0];
            this.txtSearch.Location = new System.Drawing.Point(558, 63);
            this.txtSearch.MaxLength = 32767;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PasswordChar = '\0';
            this.txtSearch.PromptText = "Search by Voters\' PIN";
            this.txtSearch.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtSearch.SelectedText = "";
            this.txtSearch.SelectionLength = 0;
            this.txtSearch.SelectionStart = 0;
            this.txtSearch.ShortcutsEnabled = true;
            this.txtSearch.Size = new System.Drawing.Size(284, 26);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.UseSelectable = true;
            this.txtSearch.WaterMark = "Search by Voters\' PIN";
            this.txtSearch.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtSearch.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(842, 63);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(50, 26);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseSelectable = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbRegistration
            // 
            this.tbRegistration.Controls.Add(this.tbVoterInfo);
            this.tbRegistration.FontWeight = MetroFramework.MetroTabControlWeight.Regular;
            this.tbRegistration.ItemSize = new System.Drawing.Size(200, 34);
            this.tbRegistration.Location = new System.Drawing.Point(24, 92);
            this.tbRegistration.Name = "tbRegistration";
            this.tbRegistration.SelectedIndex = 0;
            this.tbRegistration.Size = new System.Drawing.Size(868, 401);
            this.tbRegistration.TabIndex = 0;
            this.tbRegistration.UseSelectable = true;
            // 
            // tbVoterInfo
            // 
            this.tbVoterInfo.Controls.Add(this.panel2);
            this.tbVoterInfo.Controls.Add(this.pnlBiometric);
            this.tbVoterInfo.Controls.Add(this.btnUpload);
            this.tbVoterInfo.Controls.Add(this.btnWebCam);
            this.tbVoterInfo.Controls.Add(this.metroLabel6);
            this.tbVoterInfo.Controls.Add(this.txtPhoneNumber);
            this.tbVoterInfo.Controls.Add(this.txtEmail);
            this.tbVoterInfo.Controls.Add(this.picImage);
            this.tbVoterInfo.Controls.Add(this.cmbGender);
            this.tbVoterInfo.Controls.Add(this.txtLastname);
            this.tbVoterInfo.Controls.Add(this.txtFirstname);
            this.tbVoterInfo.Controls.Add(this.metroLabel5);
            this.tbVoterInfo.Controls.Add(this.metroLabel4);
            this.tbVoterInfo.Controls.Add(this.metroLabel3);
            this.tbVoterInfo.Controls.Add(this.metroLabel2);
            this.tbVoterInfo.Controls.Add(this.metroLabel1);
            this.tbVoterInfo.HorizontalScrollbarBarColor = true;
            this.tbVoterInfo.HorizontalScrollbarHighlightOnWheel = false;
            this.tbVoterInfo.HorizontalScrollbarSize = 10;
            this.tbVoterInfo.Location = new System.Drawing.Point(4, 38);
            this.tbVoterInfo.Name = "tbVoterInfo";
            this.tbVoterInfo.Size = new System.Drawing.Size(860, 359);
            this.tbVoterInfo.TabIndex = 0;
            this.tbVoterInfo.Text = "Voter Information";
            this.tbVoterInfo.VerticalScrollbarBarColor = true;
            this.tbVoterInfo.VerticalScrollbarHighlightOnWheel = false;
            this.tbVoterInfo.VerticalScrollbarSize = 10;
            this.tbVoterInfo.Click += new System.EventHandler(this.tbVoterInfo_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.statusBar);
            this.panel2.Controls.Add(this.metroButton2);
            this.panel2.Controls.Add(this.metroButton1);
            this.panel2.Controls.Add(this.cmbDeviceName);
            this.panel2.HorizontalScrollbarBarColor = true;
            this.panel2.HorizontalScrollbarHighlightOnWheel = false;
            this.panel2.HorizontalScrollbarSize = 10;
            this.panel2.Location = new System.Drawing.Point(400, 13);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(415, 67);
            this.panel2.TabIndex = 18;
            this.panel2.VerticalScrollbarBarColor = true;
            this.panel2.VerticalScrollbarHighlightOnWheel = false;
            this.panel2.VerticalScrollbarSize = 10;
            // 
            // statusBar
            // 
            this.statusBar.AutoSize = true;
            this.statusBar.BackColor = System.Drawing.Color.Transparent;
            this.statusBar.ForeColor = System.Drawing.Color.DarkGreen;
            this.statusBar.Location = new System.Drawing.Point(0, 42);
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 13);
            this.statusBar.TabIndex = 20;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(302, 7);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 29);
            this.metroButton2.TabIndex = 19;
            this.metroButton2.Text = "Enum Device";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.btnEnum_Click);
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(232, 7);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(64, 29);
            this.metroButton1.TabIndex = 18;
            this.metroButton1.Text = "Init Device";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // cmbDeviceName
            // 
            this.cmbDeviceName.FormattingEnabled = true;
            this.cmbDeviceName.ItemHeight = 23;
            this.cmbDeviceName.Location = new System.Drawing.Point(0, 7);
            this.cmbDeviceName.Name = "cmbDeviceName";
            this.cmbDeviceName.Size = new System.Drawing.Size(226, 29);
            this.cmbDeviceName.TabIndex = 17;
            this.cmbDeviceName.UseSelectable = true;
            // 
            // pnlBiometric
            // 
            this.pnlBiometric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBiometric.Controls.Add(this.metroPanel1);
            this.pnlBiometric.Controls.Add(this.btnCaptureR3);
            this.pnlBiometric.Controls.Add(this.btnCaptureR2);
            this.pnlBiometric.Controls.Add(this.btnCaptureR1);
            this.pnlBiometric.Controls.Add(this.pgbR3);
            this.pnlBiometric.Controls.Add(this.pgbR2);
            this.pnlBiometric.Controls.Add(this.pgbR1);
            this.pnlBiometric.Controls.Add(this.imgR1);
            this.pnlBiometric.Controls.Add(this.imgR2);
            this.pnlBiometric.Controls.Add(this.imgR3);
            this.pnlBiometric.HorizontalScrollbarBarColor = true;
            this.pnlBiometric.HorizontalScrollbarHighlightOnWheel = false;
            this.pnlBiometric.HorizontalScrollbarSize = 10;
            this.pnlBiometric.Location = new System.Drawing.Point(400, 86);
            this.pnlBiometric.Name = "pnlBiometric";
            this.pnlBiometric.Size = new System.Drawing.Size(416, 274);
            this.pnlBiometric.TabIndex = 17;
            this.pnlBiometric.VerticalScrollbarBarColor = true;
            this.pnlBiometric.VerticalScrollbarHighlightOnWheel = false;
            this.pnlBiometric.VerticalScrollbarSize = 10;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnRegister);
            this.metroPanel1.Controls.Add(this.metroLabel8);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 207);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(414, 65);
            this.metroPanel1.TabIndex = 9;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(315, 12);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 12;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseSelectable = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // metroLabel8
            // 
            this.metroLabel8.FontSize = MetroFramework.MetroLabelSize.Small;
            this.metroLabel8.ForeColor = System.Drawing.Color.Red;
            this.metroLabel8.Location = new System.Drawing.Point(3, 2);
            this.metroLabel8.Name = "metroLabel8";
            this.metroLabel8.Size = new System.Drawing.Size(306, 49);
            this.metroLabel8.TabIndex = 11;
            this.metroLabel8.Text = "Note that the Right Thumb fingerprint should be\r\ncaptured 3x. So as to save the b" +
    "est fingerprint image\r\nextraction into the database\r\n\r\n";
            // 
            // btnCaptureR3
            // 
            this.btnCaptureR3.Location = new System.Drawing.Point(275, 154);
            this.btnCaptureR3.Name = "btnCaptureR3";
            this.btnCaptureR3.Size = new System.Drawing.Size(96, 23);
            this.btnCaptureR3.TabIndex = 8;
            this.btnCaptureR3.Text = "Capture";
            this.btnCaptureR3.UseSelectable = true;
            this.btnCaptureR3.Click += new System.EventHandler(this.btnCaptureR3_Click);
            // 
            // btnCaptureR2
            // 
            this.btnCaptureR2.Location = new System.Drawing.Point(153, 154);
            this.btnCaptureR2.Name = "btnCaptureR2";
            this.btnCaptureR2.Size = new System.Drawing.Size(96, 23);
            this.btnCaptureR2.TabIndex = 7;
            this.btnCaptureR2.Text = "Capture";
            this.btnCaptureR2.UseSelectable = true;
            this.btnCaptureR2.Click += new System.EventHandler(this.btnCaptureR2_Click);
            // 
            // btnCaptureR1
            // 
            this.btnCaptureR1.Location = new System.Drawing.Point(26, 154);
            this.btnCaptureR1.Name = "btnCaptureR1";
            this.btnCaptureR1.Size = new System.Drawing.Size(96, 23);
            this.btnCaptureR1.TabIndex = 6;
            this.btnCaptureR1.Text = "Capture";
            this.btnCaptureR1.UseSelectable = true;
            this.btnCaptureR1.Click += new System.EventHandler(this.btnCaptureR1_Click);
            // 
            // pgbR3
            // 
            this.pgbR3.Location = new System.Drawing.Point(275, 134);
            this.pgbR3.Name = "pgbR3";
            this.pgbR3.Size = new System.Drawing.Size(96, 13);
            this.pgbR3.TabIndex = 5;
            // 
            // pgbR2
            // 
            this.pgbR2.Location = new System.Drawing.Point(153, 133);
            this.pgbR2.Name = "pgbR2";
            this.pgbR2.Size = new System.Drawing.Size(96, 13);
            this.pgbR2.TabIndex = 4;
            // 
            // pgbR1
            // 
            this.pgbR1.Location = new System.Drawing.Point(26, 134);
            this.pgbR1.Name = "pgbR1";
            this.pgbR1.Size = new System.Drawing.Size(96, 13);
            this.pgbR1.TabIndex = 3;
            // 
            // imgR1
            // 
            this.imgR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgR1.Location = new System.Drawing.Point(26, 16);
            this.imgR1.Name = "imgR1";
            this.imgR1.Size = new System.Drawing.Size(96, 111);
            this.imgR1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgR1.TabIndex = 0;
            this.imgR1.TabStop = false;
            this.imgR1.Tag = "First Thumb";
            // 
            // imgR2
            // 
            this.imgR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgR2.Location = new System.Drawing.Point(153, 16);
            this.imgR2.Name = "imgR2";
            this.imgR2.Size = new System.Drawing.Size(96, 111);
            this.imgR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgR2.TabIndex = 1;
            this.imgR2.TabStop = false;
            this.imgR2.Tag = "Second Thumb";
            // 
            // imgR3
            // 
            this.imgR3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgR3.Location = new System.Drawing.Point(275, 16);
            this.imgR3.Name = "imgR3";
            this.imgR3.Size = new System.Drawing.Size(96, 111);
            this.imgR3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgR3.TabIndex = 2;
            this.imgR3.TabStop = false;
            this.imgR3.Tag = "Third Thumb";
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(226, 271);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseSelectable = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnWebCam
            // 
            this.btnWebCam.Location = new System.Drawing.Point(226, 241);
            this.btnWebCam.Name = "btnWebCam";
            this.btnWebCam.Size = new System.Drawing.Size(75, 23);
            this.btnWebCam.TabIndex = 5;
            this.btnWebCam.Text = "WebCam";
            this.btnWebCam.UseSelectable = true;
            this.btnWebCam.Click += new System.EventHandler(this.btnWebcam_Click);
            // 
            // metroLabel6
            // 
            this.metroLabel6.AutoSize = true;
            this.metroLabel6.Location = new System.Drawing.Point(62, 181);
            this.metroLabel6.Name = "metroLabel6";
            this.metroLabel6.Size = new System.Drawing.Size(49, 19);
            this.metroLabel6.TabIndex = 12;
            this.metroLabel6.Text = "Image:";
            // 
            // txtPhoneNumber
            // 
            // 
            // 
            // 
            this.txtPhoneNumber.CustomButton.Image = null;
            this.txtPhoneNumber.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtPhoneNumber.CustomButton.Name = "";
            this.txtPhoneNumber.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtPhoneNumber.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtPhoneNumber.CustomButton.TabIndex = 1;
            this.txtPhoneNumber.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtPhoneNumber.CustomButton.UseSelectable = true;
            this.txtPhoneNumber.CustomButton.Visible = false;
            this.txtPhoneNumber.Lines = new string[0];
            this.txtPhoneNumber.Location = new System.Drawing.Point(117, 141);
            this.txtPhoneNumber.MaxLength = 32767;
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.PasswordChar = '\0';
            this.txtPhoneNumber.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtPhoneNumber.SelectedText = "";
            this.txtPhoneNumber.SelectionLength = 0;
            this.txtPhoneNumber.SelectionStart = 0;
            this.txtPhoneNumber.ShortcutsEnabled = true;
            this.txtPhoneNumber.Size = new System.Drawing.Size(249, 23);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.Tag = "Phone Number";
            this.txtPhoneNumber.UseSelectable = true;
            this.txtPhoneNumber.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtPhoneNumber.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            // 
            // txtEmail
            // 
            // 
            // 
            // 
            this.txtEmail.CustomButton.Image = null;
            this.txtEmail.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtEmail.CustomButton.Name = "";
            this.txtEmail.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtEmail.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtEmail.CustomButton.TabIndex = 1;
            this.txtEmail.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtEmail.CustomButton.UseSelectable = true;
            this.txtEmail.CustomButton.Visible = false;
            this.txtEmail.Lines = new string[0];
            this.txtEmail.Location = new System.Drawing.Point(117, 111);
            this.txtEmail.MaxLength = 32767;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtEmail.SelectedText = "";
            this.txtEmail.SelectionLength = 0;
            this.txtEmail.SelectionStart = 0;
            this.txtEmail.ShortcutsEnabled = true;
            this.txtEmail.Size = new System.Drawing.Size(249, 23);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Tag = "Email";
            this.txtEmail.UseSelectable = true;
            this.txtEmail.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtEmail.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtEmail.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEmail_KeyPress);
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.ItemHeight = 23;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(117, 76);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(249, 29);
            this.cmbGender.TabIndex = 2;
            this.cmbGender.Tag = "Gender";
            this.cmbGender.UseSelectable = true;
            this.cmbGender.SelectedIndexChanged += new System.EventHandler(this.cmbGender_SelectedIndexChanged);
            this.cmbGender.Validating += new System.ComponentModel.CancelEventHandler(this.cmbGender_Validating);
            // 
            // txtLastname
            // 
            // 
            // 
            // 
            this.txtLastname.CustomButton.Image = null;
            this.txtLastname.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtLastname.CustomButton.Name = "";
            this.txtLastname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtLastname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtLastname.CustomButton.TabIndex = 1;
            this.txtLastname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtLastname.CustomButton.UseSelectable = true;
            this.txtLastname.CustomButton.Visible = false;
            this.txtLastname.Lines = new string[0];
            this.txtLastname.Location = new System.Drawing.Point(117, 47);
            this.txtLastname.MaxLength = 32767;
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.PasswordChar = '\0';
            this.txtLastname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtLastname.SelectedText = "";
            this.txtLastname.SelectionLength = 0;
            this.txtLastname.SelectionStart = 0;
            this.txtLastname.ShortcutsEnabled = true;
            this.txtLastname.Size = new System.Drawing.Size(249, 23);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.Tag = "Lastname";
            this.txtLastname.UseSelectable = true;
            this.txtLastname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtLastname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtLastname_KeyPress);
            this.txtLastname.Validating += new System.ComponentModel.CancelEventHandler(this.txtLastname_Validating);
            // 
            // txtFirstname
            // 
            // 
            // 
            // 
            this.txtFirstname.CustomButton.Image = null;
            this.txtFirstname.CustomButton.Location = new System.Drawing.Point(227, 1);
            this.txtFirstname.CustomButton.Name = "";
            this.txtFirstname.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtFirstname.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtFirstname.CustomButton.TabIndex = 1;
            this.txtFirstname.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtFirstname.CustomButton.UseSelectable = true;
            this.txtFirstname.CustomButton.Visible = false;
            this.txtFirstname.Lines = new string[0];
            this.txtFirstname.Location = new System.Drawing.Point(117, 18);
            this.txtFirstname.MaxLength = 32767;
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.PasswordChar = '\0';
            this.txtFirstname.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtFirstname.SelectedText = "";
            this.txtFirstname.SelectionLength = 0;
            this.txtFirstname.SelectionStart = 0;
            this.txtFirstname.ShortcutsEnabled = true;
            this.txtFirstname.Size = new System.Drawing.Size(249, 23);
            this.txtFirstname.TabIndex = 0;
            this.txtFirstname.Tag = "Firstname";
            this.txtFirstname.UseSelectable = true;
            this.txtFirstname.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtFirstname.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstname_KeyPress);
            this.txtFirstname.Validating += new System.ComponentModel.CancelEventHandler(this.txtFirstname_Validating);
            // 
            // metroLabel5
            // 
            this.metroLabel5.AutoSize = true;
            this.metroLabel5.Location = new System.Drawing.Point(15, 141);
            this.metroLabel5.Name = "metroLabel5";
            this.metroLabel5.Size = new System.Drawing.Size(96, 19);
            this.metroLabel5.TabIndex = 6;
            this.metroLabel5.Text = "Phone number";
            // 
            // metroLabel4
            // 
            this.metroLabel4.AutoSize = true;
            this.metroLabel4.Location = new System.Drawing.Point(67, 112);
            this.metroLabel4.Name = "metroLabel4";
            this.metroLabel4.Size = new System.Drawing.Size(44, 19);
            this.metroLabel4.TabIndex = 5;
            this.metroLabel4.Text = "Email:";
            // 
            // metroLabel3
            // 
            this.metroLabel3.AutoSize = true;
            this.metroLabel3.Location = new System.Drawing.Point(55, 84);
            this.metroLabel3.Name = "metroLabel3";
            this.metroLabel3.Size = new System.Drawing.Size(56, 19);
            this.metroLabel3.TabIndex = 4;
            this.metroLabel3.Text = "Gender:";
            // 
            // metroLabel2
            // 
            this.metroLabel2.AutoSize = true;
            this.metroLabel2.Location = new System.Drawing.Point(44, 50);
            this.metroLabel2.Name = "metroLabel2";
            this.metroLabel2.Size = new System.Drawing.Size(67, 19);
            this.metroLabel2.TabIndex = 3;
            this.metroLabel2.Text = "Lastname:";
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(42, 20);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(69, 19);
            this.metroLabel1.TabIndex = 2;
            this.metroLabel1.Text = "Firstname:";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(24, 499);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "New Record";
            this.btnNew.UseSelectable = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(105, 499);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 5;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseSelectable = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(186, 499);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseSelectable = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(267, 499);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseSelectable = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // FrmVotersRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.BackImage = global::VotingSystem.Properties.Resources.clipboard_with_pencil___1_;
            this.BackImagePadding = new System.Windows.Forms.Padding(220, 18, 0, 0);
            this.BackMaxSize = 32;
            this.ClientSize = new System.Drawing.Size(915, 582);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.tbRegistration);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Name = "FrmVotersRegistration";
            this.Text = "Register New Voter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.tbRegistration.ResumeLayout(false);
            this.tbVoterInfo.ResumeLayout(false);
            this.tbVoterInfo.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.pnlBiometric.ResumeLayout(false);
            this.metroPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgR1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgR3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private MetroFramework.Controls.MetroTextBox txtSearch;
        private MetroFramework.Controls.MetroButton btnSearch;
        private MetroFramework.Controls.MetroTabControl tbRegistration;
        private MetroFramework.Controls.MetroTabPage tbVoterInfo;
        private MetroFramework.Controls.MetroButton btnUpload;
        private MetroFramework.Controls.MetroButton btnWebCam;
        private MetroFramework.Controls.MetroLabel metroLabel6;
        private MetroFramework.Controls.MetroTextBox txtPhoneNumber;
        private MetroFramework.Controls.MetroTextBox txtEmail;
        private MetroFramework.Controls.MetroComboBox cmbGender;
        private MetroFramework.Controls.MetroTextBox txtLastname;
        private MetroFramework.Controls.MetroTextBox txtFirstname;
        private MetroFramework.Controls.MetroLabel metroLabel5;
        private MetroFramework.Controls.MetroLabel metroLabel4;
        private MetroFramework.Controls.MetroLabel metroLabel3;
        private MetroFramework.Controls.MetroLabel metroLabel2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton btnNew;
        private MetroFramework.Controls.MetroButton btnSubmit;
        private MetroFramework.Controls.MetroButton btnUpdate;
        private MetroFramework.Controls.MetroButton btnDelete;
        private MetroFramework.Controls.MetroPanel pnlBiometric;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnRegister;
        private MetroFramework.Controls.MetroLabel metroLabel8;
        private MetroFramework.Controls.MetroButton btnCaptureR3;
        private MetroFramework.Controls.MetroButton btnCaptureR2;
        private MetroFramework.Controls.MetroButton btnCaptureR1;
        private MetroFramework.Controls.MetroProgressBar pgbR3;
        private MetroFramework.Controls.MetroProgressBar pgbR2;
        private MetroFramework.Controls.MetroProgressBar pgbR1;
        private System.Windows.Forms.PictureBox imgR1;
        private System.Windows.Forms.PictureBox imgR2;
        private System.Windows.Forms.PictureBox imgR3;
        private MetroFramework.Controls.MetroPanel panel2;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cmbDeviceName;
        private System.Windows.Forms.Label statusBar;
    }
}

