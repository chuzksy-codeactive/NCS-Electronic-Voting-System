using System;
using System.Drawing;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace VotingSystem
{
    public partial class FrmWebCam : MetroFramework.Forms.MetroForm
    {
        public FrmWebCam()
        {
            InitializeComponent();
        }

        private FilterInfoCollection _captureDevice;
        private VideoCaptureDevice _finalFrame;

        private void FrmWebCam_Load(object sender, System.EventArgs e)
        {
            _captureDevice = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo device in _captureDevice)
            {
                cmbDeviceName.Items.Add(device.Name);
            }
            cmbDeviceName.SelectedIndex = 0;
            _finalFrame = new VideoCaptureDevice();
        }

        private void btnStart_Click(object sender, System.EventArgs e)
        {
            try
            {
                if (_finalFrame.IsRunning) _finalFrame.Stop();
                _finalFrame = new VideoCaptureDevice(_captureDevice[cmbDeviceName.SelectedIndex].MonikerString);
                _finalFrame.NewFrame += FinalFrame_NewFrame;
                _finalFrame.Start();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            try
            {
                picVideo.Image = (Bitmap)eventArgs.Frame.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCaptureImage_Click(object sender, EventArgs e)
        {
            try
            {
                picCapture.Image = (Bitmap)picVideo.Image.Clone();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnSaveImage_Click(object sender, EventArgs e)
        {
            if (_finalFrame.IsRunning) _finalFrame.Stop();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void FrmWebCam_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_finalFrame.IsRunning) _finalFrame.Stop();
        }

        public Image ImgCapture
        {
            get { return picCapture.Image; }
        }
    }
}
