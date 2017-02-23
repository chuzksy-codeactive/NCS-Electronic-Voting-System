namespace VotingSystem
{
    partial class FrmMain
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
            this.lnkSettings = new MetroFramework.Controls.MetroLink();
            this.lnkClose = new MetroFramework.Controls.MetroLink();
            this.msmMain = new MetroFramework.Components.MetroStyleManager(this.components);
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.lnkUser = new MetroFramework.Controls.MetroLink();
            this.mContextMenuUser = new MetroFramework.Controls.MetroContextMenu(this.components);
            this.changePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOffToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.mContextMenuUser.SuspendLayout();
            this.SuspendLayout();
            // 
            // lnkSettings
            // 
            this.lnkSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkSettings.DisplayFocus = true;
            this.lnkSettings.Image = global::VotingSystem.Properties.Resources.settings;
            this.lnkSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkSettings.ImageSize = 32;
            this.lnkSettings.Location = new System.Drawing.Point(169, 3);
            this.lnkSettings.Name = "lnkSettings";
            this.lnkSettings.NoFocusImage = global::VotingSystem.Properties.Resources.settings__2_;
            this.lnkSettings.Size = new System.Drawing.Size(34, 36);
            this.lnkSettings.TabIndex = 1;
            this.lnkSettings.UseSelectable = true;
            this.lnkSettings.Click += new System.EventHandler(this.lnkSettings_Click);
            // 
            // lnkClose
            // 
            this.lnkClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkClose.Image = global::VotingSystem.Properties.Resources.cancel__1_;
            this.lnkClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkClose.ImageSize = 32;
            this.lnkClose.Location = new System.Drawing.Point(129, 3);
            this.lnkClose.Name = "lnkClose";
            this.lnkClose.NoFocusImage = global::VotingSystem.Properties.Resources.cancel__2_;
            this.lnkClose.Size = new System.Drawing.Size(34, 36);
            this.lnkClose.TabIndex = 0;
            this.lnkClose.UseSelectable = true;
            this.lnkClose.Click += new System.EventHandler(this.lnkClose_Click);
            // 
            // msmMain
            // 
            this.msmMain.Owner = this;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.Controls.Add(this.lnkSettings);
            this.flowLayoutPanel1.Controls.Add(this.lnkClose);
            this.flowLayoutPanel1.Controls.Add(this.lnkUser);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.RightToLeft;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(914, 4);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(206, 42);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // lnkUser
            // 
            this.lnkUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkUser.AutoSize = true;
            this.lnkUser.FontSize = MetroFramework.MetroLinkSize.Tall;
            this.lnkUser.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.lnkUser.Image = global::VotingSystem.Properties.Resources.user__7_;
            this.lnkUser.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lnkUser.ImageSize = 32;
            this.lnkUser.Location = new System.Drawing.Point(3, 3);
            this.lnkUser.Margin = new System.Windows.Forms.Padding(3, 3, 0, 3);
            this.lnkUser.Name = "lnkUser";
            this.lnkUser.NoFocusImage = global::VotingSystem.Properties.Resources.user__6_;
            this.lnkUser.Size = new System.Drawing.Size(123, 36);
            this.lnkUser.TabIndex = 2;
            this.lnkUser.Text = "username";
            this.lnkUser.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lnkUser.UseSelectable = true;
            this.lnkUser.Click += new System.EventHandler(this.lnkUser_Click);
            // 
            // mContextMenuUser
            // 
            this.mContextMenuUser.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.mContextMenuUser.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changePasswordToolStripMenuItem,
            this.lockToolStripMenuItem,
            this.logOffToolStripMenuItem,
            this.toolStripMenuItem1,
            this.exitToolStripMenuItem});
            this.mContextMenuUser.Name = "mContextMenuUser";
            this.mContextMenuUser.Size = new System.Drawing.Size(194, 106);
            // 
            // changePasswordToolStripMenuItem
            // 
            this.changePasswordToolStripMenuItem.Image = global::VotingSystem.Properties.Resources.password;
            this.changePasswordToolStripMenuItem.Name = "changePasswordToolStripMenuItem";
            this.changePasswordToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.changePasswordToolStripMenuItem.Text = "change password";
            this.changePasswordToolStripMenuItem.Click += new System.EventHandler(this.changePasswordToolStripMenuItem_Click);
            // 
            // lockToolStripMenuItem
            // 
            this.lockToolStripMenuItem.Image = global::VotingSystem.Properties.Resources.padlock;
            this.lockToolStripMenuItem.Name = "lockToolStripMenuItem";
            this.lockToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.lockToolStripMenuItem.Text = "lock";
            this.lockToolStripMenuItem.Click += new System.EventHandler(this.lockToolStripMenuItem_Click);
            // 
            // logOffToolStripMenuItem
            // 
            this.logOffToolStripMenuItem.Image = global::VotingSystem.Properties.Resources.sign_out_option;
            this.logOffToolStripMenuItem.Name = "logOffToolStripMenuItem";
            this.logOffToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.logOffToolStripMenuItem.Text = "log off";
            this.logOffToolStripMenuItem.Click += new System.EventHandler(this.logOffToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(190, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Image = global::VotingSystem.Properties.Resources.logout;
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(193, 24);
            this.exitToolStripMenuItem.Text = "exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackImage = global::VotingSystem.Properties.Resources.logo_generic__2_1;
            this.BackImagePadding = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.BackMaxSize = 120;
            this.ClientSize = new System.Drawing.Size(1121, 689);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "FrmMain";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.msmMain)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.mContextMenuUser.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public MetroFramework.Controls.MetroLink lnkClose;
        public MetroFramework.Controls.MetroLink lnkSettings;
        private MetroFramework.Components.MetroStyleManager msmMain;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroLink lnkUser;
        private MetroFramework.Controls.MetroContextMenu mContextMenuUser;
        private System.Windows.Forms.ToolStripMenuItem changePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOffToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
    }
}