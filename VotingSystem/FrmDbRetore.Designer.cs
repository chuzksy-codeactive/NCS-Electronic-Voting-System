namespace VotingSystem
{
    partial class FrmDbRetore
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
            this.lnkBackup = new MetroFramework.Controls.MetroLink();
            this.lnkCancel = new MetroFramework.Controls.MetroLink();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.lblError = new MetroFramework.Controls.MetroLabel();
            this.lnkBrowse = new MetroFramework.Controls.MetroLink();
            this.txtBackupLocation = new MetroFramework.Controls.MetroTextBox();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkBackup
            // 
            this.lnkBackup.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkBackup.Image = global::VotingSystem.Properties.Resources._checked;
            this.lnkBackup.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkBackup.ImageSize = 32;
            this.lnkBackup.Location = new System.Drawing.Point(494, 8);
            this.lnkBackup.Name = "lnkBackup";
            this.lnkBackup.NoFocusImage = global::VotingSystem.Properties.Resources.checked__1_;
            this.lnkBackup.Size = new System.Drawing.Size(50, 45);
            this.lnkBackup.TabIndex = 7;
            this.lnkBackup.Text = "&backup";
            this.lnkBackup.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkBackup.UseSelectable = true;
            this.lnkBackup.Click += new System.EventHandler(this.lnkBackup_Click);
            // 
            // lnkCancel
            // 
            this.lnkCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkCancel.Image = global::VotingSystem.Properties.Resources.cancel__1_;
            this.lnkCancel.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkCancel.ImageSize = 32;
            this.lnkCancel.Location = new System.Drawing.Point(541, 8);
            this.lnkCancel.Name = "lnkCancel";
            this.lnkCancel.NoFocusImage = global::VotingSystem.Properties.Resources.cancel__2_;
            this.lnkCancel.Size = new System.Drawing.Size(48, 45);
            this.lnkCancel.TabIndex = 6;
            this.lnkCancel.Text = "&cancel";
            this.lnkCancel.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkCancel.UseSelectable = true;
            this.lnkCancel.Click += new System.EventHandler(this.lnkCancel_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.Controls.Add(this.lblError);
            this.metroPanel1.Controls.Add(this.lnkBrowse);
            this.metroPanel1.Controls.Add(this.txtBackupLocation);
            this.metroPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(20, 60);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(550, 214);
            this.metroPanel1.TabIndex = 8;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // lblError
            // 
            this.lblError.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblError.AutoSize = true;
            this.lblError.FontSize = MetroFramework.MetroLabelSize.Small;
            this.lblError.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblError.Location = new System.Drawing.Point(90, 123);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(0, 0);
            this.lblError.Style = MetroFramework.MetroColorStyle.Red;
            this.lblError.TabIndex = 4;
            this.lblError.UseStyleColors = true;
            // 
            // lnkBrowse
            // 
            this.lnkBrowse.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lnkBrowse.Image = global::VotingSystem.Properties.Resources.folder__2_;
            this.lnkBrowse.ImageSize = 32;
            this.lnkBrowse.Location = new System.Drawing.Point(430, 97);
            this.lnkBrowse.Name = "lnkBrowse";
            this.lnkBrowse.NoFocusImage = global::VotingSystem.Properties.Resources.folder__3_;
            this.lnkBrowse.Size = new System.Drawing.Size(30, 23);
            this.lnkBrowse.TabIndex = 3;
            this.lnkBrowse.UseSelectable = true;
            this.lnkBrowse.Click += new System.EventHandler(this.lnkBrowse_Click);
            // 
            // txtBackupLocation
            // 
            this.txtBackupLocation.Anchor = System.Windows.Forms.AnchorStyles.None;
            // 
            // 
            // 
            this.txtBackupLocation.CustomButton.Image = null;
            this.txtBackupLocation.CustomButton.Location = new System.Drawing.Point(316, 2);
            this.txtBackupLocation.CustomButton.Name = "";
            this.txtBackupLocation.CustomButton.Size = new System.Drawing.Size(21, 21);
            this.txtBackupLocation.CustomButton.Style = MetroFramework.MetroColorStyle.Blue;
            this.txtBackupLocation.CustomButton.TabIndex = 1;
            this.txtBackupLocation.CustomButton.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txtBackupLocation.CustomButton.UseSelectable = true;
            this.txtBackupLocation.CustomButton.Visible = false;
            this.txtBackupLocation.DisplayIcon = true;
            this.txtBackupLocation.Icon = global::VotingSystem.Properties.Resources.folder__1_;
            this.txtBackupLocation.Lines = new string[0];
            this.txtBackupLocation.Location = new System.Drawing.Point(90, 94);
            this.txtBackupLocation.MaxLength = 32767;
            this.txtBackupLocation.Name = "txtBackupLocation";
            this.txtBackupLocation.PasswordChar = '\0';
            this.txtBackupLocation.PromptText = "Database backup path";
            this.txtBackupLocation.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtBackupLocation.SelectedText = "";
            this.txtBackupLocation.SelectionLength = 0;
            this.txtBackupLocation.SelectionStart = 0;
            this.txtBackupLocation.ShortcutsEnabled = true;
            this.txtBackupLocation.Size = new System.Drawing.Size(340, 26);
            this.txtBackupLocation.TabIndex = 2;
            this.txtBackupLocation.UseSelectable = true;
            this.txtBackupLocation.WaterMark = "Database backup path";
            this.txtBackupLocation.WaterMarkColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.txtBackupLocation.WaterMarkFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Pixel);
            this.txtBackupLocation.TextChanged += new System.EventHandler(this.txtBackupLocation_TextChanged);
            // 
            // FrmDbRetore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 294);
            this.ControlBox = false;
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.lnkBackup);
            this.Controls.Add(this.lnkCancel);
            this.Name = "FrmDbRetore";
            this.Text = "Restore Database";
            this.metroPanel1.ResumeLayout(false);
            this.metroPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroLink lnkBackup;
        private MetroFramework.Controls.MetroLink lnkCancel;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroLabel lblError;
        private MetroFramework.Controls.MetroLink lnkBrowse;
        private MetroFramework.Controls.MetroTextBox txtBackupLocation;
    }
}