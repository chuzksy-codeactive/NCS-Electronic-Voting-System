﻿namespace VotingSystem
{
    partial class FrmIndex
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
            this.mainMenu = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidateMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.votersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidatesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.castVoteMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.castVoteToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.createUserToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.privilegeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.setElectionDateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adminMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.reportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statisticsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.arrangeIconsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.msmIndex = new MetroFramework.Components.MetroStyleManager(this.components);
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.defaultToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blackToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.whiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.blueToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.greenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.redToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pinkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.purpleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.metroStyleExtender1 = new MetroFramework.Components.MetroStyleExtender(this.components);
            this.mainMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmIndex)).BeginInit();
            this.SuspendLayout();
            // 
            // mainMenu
            // 
            this.mainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.candidateMenu,
            this.castVoteMenu,
            this.reportMenu,
            this.adminMenu,
            this.windowMenu,
            this.helpMenu});
            this.mainMenu.Location = new System.Drawing.Point(20, 60);
            this.mainMenu.Margin = new System.Windows.Forms.Padding(3);
            this.mainMenu.MdiWindowListItem = this.windowMenu;
            this.mainMenu.Name = "mainMenu";
            this.mainMenu.Size = new System.Drawing.Size(967, 24);
            this.mainMenu.TabIndex = 1;
            this.mainMenu.Text = "menuStrip1";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.logoutToolStripMenuItem,
            this.closeToolStripMenuItem,
            this.closeAllToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // closeToolStripMenuItem
            // 
            this.closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            this.closeToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closeToolStripMenuItem.Text = "Close";
            this.closeToolStripMenuItem.Click += new System.EventHandler(this.closeToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.closeAllToolStripMenuItem.Text = "Close All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.closeAllToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // candidateMenu
            // 
            this.candidateMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.votersToolStripMenuItem,
            this.candidatesToolStripMenuItem});
            this.candidateMenu.Name = "candidateMenu";
            this.candidateMenu.Size = new System.Drawing.Size(82, 20);
            this.candidateMenu.Text = "&Registration";
            this.candidateMenu.Click += new System.EventHandler(this.candidateMenu_Click);
            // 
            // votersToolStripMenuItem
            // 
            this.votersToolStripMenuItem.Name = "votersToolStripMenuItem";
            this.votersToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.votersToolStripMenuItem.Text = "Voters";
            this.votersToolStripMenuItem.Click += new System.EventHandler(this.votersToolStripMenuItem_Click);
            // 
            // candidatesToolStripMenuItem
            // 
            this.candidatesToolStripMenuItem.Name = "candidatesToolStripMenuItem";
            this.candidatesToolStripMenuItem.Size = new System.Drawing.Size(133, 22);
            this.candidatesToolStripMenuItem.Text = "Candidates";
            this.candidatesToolStripMenuItem.Click += new System.EventHandler(this.candidatesToolStripMenuItem_Click);
            // 
            // castVoteMenu
            // 
            this.castVoteMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.castVoteToolStripMenuItem1});
            this.castVoteMenu.Name = "castVoteMenu";
            this.castVoteMenu.Size = new System.Drawing.Size(68, 20);
            this.castVoteMenu.Text = "&Cast Vote";
            // 
            // castVoteToolStripMenuItem1
            // 
            this.castVoteToolStripMenuItem1.Name = "castVoteToolStripMenuItem1";
            this.castVoteToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            this.castVoteToolStripMenuItem1.Text = "Cast Vote";
            this.castVoteToolStripMenuItem1.Click += new System.EventHandler(this.castVoteToolStripMenuItem1_Click);
            // 
            // reportMenu
            // 
            this.reportMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createUserToolStripMenuItem,
            this.privilegeToolStripMenuItem,
            this.setElectionDateToolStripMenuItem});
            this.reportMenu.Name = "reportMenu";
            this.reportMenu.Size = new System.Drawing.Size(55, 20);
            this.reportMenu.Text = "&Admin";
            // 
            // createUserToolStripMenuItem
            // 
            this.createUserToolStripMenuItem.Name = "createUserToolStripMenuItem";
            this.createUserToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.createUserToolStripMenuItem.Text = "Create User";
            this.createUserToolStripMenuItem.Click += new System.EventHandler(this.createUserToolStripMenuItem_Click);
            // 
            // privilegeToolStripMenuItem
            // 
            this.privilegeToolStripMenuItem.Name = "privilegeToolStripMenuItem";
            this.privilegeToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.privilegeToolStripMenuItem.Text = "Privilege";
            this.privilegeToolStripMenuItem.Click += new System.EventHandler(this.privilegeToolStripMenuItem_Click);
            // 
            // setElectionDateToolStripMenuItem
            // 
            this.setElectionDateToolStripMenuItem.Name = "setElectionDateToolStripMenuItem";
            this.setElectionDateToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.setElectionDateToolStripMenuItem.Text = "Set Election Date";
            this.setElectionDateToolStripMenuItem.Click += new System.EventHandler(this.setElectionDateToolStripMenuItem_Click);
            // 
            // adminMenu
            // 
            this.adminMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.reportToolStripMenuItem,
            this.statisticsToolStripMenuItem});
            this.adminMenu.Name = "adminMenu";
            this.adminMenu.Size = new System.Drawing.Size(44, 20);
            this.adminMenu.Text = "&View";
            // 
            // reportToolStripMenuItem
            // 
            this.reportToolStripMenuItem.Name = "reportToolStripMenuItem";
            this.reportToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.reportToolStripMenuItem.Text = "Report";
            // 
            // statisticsToolStripMenuItem
            // 
            this.statisticsToolStripMenuItem.Name = "statisticsToolStripMenuItem";
            this.statisticsToolStripMenuItem.Size = new System.Drawing.Size(120, 22);
            this.statisticsToolStripMenuItem.Text = "Statistics";
            this.statisticsToolStripMenuItem.Click += new System.EventHandler(this.statisticsToolStripMenuItem_Click);
            // 
            // windowMenu
            // 
            this.windowMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem3,
            this.toolStripMenuItem2,
            this.toolStripSeparator1,
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.arrangeIconsToolStripMenuItem,
            this.toolStripMenuItem1});
            this.windowMenu.Name = "windowMenu";
            this.windowMenu.Size = new System.Drawing.Size(63, 20);
            this.windowMenu.Text = "&Window";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.defaultToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem2.Text = "Themes";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(153, 6);
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.cascadeToolStripMenuItem.Text = "Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.cascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.tileVerticalToolStripMenuItem_Click);
            // 
            // arrangeIconsToolStripMenuItem
            // 
            this.arrangeIconsToolStripMenuItem.Name = "arrangeIconsToolStripMenuItem";
            this.arrangeIconsToolStripMenuItem.Size = new System.Drawing.Size(156, 22);
            this.arrangeIconsToolStripMenuItem.Text = "Arrange Icons";
            this.arrangeIconsToolStripMenuItem.Click += new System.EventHandler(this.arrangeIconsToolStripMenuItem_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(153, 6);
            // 
            // helpMenu
            // 
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // msmIndex
            // 
            this.msmIndex.Owner = this;
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blackToolStripMenuItem,
            this.whiteToolStripMenuItem,
            this.blueToolStripMenuItem,
            this.greenToolStripMenuItem,
            this.limeToolStripMenuItem,
            this.redToolStripMenuItem,
            this.pinkToolStripMenuItem,
            this.purpleToolStripMenuItem});
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(152, 22);
            this.toolStripMenuItem3.Text = "Style";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.lightToolStripMenuItem.Text = "Light";
            this.lightToolStripMenuItem.Click += new System.EventHandler(this.lightToolStripMenuItem_Click);
            // 
            // defaultToolStripMenuItem
            // 
            this.defaultToolStripMenuItem.Name = "defaultToolStripMenuItem";
            this.defaultToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.defaultToolStripMenuItem.Text = "Default";
            this.defaultToolStripMenuItem.Click += new System.EventHandler(this.defaultToolStripMenuItem_Click);
            // 
            // blackToolStripMenuItem
            // 
            this.blackToolStripMenuItem.Name = "blackToolStripMenuItem";
            this.blackToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blackToolStripMenuItem.Text = "Black";
            this.blackToolStripMenuItem.Click += new System.EventHandler(this.blackToolStripMenuItem_Click);
            // 
            // whiteToolStripMenuItem
            // 
            this.whiteToolStripMenuItem.Name = "whiteToolStripMenuItem";
            this.whiteToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.whiteToolStripMenuItem.Text = "White";
            this.whiteToolStripMenuItem.Click += new System.EventHandler(this.whiteToolStripMenuItem_Click);
            // 
            // blueToolStripMenuItem
            // 
            this.blueToolStripMenuItem.Name = "blueToolStripMenuItem";
            this.blueToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.blueToolStripMenuItem.Text = "Blue";
            this.blueToolStripMenuItem.Click += new System.EventHandler(this.blueToolStripMenuItem_Click);
            // 
            // greenToolStripMenuItem
            // 
            this.greenToolStripMenuItem.Name = "greenToolStripMenuItem";
            this.greenToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.greenToolStripMenuItem.Text = "Green";
            this.greenToolStripMenuItem.Click += new System.EventHandler(this.greenToolStripMenuItem_Click);
            // 
            // limeToolStripMenuItem
            // 
            this.limeToolStripMenuItem.Name = "limeToolStripMenuItem";
            this.limeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.limeToolStripMenuItem.Text = "Lime";
            this.limeToolStripMenuItem.Click += new System.EventHandler(this.limeToolStripMenuItem_Click);
            // 
            // redToolStripMenuItem
            // 
            this.redToolStripMenuItem.Name = "redToolStripMenuItem";
            this.redToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.redToolStripMenuItem.Text = "Red";
            this.redToolStripMenuItem.Click += new System.EventHandler(this.redToolStripMenuItem_Click);
            // 
            // pinkToolStripMenuItem
            // 
            this.pinkToolStripMenuItem.Name = "pinkToolStripMenuItem";
            this.pinkToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.pinkToolStripMenuItem.Text = "Pink";
            this.pinkToolStripMenuItem.Click += new System.EventHandler(this.pinkToolStripMenuItem_Click);
            // 
            // purpleToolStripMenuItem
            // 
            this.purpleToolStripMenuItem.Name = "purpleToolStripMenuItem";
            this.purpleToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.purpleToolStripMenuItem.Text = "Purple";
            this.purpleToolStripMenuItem.Click += new System.EventHandler(this.purpleToolStripMenuItem_Click);
            // 
            // FrmIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1007, 493);
            this.Controls.Add(this.mainMenu);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mainMenu;
            this.Name = "FrmIndex";
            this.Text = "Electronic Voting System";
            this.Theme = MetroFramework.MetroThemeStyle.Default;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmIndex_FormClosed);
            this.Load += new System.EventHandler(this.FrmIndex_Load);
            this.mainMenu.ResumeLayout(false);
            this.mainMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.msmIndex)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mainMenu;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidateMenu;
        private System.Windows.Forms.ToolStripMenuItem votersToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidatesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem castVoteMenu;
        private System.Windows.Forms.ToolStripMenuItem castVoteToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem reportMenu;
        private System.Windows.Forms.ToolStripMenuItem createUserToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem privilegeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem setElectionDateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adminMenu;
        private System.Windows.Forms.ToolStripMenuItem reportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statisticsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowMenu;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem arrangeIconsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        public MetroFramework.Components.MetroStyleManager msmIndex;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem defaultToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blackToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem whiteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem blueToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem greenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem redToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pinkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem purpleToolStripMenuItem;
        private MetroFramework.Components.MetroStyleExtender metroStyleExtender1;
    }
}