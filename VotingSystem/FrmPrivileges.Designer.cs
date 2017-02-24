namespace VotingSystem
{
    partial class FrmPrivileges
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
            this.chkListbox = new System.Windows.Forms.CheckedListBox();
            this.metroButton1 = new MetroFramework.Controls.MetroButton();
            this.cmbDeleteUser = new MetroFramework.Controls.MetroComboBox();
            this.metroButton2 = new MetroFramework.Controls.MetroButton();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.metroButton3 = new MetroFramework.Controls.MetroButton();
            this.lstUsers = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // chkListbox
            // 
            this.chkListbox.Font = new System.Drawing.Font("Segoe UI Historic", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkListbox.FormattingEnabled = true;
            this.chkListbox.Items.AddRange(new object[] {
            "Voter Registration",
            "Candidate Registration",
            "Vote by PIN",
            "Vote by Fingerprint",
            "Privilege",
            "Create a new User",
            "View Statistics",
            "Set Election Date",
            "Db BackUp"});
            this.chkListbox.Location = new System.Drawing.Point(179, 160);
            this.chkListbox.Name = "chkListbox";
            this.chkListbox.Size = new System.Drawing.Size(178, 224);
            this.chkListbox.TabIndex = 1;
            // 
            // metroButton1
            // 
            this.metroButton1.Location = new System.Drawing.Point(179, 390);
            this.metroButton1.Name = "metroButton1";
            this.metroButton1.Size = new System.Drawing.Size(75, 23);
            this.metroButton1.TabIndex = 3;
            this.metroButton1.Text = "Assign";
            this.metroButton1.UseSelectable = true;
            this.metroButton1.Click += new System.EventHandler(this.metroButton1_Click);
            // 
            // cmbDeleteUser
            // 
            this.cmbDeleteUser.FormattingEnabled = true;
            this.cmbDeleteUser.ItemHeight = 23;
            this.cmbDeleteUser.Location = new System.Drawing.Point(23, 110);
            this.cmbDeleteUser.Name = "cmbDeleteUser";
            this.cmbDeleteUser.Size = new System.Drawing.Size(226, 29);
            this.cmbDeleteUser.TabIndex = 4;
            this.cmbDeleteUser.UseSelectable = true;
            // 
            // metroButton2
            // 
            this.metroButton2.Location = new System.Drawing.Point(255, 110);
            this.metroButton2.Name = "metroButton2";
            this.metroButton2.Size = new System.Drawing.Size(75, 29);
            this.metroButton2.TabIndex = 5;
            this.metroButton2.Text = "Delete";
            this.metroButton2.UseSelectable = true;
            this.metroButton2.Click += new System.EventHandler(this.metroButton2_Click);
            // 
            // metroLabel1
            // 
            this.metroLabel1.AutoSize = true;
            this.metroLabel1.Location = new System.Drawing.Point(23, 88);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(165, 19);
            this.metroLabel1.TabIndex = 6;
            this.metroLabel1.Text = "Select Username to delete:";
            // 
            // metroButton3
            // 
            this.metroButton3.Location = new System.Drawing.Point(260, 390);
            this.metroButton3.Name = "metroButton3";
            this.metroButton3.Size = new System.Drawing.Size(75, 23);
            this.metroButton3.TabIndex = 7;
            this.metroButton3.Text = "Cancel";
            this.metroButton3.UseSelectable = true;
            this.metroButton3.Click += new System.EventHandler(this.metroButton3_Click);
            // 
            // lstUsers
            // 
            this.lstUsers.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstUsers.FormattingEnabled = true;
            this.lstUsers.ItemHeight = 20;
            this.lstUsers.Location = new System.Drawing.Point(24, 157);
            this.lstUsers.Name = "lstUsers";
            this.lstUsers.Size = new System.Drawing.Size(138, 224);
            this.lstUsers.TabIndex = 8;
            this.lstUsers.SelectedIndexChanged += new System.EventHandler(this.lstUsers_SelectedIndexChanged);
            // 
            // FrmPrivileges
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::VotingSystem.Properties.Resources.room_key;
            this.BackImagePadding = new System.Windows.Forms.Padding(250, 20, 0, 0);
            this.BackMaxSize = 32;
            this.ClientSize = new System.Drawing.Size(395, 437);
            this.Controls.Add(this.lstUsers);
            this.Controls.Add(this.metroButton3);
            this.Controls.Add(this.metroLabel1);
            this.Controls.Add(this.metroButton2);
            this.Controls.Add(this.cmbDeleteUser);
            this.Controls.Add(this.metroButton1);
            this.Controls.Add(this.chkListbox);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmPrivileges";
            this.Text = "Set Privileges to Users";
            this.Load += new System.EventHandler(this.FrmPrivileges_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckedListBox chkListbox;
        private MetroFramework.Controls.MetroButton metroButton1;
        private MetroFramework.Controls.MetroComboBox cmbDeleteUser;
        private MetroFramework.Controls.MetroButton metroButton2;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroButton metroButton3;
        private System.Windows.Forms.ListBox lstUsers;
    }
}