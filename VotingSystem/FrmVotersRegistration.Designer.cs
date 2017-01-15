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
            this.label1 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusBar = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnRegister = new System.Windows.Forms.Button();
            this.pnlBiometric = new System.Windows.Forms.Panel();
            this.pgbR3 = new System.Windows.Forms.ProgressBar();
            this.btnCaptureR3 = new System.Windows.Forms.Button();
            this.pgbR2 = new System.Windows.Forms.ProgressBar();
            this.btnCaptureR2 = new System.Windows.Forms.Button();
            this.pgbR1 = new System.Windows.Forms.ProgressBar();
            this.btnCaptureR1 = new System.Windows.Forms.Button();
            this.imgR3 = new System.Windows.Forms.PictureBox();
            this.imgR2 = new System.Windows.Forms.PictureBox();
            this.imgR1 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnEnum = new System.Windows.Forms.Button();
            this.btnInit = new System.Windows.Forms.Button();
            this.cmbDeviceName = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFirstname = new System.Windows.Forms.TextBox();
            this.txtLastname = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnWebcam = new System.Windows.Forms.Button();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnNew = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.pnlBiometric.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgR3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgR2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgR1)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search by Voters PIN:";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(27, 57);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(234, 20);
            this.txtSearch.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(261, 56);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "Personal Information";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.statusStrip1);
            this.panel2.Controls.Add(this.btnRegister);
            this.panel2.Controls.Add(this.pnlBiometric);
            this.panel2.Controls.Add(this.panel3);
            this.panel2.Controls.Add(this.label10);
            this.panel2.Location = new System.Drawing.Point(387, 115);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 340);
            this.panel2.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusBar});
            this.statusStrip1.Location = new System.Drawing.Point(0, 314);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(429, 22);
            this.statusStrip1.TabIndex = 13;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusBar
            // 
            this.statusBar.Name = "statusBar";
            this.statusBar.Size = new System.Drawing.Size(0, 17);
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(334, 250);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(75, 23);
            this.btnRegister.TabIndex = 2;
            this.btnRegister.Text = "Register";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // pnlBiometric
            // 
            this.pnlBiometric.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlBiometric.Controls.Add(this.pgbR3);
            this.pnlBiometric.Controls.Add(this.btnCaptureR3);
            this.pnlBiometric.Controls.Add(this.pgbR2);
            this.pnlBiometric.Controls.Add(this.btnCaptureR2);
            this.pnlBiometric.Controls.Add(this.pgbR1);
            this.pnlBiometric.Controls.Add(this.btnCaptureR1);
            this.pnlBiometric.Controls.Add(this.imgR3);
            this.pnlBiometric.Controls.Add(this.imgR2);
            this.pnlBiometric.Controls.Add(this.imgR1);
            this.pnlBiometric.Location = new System.Drawing.Point(19, 90);
            this.pnlBiometric.Name = "pnlBiometric";
            this.pnlBiometric.Size = new System.Drawing.Size(390, 154);
            this.pnlBiometric.TabIndex = 1;
            // 
            // pgbR3
            // 
            this.pgbR3.Location = new System.Drawing.Point(266, 103);
            this.pgbR3.Name = "pgbR3";
            this.pgbR3.Size = new System.Drawing.Size(75, 10);
            this.pgbR3.TabIndex = 8;
            // 
            // btnCaptureR3
            // 
            this.btnCaptureR3.Location = new System.Drawing.Point(266, 115);
            this.btnCaptureR3.Name = "btnCaptureR3";
            this.btnCaptureR3.Size = new System.Drawing.Size(75, 23);
            this.btnCaptureR3.TabIndex = 2;
            this.btnCaptureR3.Text = "Capture";
            this.btnCaptureR3.UseVisualStyleBackColor = true;
            this.btnCaptureR3.Click += new System.EventHandler(this.btnCaptureR3_Click);
            // 
            // pgbR2
            // 
            this.pgbR2.Location = new System.Drawing.Point(164, 103);
            this.pgbR2.Name = "pgbR2";
            this.pgbR2.Size = new System.Drawing.Size(75, 10);
            this.pgbR2.TabIndex = 6;
            // 
            // btnCaptureR2
            // 
            this.btnCaptureR2.Location = new System.Drawing.Point(164, 115);
            this.btnCaptureR2.Name = "btnCaptureR2";
            this.btnCaptureR2.Size = new System.Drawing.Size(75, 23);
            this.btnCaptureR2.TabIndex = 1;
            this.btnCaptureR2.Text = "Capture";
            this.btnCaptureR2.UseVisualStyleBackColor = true;
            this.btnCaptureR2.Click += new System.EventHandler(this.btnCaptureR2_Click);
            // 
            // pgbR1
            // 
            this.pgbR1.Location = new System.Drawing.Point(64, 103);
            this.pgbR1.Name = "pgbR1";
            this.pgbR1.Size = new System.Drawing.Size(75, 10);
            this.pgbR1.TabIndex = 4;
            // 
            // btnCaptureR1
            // 
            this.btnCaptureR1.Location = new System.Drawing.Point(64, 115);
            this.btnCaptureR1.Name = "btnCaptureR1";
            this.btnCaptureR1.Size = new System.Drawing.Size(75, 23);
            this.btnCaptureR1.TabIndex = 0;
            this.btnCaptureR1.Text = "Capture";
            this.btnCaptureR1.UseVisualStyleBackColor = true;
            this.btnCaptureR1.Click += new System.EventHandler(this.btnCaptureR1_Click);
            // 
            // imgR3
            // 
            this.imgR3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgR3.Location = new System.Drawing.Point(266, 17);
            this.imgR3.Name = "imgR3";
            this.imgR3.Size = new System.Drawing.Size(75, 86);
            this.imgR3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgR3.TabIndex = 2;
            this.imgR3.TabStop = false;
            this.imgR3.Tag = "Third Thumb";
            // 
            // imgR2
            // 
            this.imgR2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgR2.Location = new System.Drawing.Point(164, 17);
            this.imgR2.Name = "imgR2";
            this.imgR2.Size = new System.Drawing.Size(75, 86);
            this.imgR2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgR2.TabIndex = 1;
            this.imgR2.TabStop = false;
            this.imgR2.Tag = "Second Thumb";
            // 
            // imgR1
            // 
            this.imgR1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imgR1.Location = new System.Drawing.Point(64, 17);
            this.imgR1.Name = "imgR1";
            this.imgR1.Size = new System.Drawing.Size(75, 86);
            this.imgR1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgR1.TabIndex = 0;
            this.imgR1.TabStop = false;
            this.imgR1.Tag = "First Thumb";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.btnEnum);
            this.panel3.Controls.Add(this.btnInit);
            this.panel3.Controls.Add(this.cmbDeviceName);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Location = new System.Drawing.Point(19, 19);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(390, 54);
            this.panel3.TabIndex = 0;
            // 
            // btnEnum
            // 
            this.btnEnum.Location = new System.Drawing.Point(311, 14);
            this.btnEnum.Name = "btnEnum";
            this.btnEnum.Size = new System.Drawing.Size(51, 23);
            this.btnEnum.TabIndex = 2;
            this.btnEnum.Text = "Enum";
            this.btnEnum.UseVisualStyleBackColor = true;
            this.btnEnum.Click += new System.EventHandler(this.btnEnum_Click);
            // 
            // btnInit
            // 
            this.btnInit.Location = new System.Drawing.Point(254, 14);
            this.btnInit.Name = "btnInit";
            this.btnInit.Size = new System.Drawing.Size(51, 23);
            this.btnInit.TabIndex = 1;
            this.btnInit.Text = "Init";
            this.btnInit.UseVisualStyleBackColor = true;
            this.btnInit.Click += new System.EventHandler(this.btnInit_Click);
            // 
            // cmbDeviceName
            // 
            this.cmbDeviceName.FormattingEnabled = true;
            this.cmbDeviceName.Location = new System.Drawing.Point(88, 14);
            this.cmbDeviceName.Name = "cmbDeviceName";
            this.cmbDeviceName.Size = new System.Drawing.Size(160, 21);
            this.cmbDeviceName.TabIndex = 0;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(13, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(78, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Device Name: ";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(3, 274);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(327, 26);
            this.label10.TabIndex = 12;
            this.label10.Text = "Note that the Right Thumb fingerprint should be captured 3x. \r\nSo as to save the " +
    "best fingerprint image extraction into the database\r\n";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Firstname: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(36, 56);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Lastname: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(50, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(60, 130);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Email:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(16, 167);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(79, 13);
            this.label7.TabIndex = 4;
            this.label7.Text = "Phone number:";
            // 
            // txtFirstname
            // 
            this.txtFirstname.Location = new System.Drawing.Point(101, 16);
            this.txtFirstname.Name = "txtFirstname";
            this.txtFirstname.Size = new System.Drawing.Size(219, 20);
            this.txtFirstname.TabIndex = 0;
            this.txtFirstname.Tag = "Firstname";
            this.txtFirstname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstname_KeyPress);
            // 
            // txtLastname
            // 
            this.txtLastname.Location = new System.Drawing.Point(101, 53);
            this.txtLastname.Name = "txtLastname";
            this.txtLastname.Size = new System.Drawing.Size(219, 20);
            this.txtLastname.TabIndex = 1;
            this.txtLastname.Tag = "Lastname";
            this.txtLastname.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFirstname_KeyPress);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(101, 127);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(219, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Tag = "Email";
            this.txtEmail.Validating += new System.ComponentModel.CancelEventHandler(this.txtEmail_Validating);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(101, 164);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(219, 20);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.Tag = "Phonenumber";
            this.txtPhoneNumber.Validating += new System.ComponentModel.CancelEventHandler(this.txtPhoneNumber_Validating);
            // 
            // cmbGender
            // 
            this.cmbGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(101, 90);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(218, 21);
            this.cmbGender.TabIndex = 2;
            this.cmbGender.Tag = "Gender";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnUpload);
            this.panel1.Controls.Add(this.btnWebcam);
            this.panel1.Controls.Add(this.picImage);
            this.panel1.Controls.Add(this.cmbGender);
            this.panel1.Controls.Add(this.txtPhoneNumber);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtLastname);
            this.panel1.Controls.Add(this.txtFirstname);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(27, 115);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(345, 307);
            this.panel1.TabIndex = 2;
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(191, 236);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(75, 23);
            this.btnUpload.TabIndex = 6;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // btnWebcam
            // 
            this.btnWebcam.Location = new System.Drawing.Point(191, 206);
            this.btnWebcam.Name = "btnWebcam";
            this.btnWebcam.Size = new System.Drawing.Size(75, 23);
            this.btnWebcam.TabIndex = 5;
            this.btnWebcam.Text = "WebCam";
            this.btnWebcam.UseVisualStyleBackColor = true;
            this.btnWebcam.Click += new System.EventHandler(this.btnWebcam_Click);
            // 
            // picImage
            // 
            this.picImage.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picImage.Location = new System.Drawing.Point(101, 203);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(84, 92);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 10;
            this.picImage.TabStop = false;
            this.picImage.Tag = "Passport";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(383, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(146, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Fingerprint Capture";
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(144, 428);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(75, 23);
            this.btnSubmit.TabIndex = 4;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(219, 428);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(294, 428);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(69, 428);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(75, 23);
            this.btnNew.TabIndex = 12;
            this.btnNew.Text = "New Record";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // FrmVotersRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(846, 519);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.label1);
            this.Name = "FrmVotersRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Voters Registration";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.pnlBiometric.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgR3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgR2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgR1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFirstname;
        private System.Windows.Forms.TextBox txtLastname;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.Panel pnlBiometric;
        private System.Windows.Forms.ProgressBar pgbR3;
        private System.Windows.Forms.Button btnCaptureR3;
        private System.Windows.Forms.ProgressBar pgbR2;
        private System.Windows.Forms.Button btnCaptureR2;
        private System.Windows.Forms.ProgressBar pgbR1;
        private System.Windows.Forms.Button btnCaptureR1;
        private System.Windows.Forms.PictureBox imgR3;
        private System.Windows.Forms.PictureBox imgR2;
        private System.Windows.Forms.PictureBox imgR1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnEnum;
        private System.Windows.Forms.Button btnInit;
        private System.Windows.Forms.ComboBox cmbDeviceName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Button btnWebcam;
        private System.Windows.Forms.PictureBox picImage;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusBar;
        private System.Windows.Forms.Button btnNew;
    }
}

