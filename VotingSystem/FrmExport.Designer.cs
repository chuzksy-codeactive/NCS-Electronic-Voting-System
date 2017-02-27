namespace VotingSystem
{
    partial class FrmExport
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
            this.mtListView = new MetroFramework.Controls.MetroListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lnkExport = new MetroFramework.Controls.MetroLink();
            this.metroLink1 = new MetroFramework.Controls.MetroLink();
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // mtListView
            // 
            this.mtListView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mtListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader9,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.mtListView.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.mtListView.FullRowSelect = true;
            this.mtListView.Location = new System.Drawing.Point(4, 63);
            this.mtListView.Name = "mtListView";
            this.mtListView.OwnerDraw = true;
            this.mtListView.Size = new System.Drawing.Size(1123, 474);
            this.mtListView.TabIndex = 0;
            this.mtListView.UseCompatibleStateImageBehavior = false;
            this.mtListView.UseSelectable = true;
            this.mtListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Candidate Pin";
            this.columnHeader1.Width = 110;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Firstname";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Lastname";
            this.columnHeader3.Width = 100;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Email";
            this.columnHeader4.Width = 120;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Voter\'s Pin";
            this.columnHeader5.Width = 100;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Gender";
            this.columnHeader6.Width = 80;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Voter\'s Phonenumber";
            this.columnHeader7.Width = 170;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Voter\'s Email";
            this.columnHeader8.Width = 150;
            // 
            // lnkExport
            // 
            this.lnkExport.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lnkExport.Image = global::VotingSystem.Properties.Resources.export__1_;
            this.lnkExport.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lnkExport.ImageSize = 32;
            this.lnkExport.Location = new System.Drawing.Point(1030, 11);
            this.lnkExport.Name = "lnkExport";
            this.lnkExport.NoFocusImage = global::VotingSystem.Properties.Resources.export__2_;
            this.lnkExport.Size = new System.Drawing.Size(49, 46);
            this.lnkExport.TabIndex = 1;
            this.lnkExport.Text = "&export";
            this.lnkExport.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.lnkExport.UseSelectable = true;
            this.lnkExport.Click += new System.EventHandler(this.lnkExport_Click);
            // 
            // metroLink1
            // 
            this.metroLink1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.metroLink1.Image = global::VotingSystem.Properties.Resources.cancel__1_;
            this.metroLink1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.metroLink1.ImageSize = 32;
            this.metroLink1.Location = new System.Drawing.Point(1085, 11);
            this.metroLink1.Name = "metroLink1";
            this.metroLink1.NoFocusImage = global::VotingSystem.Properties.Resources.cancel__2_;
            this.metroLink1.Size = new System.Drawing.Size(42, 46);
            this.metroLink1.TabIndex = 2;
            this.metroLink1.Text = "&close";
            this.metroLink1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.metroLink1.UseSelectable = true;
            this.metroLink1.Click += new System.EventHandler(this.metroLink1_Click);
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Position";
            this.columnHeader9.Width = 127;
            // 
            // FrmExport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1130, 560);
            this.ControlBox = false;
            this.Controls.Add(this.metroLink1);
            this.Controls.Add(this.lnkExport);
            this.Controls.Add(this.mtListView);
            this.Name = "FrmExport";
            this.Text = "Export Record to Excel";
            this.Load += new System.EventHandler(this.FrmExport_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroListView mtListView;
        private MetroFramework.Controls.MetroLink lnkExport;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private MetroFramework.Controls.MetroLink metroLink1;
        private System.Windows.Forms.ColumnHeader columnHeader9;
    }
}