namespace VotingSystem
{
    partial class FrmWebCam
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
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.picVideo = new System.Windows.Forms.PictureBox();
            this.cmbDeviceName = new MetroFramework.Controls.MetroComboBox();
            this.btnStart = new MetroFramework.Controls.MetroButton();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.btnCaptureImage = new MetroFramework.Controls.MetroButton();
            this.btnSaveImage = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).BeginInit();
            this.metroPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // picCapture
            // 
            this.picCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCapture.Location = new System.Drawing.Point(141, 17);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(100, 107);
            this.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapture.TabIndex = 7;
            this.picCapture.TabStop = false;
            // 
            // picVideo
            // 
            this.picVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVideo.Location = new System.Drawing.Point(16, 17);
            this.picVideo.Name = "picVideo";
            this.picVideo.Size = new System.Drawing.Size(100, 107);
            this.picVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVideo.TabIndex = 6;
            this.picVideo.TabStop = false;
            // 
            // cmbDeviceName
            // 
            this.cmbDeviceName.FormattingEnabled = true;
            this.cmbDeviceName.ItemHeight = 23;
            this.cmbDeviceName.Location = new System.Drawing.Point(24, 64);
            this.cmbDeviceName.Name = "cmbDeviceName";
            this.cmbDeviceName.Size = new System.Drawing.Size(173, 29);
            this.cmbDeviceName.TabIndex = 3;
            this.cmbDeviceName.UseSelectable = true;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(203, 64);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(85, 29);
            this.btnStart.TabIndex = 4;
            this.btnStart.Text = "Start WebCam";
            this.btnStart.UseSelectable = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.Controls.Add(this.btnSaveImage);
            this.metroPanel1.Controls.Add(this.btnCaptureImage);
            this.metroPanel1.Controls.Add(this.picCapture);
            this.metroPanel1.Controls.Add(this.picVideo);
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(24, 106);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(264, 173);
            this.metroPanel1.TabIndex = 5;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // btnCaptureImage
            // 
            this.btnCaptureImage.Location = new System.Drawing.Point(16, 131);
            this.btnCaptureImage.Name = "btnCaptureImage";
            this.btnCaptureImage.Size = new System.Drawing.Size(100, 23);
            this.btnCaptureImage.TabIndex = 8;
            this.btnCaptureImage.Text = "Capture Image";
            this.btnCaptureImage.UseSelectable = true;
            this.btnCaptureImage.Click += new System.EventHandler(this.btnCaptureImage_Click);
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(141, 131);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(100, 23);
            this.btnSaveImage.TabIndex = 9;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseSelectable = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // FrmWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(316, 302);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbDeviceName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWebCam";
            this.Text = "WebCam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmWebCam_FormClosing);
            this.Load += new System.EventHandler(this.FrmWebCam_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).EndInit();
            this.metroPanel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.PictureBox picVideo;
        private MetroFramework.Controls.MetroComboBox cmbDeviceName;
        private MetroFramework.Controls.MetroButton btnStart;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroButton btnSaveImage;
        private MetroFramework.Controls.MetroButton btnCaptureImage;
    }
}