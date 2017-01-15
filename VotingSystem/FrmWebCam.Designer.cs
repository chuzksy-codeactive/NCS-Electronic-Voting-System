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
            this.cmbDeviceName = new System.Windows.Forms.ComboBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSaveImage = new System.Windows.Forms.Button();
            this.btnCaptureImage = new System.Windows.Forms.Button();
            this.picCapture = new System.Windows.Forms.PictureBox();
            this.picVideo = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbDeviceName
            // 
            this.cmbDeviceName.FormattingEnabled = true;
            this.cmbDeviceName.Location = new System.Drawing.Point(13, 24);
            this.cmbDeviceName.Name = "cmbDeviceName";
            this.cmbDeviceName.Size = new System.Drawing.Size(153, 21);
            this.cmbDeviceName.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(172, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSaveImage);
            this.panel1.Controls.Add(this.btnCaptureImage);
            this.panel1.Controls.Add(this.picCapture);
            this.panel1.Controls.Add(this.picVideo);
            this.panel1.Location = new System.Drawing.Point(13, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 155);
            this.panel1.TabIndex = 2;
            // 
            // btnSaveImage
            // 
            this.btnSaveImage.Location = new System.Drawing.Point(121, 120);
            this.btnSaveImage.Name = "btnSaveImage";
            this.btnSaveImage.Size = new System.Drawing.Size(100, 23);
            this.btnSaveImage.TabIndex = 9;
            this.btnSaveImage.Text = "Save Image";
            this.btnSaveImage.UseVisualStyleBackColor = true;
            this.btnSaveImage.Click += new System.EventHandler(this.btnSaveImage_Click);
            // 
            // btnCaptureImage
            // 
            this.btnCaptureImage.Location = new System.Drawing.Point(11, 120);
            this.btnCaptureImage.Name = "btnCaptureImage";
            this.btnCaptureImage.Size = new System.Drawing.Size(100, 23);
            this.btnCaptureImage.TabIndex = 8;
            this.btnCaptureImage.Text = "Capture Image";
            this.btnCaptureImage.UseVisualStyleBackColor = true;
            this.btnCaptureImage.Click += new System.EventHandler(this.btnCaptureImage_Click);
            // 
            // picCapture
            // 
            this.picCapture.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picCapture.Location = new System.Drawing.Point(121, 7);
            this.picCapture.Name = "picCapture";
            this.picCapture.Size = new System.Drawing.Size(100, 107);
            this.picCapture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picCapture.TabIndex = 7;
            this.picCapture.TabStop = false;
            // 
            // picVideo
            // 
            this.picVideo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.picVideo.Location = new System.Drawing.Point(11, 7);
            this.picVideo.Name = "picVideo";
            this.picVideo.Size = new System.Drawing.Size(100, 107);
            this.picVideo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picVideo.TabIndex = 6;
            this.picVideo.TabStop = false;
            // 
            // FrmWebCam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 233);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.cmbDeviceName);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmWebCam";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WebCam";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmWebCam_FormClosing);
            this.Load += new System.EventHandler(this.FrmWebCam_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picCapture)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picVideo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbDeviceName;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSaveImage;
        private System.Windows.Forms.Button btnCaptureImage;
        private System.Windows.Forms.PictureBox picCapture;
        private System.Windows.Forms.PictureBox picVideo;
    }
}