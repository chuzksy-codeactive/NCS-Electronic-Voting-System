namespace VotingSystem
{
    partial class FrmTheme
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
            this.metroTileSytle = new MetroFramework.Controls.MetroTile();
            this.metroTileSwitch = new MetroFramework.Controls.MetroTile();
            this.SuspendLayout();
            // 
            // metroTileSytle
            // 
            this.metroTileSytle.ActiveControl = null;
            this.metroTileSytle.Location = new System.Drawing.Point(23, 88);
            this.metroTileSytle.Name = "metroTileSytle";
            this.metroTileSytle.Size = new System.Drawing.Size(147, 68);
            this.metroTileSytle.TabIndex = 0;
            this.metroTileSytle.Text = "Switch Style";
            this.metroTileSytle.UseSelectable = true;
            this.metroTileSytle.Click += new System.EventHandler(this.metroTileSytle_Click);
            // 
            // metroTileSwitch
            // 
            this.metroTileSwitch.ActiveControl = null;
            this.metroTileSwitch.Location = new System.Drawing.Point(24, 163);
            this.metroTileSwitch.Name = "metroTileSwitch";
            this.metroTileSwitch.Size = new System.Drawing.Size(147, 68);
            this.metroTileSwitch.TabIndex = 1;
            this.metroTileSwitch.Text = "Switch Theme";
            this.metroTileSwitch.UseSelectable = true;
            this.metroTileSwitch.Click += new System.EventHandler(this.metroTileSwitch_Click);
            // 
            // FrmTheme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.metroTileSwitch);
            this.Controls.Add(this.metroTileSytle);
            this.Name = "FrmTheme";
            this.Text = "Theme Settings";
            this.Load += new System.EventHandler(this.FrmTheme_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private MetroFramework.Controls.MetroTile metroTileSytle;
        private MetroFramework.Controls.MetroTile metroTileSwitch;
    }
}