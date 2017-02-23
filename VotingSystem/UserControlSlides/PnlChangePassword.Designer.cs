namespace VotingSystem.UserControlSlides
{
    partial class PnlChangePassword
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnChangePassword = new MetroFramework.Controls.MetroButton();
            this.lnkBack = new MetroFramework.Controls.MetroLink();
            this.txtConfirmPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtNewPassword = new MetroFramework.Controls.MetroTextBox();
            this.txtOldPassword = new MetroFramework.Controls.MetroTextBox();
            this.lnkUsername = new MetroFramework.Controls.MetroLink();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.metroPanel1.Controls.Add(this.btnChangePassword);
            this.metroPanel1.Controls.Add(this.txtConfirmPassword);
            this.metroPanel1.Controls.Add(this.txtNewPassword);
            this.metroPanel1.Controls.Add(this.txtOldPassword);
            this.metroPanel1.Controls.Add(this.lnkUsername);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 84);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(947, 339);
            this.metroPanel1.TabIndex = 0;
            this.metroPanel1.UseStyleColors = true;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnChangePassword
            // 
            this.btnChangePassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnChangePassword.Location = new System.Drawing.Point(525, 274);
            this.btnChangePassword.Name = "btnChangePassword";
            this.btnChangePassword.Size = new System.Drawing.Size(107, 23);
            this.btnChangePassword.TabIndex = 7;
            this.btnChangePassword.Text = "change password";
            this.btnChangePassword.UseSelectable = true;
            this.btnChangePassword.Click += new System.EventHandler(this.btnChangePassword_Click);
            // 
            // lnkBack
            // 
            this.lnkBack.Image = global::VotingSystem.Properties.Resources.left_arrow__2_;
            this.lnkBack.ImageSize = 32;
            this.lnkBack.Location = new System.Drawing.Point(902, 3);
            this.lnkBack.Name = "lnkBack";
            this.lnkBack.NoFocusImage = global::VotingSystem.Properties.Resources.left_arrow__3_;
            this.lnkBack.Size = new System.Drawing.Size(42, 31);
            this.lnkBack.TabIndex = 1;
            this.lnkBack.UseCustomBackColor = true;
            this.lnkBack.UseSelectable = true;
            this.lnkBack.Click += new System.EventHandler(this.lnkBack_Click);
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtConfirmPassword.CustomButton.Image = null;
            this.txtConfirmPassword.CustomButton.Location = new System.Drawing.Point(234, 2);
            this.txtConfirmPassword.CustomButton.Name = "";
            this.txtConfirmPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtConfirmPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtConfirmPassword.CustomButton.TabIndex = 1;
            this.txtConfirmPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtConfirmPassword.CustomButton.UseSelectable = true;
            this.txtConfirmPassword.CustomButton.Visible = false;
            this.txtConfirmPassword.DisplayIcon = true;
            this.txtConfirmPassword.Icon = global::VotingSystem.Properties.Resources.password;
            this.txtConfirmPassword.Lines = new string[0];
            this.txtConfirmPassword.Location = new System.Drawing.Point(375, 241);
            this.txtConfirmPassword.MaxLength = 32767;
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.PasswordChar = '●';
            this.txtConfirmPassword.PromptText = "confirm new password";
            this.txtConfirmPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtConfirmPassword.SelectedText = "";
            this.txtConfirmPassword.SelectionLength = 0;
            this.txtConfirmPassword.SelectionStart = 0;
            this.txtConfirmPassword.ShortcutsEnabled = true;
            this.txtConfirmPassword.Size = new System.Drawing.Size(258, 26);
            this.txtConfirmPassword.TabIndex = 6;
            this.txtConfirmPassword.UseSelectable = true;
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            this.txtConfirmPassword.WaterMark = "confirm new password";
            this.txtConfirmPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtConfirmPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtNewPassword
            // 
            this.txtNewPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtNewPassword.CustomButton.Image = null;
            this.txtNewPassword.CustomButton.Location = new System.Drawing.Point(234, 2);
            this.txtNewPassword.CustomButton.Name = "";
            this.txtNewPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtNewPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtNewPassword.CustomButton.TabIndex = 1;
            this.txtNewPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtNewPassword.CustomButton.UseSelectable = true;
            this.txtNewPassword.CustomButton.Visible = false;
            this.txtNewPassword.DisplayIcon = true;
            this.txtNewPassword.Icon = global::VotingSystem.Properties.Resources.password;
            this.txtNewPassword.Lines = new string[0];
            this.txtNewPassword.Location = new System.Drawing.Point(375, 209);
            this.txtNewPassword.MaxLength = 32767;
            this.txtNewPassword.Name = "txtNewPassword";
            this.txtNewPassword.PasswordChar = '●';
            this.txtNewPassword.PromptText = "enter new password";
            this.txtNewPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtNewPassword.SelectedText = "";
            this.txtNewPassword.SelectionLength = 0;
            this.txtNewPassword.SelectionStart = 0;
            this.txtNewPassword.ShortcutsEnabled = true;
            this.txtNewPassword.Size = new System.Drawing.Size(258, 26);
            this.txtNewPassword.TabIndex = 5;
            this.txtNewPassword.UseSelectable = true;
            this.txtNewPassword.UseSystemPasswordChar = true;
            this.txtNewPassword.WaterMark = "enter new password";
            this.txtNewPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtNewPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // txtOldPassword
            // 
            this.txtOldPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtOldPassword.CustomButton.Image = null;
            this.txtOldPassword.CustomButton.Location = new System.Drawing.Point(234, 2);
            this.txtOldPassword.CustomButton.Name = "";
            this.txtOldPassword.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtOldPassword.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtOldPassword.CustomButton.TabIndex = 1;
            this.txtOldPassword.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtOldPassword.CustomButton.UseSelectable = true;
            this.txtOldPassword.CustomButton.Visible = false;
            this.txtOldPassword.DisplayIcon = true;
            this.txtOldPassword.Icon = global::VotingSystem.Properties.Resources.padlock;
            this.txtOldPassword.Lines = new string[0];
            this.txtOldPassword.Location = new System.Drawing.Point(375, 177);
            this.txtOldPassword.MaxLength = 32767;
            this.txtOldPassword.Name = "txtOldPassword";
            this.txtOldPassword.PasswordChar = '●';
            this.txtOldPassword.PromptText = "old password";
            this.txtOldPassword.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtOldPassword.SelectedText = "";
            this.txtOldPassword.SelectionLength = 0;
            this.txtOldPassword.SelectionStart = 0;
            this.txtOldPassword.ShortcutsEnabled = true;
            this.txtOldPassword.Size = new System.Drawing.Size(258, 26);
            this.txtOldPassword.TabIndex = 4;
            this.txtOldPassword.UseSelectable = true;
            this.txtOldPassword.UseSystemPasswordChar = true;
            this.txtOldPassword.WaterMark = "old password";
            this.txtOldPassword.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtOldPassword.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            // 
            // lnkUsername
            // 
            this.lnkUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lnkUsername.AutoSize = true;
            this.lnkUsername.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkUsername.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkUsername.Image = global::VotingSystem.Properties.Resources.user__10_;
            this.lnkUsername.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkUsername.ImageSize = 128;
            this.lnkUsername.Location = new System.Drawing.Point(401, 15);
            this.lnkUsername.Name = "lnkUsername";
            this.lnkUsername.NoFocusImage = global::VotingSystem.Properties.Resources.user__10_;
            this.lnkUsername.Size = new System.Drawing.Size(219, 156);
            this.lnkUsername.TabIndex = 3;
            this.lnkUsername.Text = "username";
            this.lnkUsername.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkUsername.UseSelectable = true;
            // 
            // PnlChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Controls.Add(this.lnkBack);
            this.Controls.Add(this.metroPanel1);
            this.Name = "PnlChangePassword";
            this.Size = new System.Drawing.Size(947, 506);
            this.UseCustomBackColor = true;
            this.Load += new System.EventHandler(this.PnlChangePassword_Load);
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLink lnkUsername;
        private MetroFramework.Controls.MetroTextBox txtConfirmPassword;
        private MetroFramework.Controls.MetroTextBox txtNewPassword;
        private MetroFramework.Controls.MetroTextBox txtOldPassword;
        private MetroFramework.Controls.MetroButton btnChangePassword;
        private MetroFramework.Controls.MetroLink lnkBack;
    }
}
