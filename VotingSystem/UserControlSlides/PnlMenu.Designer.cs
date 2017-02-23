namespace VotingSystem.UserControlSlides
{
    partial class PnlMenu
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.mtVoter = new MetroFramework.Controls.MetroTile();
            this.mtCandidate = new MetroFramework.Controls.MetroTile();
            this.mtPin = new MetroFramework.Controls.MetroTile();
            this.mtBiometric = new MetroFramework.Controls.MetroTile();
            this.mtPrivilege = new MetroFramework.Controls.MetroTile();
            this.mtUser = new MetroFramework.Controls.MetroTile();
            this.mtStatistics = new MetroFramework.Controls.MetroTile();
            this.mtSetDate = new MetroFramework.Controls.MetroTile();
            this.mtBackupDB = new MetroFramework.Controls.MetroTile();
            this.metroPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // metroPanel1
            // 
            this.metroPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.metroPanel1.Controls.Add(this.flowLayoutPanel1);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(0, 66);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(1096, 398);
            this.metroPanel1.TabIndex = 3;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.flowLayoutPanel1.Controls.Add(this.mtVoter);
            this.flowLayoutPanel1.Controls.Add(this.mtCandidate);
            this.flowLayoutPanel1.Controls.Add(this.mtPin);
            this.flowLayoutPanel1.Controls.Add(this.mtBiometric);
            this.flowLayoutPanel1.Controls.Add(this.mtPrivilege);
            this.flowLayoutPanel1.Controls.Add(this.mtUser);
            this.flowLayoutPanel1.Controls.Add(this.mtStatistics);
            this.flowLayoutPanel1.Controls.Add(this.mtSetDate);
            this.flowLayoutPanel1.Controls.Add(this.mtBackupDB);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(213, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(670, 394);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // mtVoter
            // 
            this.mtVoter.ActiveControl = null;
            this.mtVoter.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.mtVoter.Location = new System.Drawing.Point(3, 3);
            this.mtVoter.Name = "mtVoter";
            this.mtVoter.Size = new System.Drawing.Size(260, 125);
            this.mtVoter.TabIndex = 0;
            this.mtVoter.Text = "Voter Registration";
            this.mtVoter.TileImage = global::VotingSystem.Properties.Resources.icon__4_;
            this.mtVoter.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtVoter.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtVoter.UseSelectable = true;
            this.mtVoter.UseTileImage = true;
            this.mtVoter.Click += new System.EventHandler(this.mtVoter_Click);
            // 
            // mtCandidate
            // 
            this.mtCandidate.ActiveControl = null;
            this.mtCandidate.Location = new System.Drawing.Point(269, 3);
            this.mtCandidate.Name = "mtCandidate";
            this.mtCandidate.Size = new System.Drawing.Size(260, 125);
            this.mtCandidate.TabIndex = 1;
            this.mtCandidate.Text = "Candidate Registration";
            this.mtCandidate.TileImage = global::VotingSystem.Properties.Resources.lectern_speech;
            this.mtCandidate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtCandidate.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtCandidate.UseSelectable = true;
            this.mtCandidate.UseTileImage = true;
            this.mtCandidate.Click += new System.EventHandler(this.metroTile2_Click);
            // 
            // mtPin
            // 
            this.mtPin.ActiveControl = null;
            this.mtPin.Location = new System.Drawing.Point(535, 3);
            this.mtPin.Name = "mtPin";
            this.mtPin.Size = new System.Drawing.Size(130, 125);
            this.mtPin.TabIndex = 2;
            this.mtPin.Text = "Vote by PIN";
            this.mtPin.TileImage = global::VotingSystem.Properties.Resources.election_envelopes_and_box;
            this.mtPin.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPin.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtPin.UseSelectable = true;
            this.mtPin.UseTileImage = true;
            this.mtPin.Click += new System.EventHandler(this.mtPin_Click);
            // 
            // mtBiometric
            // 
            this.mtBiometric.ActiveControl = null;
            this.mtBiometric.Location = new System.Drawing.Point(3, 134);
            this.mtBiometric.Name = "mtBiometric";
            this.mtBiometric.Size = new System.Drawing.Size(130, 125);
            this.mtBiometric.TabIndex = 3;
            this.mtBiometric.Text = "Vote by Biometric";
            this.mtBiometric.TileImage = global::VotingSystem.Properties.Resources.fingerprint_with_crosshair_focus;
            this.mtBiometric.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBiometric.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtBiometric.UseSelectable = true;
            this.mtBiometric.UseTileImage = true;
            this.mtBiometric.Click += new System.EventHandler(this.metroTile4_Click);
            // 
            // mtPrivilege
            // 
            this.mtPrivilege.ActiveControl = null;
            this.mtPrivilege.Location = new System.Drawing.Point(139, 134);
            this.mtPrivilege.Name = "mtPrivilege";
            this.mtPrivilege.Size = new System.Drawing.Size(260, 125);
            this.mtPrivilege.TabIndex = 4;
            this.mtPrivilege.Text = "Set Privilege";
            this.mtPrivilege.TileImage = global::VotingSystem.Properties.Resources.open_lock;
            this.mtPrivilege.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtPrivilege.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtPrivilege.UseSelectable = true;
            this.mtPrivilege.UseTileImage = true;
            this.mtPrivilege.Click += new System.EventHandler(this.mtPrivilege_Click);
            // 
            // mtUser
            // 
            this.mtUser.ActiveControl = null;
            this.mtUser.Location = new System.Drawing.Point(405, 134);
            this.mtUser.Name = "mtUser";
            this.mtUser.Size = new System.Drawing.Size(260, 125);
            this.mtUser.TabIndex = 5;
            this.mtUser.Text = "Create New User";
            this.mtUser.TileImage = global::VotingSystem.Properties.Resources.command;
            this.mtUser.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtUser.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtUser.UseSelectable = true;
            this.mtUser.UseTileImage = true;
            this.mtUser.Click += new System.EventHandler(this.mtUser_Click);
            // 
            // mtStatistics
            // 
            this.mtStatistics.ActiveControl = null;
            this.mtStatistics.Location = new System.Drawing.Point(3, 265);
            this.mtStatistics.Name = "mtStatistics";
            this.mtStatistics.Size = new System.Drawing.Size(260, 125);
            this.mtStatistics.TabIndex = 6;
            this.mtStatistics.Text = "View Statistics";
            this.mtStatistics.TileImage = global::VotingSystem.Properties.Resources.bar_chart;
            this.mtStatistics.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtStatistics.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtStatistics.UseSelectable = true;
            this.mtStatistics.UseTileImage = true;
            this.mtStatistics.Click += new System.EventHandler(this.mtStatistics_Click);
            // 
            // mtSetDate
            // 
            this.mtSetDate.ActiveControl = null;
            this.mtSetDate.Location = new System.Drawing.Point(269, 265);
            this.mtSetDate.Name = "mtSetDate";
            this.mtSetDate.Size = new System.Drawing.Size(130, 125);
            this.mtSetDate.TabIndex = 7;
            this.mtSetDate.Text = "Set Election Date";
            this.mtSetDate.TileImage = global::VotingSystem.Properties.Resources.calendar;
            this.mtSetDate.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtSetDate.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtSetDate.UseSelectable = true;
            this.mtSetDate.UseTileImage = true;
            this.mtSetDate.Click += new System.EventHandler(this.mtSetDate_Click);
            // 
            // mtBackupDB
            // 
            this.mtBackupDB.ActiveControl = null;
            this.mtBackupDB.Location = new System.Drawing.Point(405, 265);
            this.mtBackupDB.Name = "mtBackupDB";
            this.mtBackupDB.Size = new System.Drawing.Size(260, 125);
            this.mtBackupDB.TabIndex = 8;
            this.mtBackupDB.Text = "DB BackUp";
            this.mtBackupDB.TileImage = global::VotingSystem.Properties.Resources.database;
            this.mtBackupDB.TileImageAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.mtBackupDB.TileTextFontSize = MetroFramework.MetroTileTextSize.Small;
            this.mtBackupDB.UseSelectable = true;
            this.mtBackupDB.UseTileImage = true;
            // 
            // PnlMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.metroPanel1);
            this.Name = "PnlMenu";
            this.Size = new System.Drawing.Size(1096, 530);
            this.Load += new System.EventHandler(this.PnlMenu_Load);
            this.metroPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile mtVoter;
        private MetroFramework.Controls.MetroTile mtCandidate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private MetroFramework.Controls.MetroTile mtPin;
        private MetroFramework.Controls.MetroTile mtBiometric;
        private MetroFramework.Controls.MetroTile mtPrivilege;
        private MetroFramework.Controls.MetroTile mtUser;
        private MetroFramework.Controls.MetroTile mtStatistics;
        private MetroFramework.Controls.MetroTile mtSetDate;
        private MetroFramework.Controls.MetroTile mtBackupDB;
        private MetroFramework.Controls.MetroPanel metroPanel1;
    }
}
