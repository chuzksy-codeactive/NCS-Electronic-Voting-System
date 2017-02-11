using System;
using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using MetroFramework;
using SecuGen.FDxSDKPro.Windows;
using Tulpep.NotificationWindow;
using VotingSystem.Models;
using VotingSystem.SMSLive247Api;

namespace VotingSystem
{
    public partial class FrmVotersRegistration : MetroFramework.Forms.MetroForm
    {
        private static readonly ErrorProvider errProvider = new ErrorProvider();
        private SGFingerPrintManager _mFpm;
        private bool _mLedOn = false;
        private Int32 _mImageWidth;
        private Int32 _mImageHeight;
        private Byte[] _mRegMin1;
        private Byte[] _mRegMin2;
        private Byte[] _mRegMin3;
        private SGFPMDeviceList[] _mDevList;

        private Error _error = new Error();
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        SqlTransaction _myTransaction = null;

        private string voterPin;
        private string voterId;
        public FrmVotersRegistration()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            EnablePanel(false);
            _mLedOn = false;
            _mFpm = new SGFingerPrintManager();
            EnumerateBtn_Click(sender, e);

            tbRegistration.SelectedTab = tbVoterInfo;
            var voterRegistration    = new VoterRegistration();
            voterPin = voterRegistration.GetVoterId();
        }

        private void btnWebcam_Click(object sender, EventArgs e)
        {
            var webCam = new FrmWebCam();
            var res = webCam.ShowDialog();
            if (res == DialogResult.OK)
            {
                picImage.Image = webCam.ImgCapture;
            }
        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() != System.Windows.Forms.DialogResult.Cancel)
                {
                    picImage.Image = Image.FromFile(openFileDialog1.FileName);
                    picImage.SizeMode = PictureBoxSizeMode.StretchImage;
                }
            }
            catch (Exception ex)
            {
                MetroMessageBox.Show(this,ex.Message, "Message");
            }
        }

        private void EnablePanel(bool enable)
        {
            pnlBiometric.Enabled = enable;
        }

        private void EnumerateBtn_Click(object sender, EventArgs e)
        {
            Int32 iError;
            string enumDevice;

            cmbDeviceName.Items.Clear();

            // Enumerate Device
            iError = _mFpm.EnumerateDevice();

            // Get enumeration info into SGFPMDeviceList
            _mDevList = new SGFPMDeviceList[_mFpm.NumberOfDevice];

            for (int i = 0; i < _mFpm.NumberOfDevice; i++)
            {
                _mDevList[i] = new SGFPMDeviceList();
                _mFpm.GetEnumDeviceInfo(i, _mDevList[i]);
                enumDevice = _mDevList[i].DevName.ToString() + " : " + _mDevList[i].DevID;
                cmbDeviceName.Items.Add(enumDevice);
            }

            if (cmbDeviceName.Items.Count > 0)
            {
                // Add Auto Selection
                enumDevice = "Auto Selection";
                cmbDeviceName.Items.Add(enumDevice);

                cmbDeviceName.SelectedIndex = 0; //First selected one
            }
            else
                statusBar.Text = @"No device found. Connect a device and click on the Enum button";

        }

        private void DrawImage(Byte[] imgData, PictureBox picBox)
        {
            int colorval;
            var bmp = new Bitmap(_mImageWidth, _mImageHeight);
            picBox.Image = (Image)bmp;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    colorval = (int)imgData[(j * _mImageWidth) + i];
                    bmp.SetPixel(i, j, Color.FromArgb(colorval, colorval, colorval));
                }
            }
            picBox.Refresh();
        }
        protected override void WndProc(ref Message message)
        {
            if (message.Msg == (int)SGFPMMessages.DEV_AUTOONEVENT)
            {
                if (message.WParam.ToInt32() == (int)SGFPMAutoOnEvent.FINGER_ON)
                    statusBar.Text = @"Device Message: Finger On";
                else
                    statusBar.Text = @"Device Message: Finger Off";
            }
            base.WndProc(ref message);
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            var error = new Error();
            if (_mFpm.NumberOfDevice == 0)
            {
                statusBar.Text = @"Please Plug Device And Then Click On Enumerate Device";
                return;
            }
            if (cmbDeviceName.SelectedIndex == -1) return;
            Int32 iError;
            SGFPMDeviceName deviceName;
            Int32 deviceId;

            Int32 numberOfDevices = cmbDeviceName.Items.Count;
            Int32 deviceSelected = cmbDeviceName.SelectedIndex;
            Boolean autoSelection = (deviceSelected == (numberOfDevices - 1));  // Last index

            if (autoSelection)
            {
                // Order of search: Hamster IV(HFDU04) -> Plus(HFDU03) -> III (HFDU02)
                deviceName = SGFPMDeviceName.DEV_AUTO;

                deviceId = (Int32)(SGFPMPortAddr.USB_AUTO_DETECT);
            }
            else
            {
                deviceName = _mDevList[deviceSelected].DevName;
                deviceId = _mDevList[deviceSelected].DevID;
            }

            iError = _mFpm.Init(deviceName);
            iError = _mFpm.OpenDevice(deviceId);

            iError = _mFpm.Init(deviceName);
            iError = _mFpm.OpenDevice(deviceId);
            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                SGFPMDeviceInfoParam pInfo = new SGFPMDeviceInfoParam();
                Int32 iError2 = _mFpm.GetDeviceInfo(pInfo);

                if (iError2 == (Int32)SGFPMError.ERROR_NONE)
                {
                    _mImageWidth = pInfo.ImageWidth;
                    _mImageHeight = pInfo.ImageHeight;
                }

                statusBar.Text = @"Device Initialization Success";
                EnablePanel(true);


            }
            else
                error.DisplayError("OpenDevice()", iError);
        }

        private void btnEnum_Click(object sender, EventArgs e)
        {
            Int32 iError;
            string enumDevice;

            cmbDeviceName.Items.Clear();

            // Enumerate Device
            iError = _mFpm.EnumerateDevice();

            // Get enumeration info into SGFPMDeviceList
            _mDevList = new SGFPMDeviceList[_mFpm.NumberOfDevice];

            for (int i = 0; i < _mFpm.NumberOfDevice; i++)
            {
                _mDevList[i] = new SGFPMDeviceList();
                _mFpm.GetEnumDeviceInfo(i, _mDevList[i]);
                enumDevice = _mDevList[i].DevName.ToString() + " : " + _mDevList[i].DevID;
                cmbDeviceName.Items.Add(enumDevice);
            }

            if (cmbDeviceName.Items.Count > 0)
            {
                // Add Auto Selection
                enumDevice = "Auto Selection";
                cmbDeviceName.Items.Add(enumDevice);

                cmbDeviceName.SelectedIndex = 0; //First selected one
                statusBar.Text = @"A device found, click on Init button to activate device";
            }
            else
                statusBar.Text = @"No device found. Connect a device and click on the Enum button";
        }

        private void btnCaptureR1_Click(object sender, EventArgs e)
        {
            Int32 iError;
            Byte[] fpImage;
            Int32 imgQlty;

            _mRegMin1 = new Byte[400];
            fpImage = new Byte[_mImageWidth * _mImageHeight];
            imgQlty = 0;


            iError = _mFpm.GetImage(fpImage);

            _mFpm.GetImageQuality(_mImageWidth, _mImageHeight, fpImage, ref imgQlty);
            pgbR1.Value = imgQlty;

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                DrawImage(fpImage, imgR1);
                iError = _mFpm.CreateTemplate(fpImage, _mRegMin1);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                    statusBar.Text = @"First image is captured";
                else
                    statusBar.Text = _error.DisplayError("CreateTemplate()", iError);
            }
            else
                statusBar.Text = _error.DisplayError("GetImage()", iError);
        }

        private void btnCaptureR2_Click(object sender, EventArgs e)
        {
            Int32 iError;
            Byte[] fpImage;
            Int32 imgQlty;

            _mRegMin2 = new Byte[400];
            fpImage = new Byte[_mImageWidth * _mImageHeight];
            imgQlty = 0;

            iError = _mFpm.GetImage(fpImage);

            _mFpm.GetImageQuality(_mImageWidth, _mImageHeight, fpImage, ref imgQlty);
            pgbR2.Value = imgQlty;

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                DrawImage(fpImage, imgR2);
                iError = _mFpm.CreateTemplate(fpImage, _mRegMin2);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                    statusBar.Text = @"Second image is captured";
                else
                    statusBar.Text = _error.DisplayError("CreateTemplate()", iError);
            }
            else
                statusBar.Text = _error.DisplayError("GetImage()", iError);
        }

        private void btnCaptureR3_Click(object sender, EventArgs e)
        {
            Int32 iError;
            Byte[] fpImage;
            Int32 imgQlty;

            _mRegMin3 = new Byte[400];
            fpImage = new Byte[_mImageWidth * _mImageHeight];
            imgQlty = 0;

            iError = _mFpm.GetImage(fpImage);

            _mFpm.GetImageQuality(_mImageWidth, _mImageHeight, fpImage, ref imgQlty);
            pgbR3.Value = imgQlty;

            if (iError == (Int32)SGFPMError.ERROR_NONE)
            {
                DrawImage(fpImage, imgR3);
                iError = _mFpm.CreateTemplate(fpImage, _mRegMin3);

                if (iError == (Int32)SGFPMError.ERROR_NONE)
                    statusBar.Text = @"Third image is captured";
                else
                    statusBar.Text = _error.DisplayError("CreateTemplate()", iError);
            }
            else
                statusBar.Text = _error.DisplayError("GetImage()", iError);
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            CheckVoter();
        }

        private bool CheckVoter()
        {
            Int32 iError;
            bool checkVoter = false;
            bool matched1 = false;
            bool matched2 = false;
            SGFPMSecurityLevel secuLevel;
            Int32 matchScore = 0;

            secuLevel = SGFPMSecurityLevel.BELOW_NORMAL;

            iError = _mFpm.MatchTemplate(_mRegMin1, _mRegMin3, secuLevel, ref matched1);
            iError = _mFpm.MatchTemplate(_mRegMin2, _mRegMin3, secuLevel, ref matched2);
            iError = _mFpm.GetMatchingScore(_mRegMin1, _mRegMin2, ref matchScore);

            if (imgR1.Image != null && imgR2.Image != null && imgR3.Image != null)
            {
                if (iError == (Int32)SGFPMError.ERROR_NONE)
                {
                    if (matched1 & matched2)
                    {
                        statusBar.Text = @"Verification Success, Matching Score: " + matchScore;
                        checkVoter =  true;
                    }
                    else
                    {
                        statusBar.Text = @"Verification Failed";
                    }
                }
                else
                    statusBar.Text = _error.DisplayError(@"MatchTemplate()", iError);
            }
            else
                MetroMessageBox.Show(this,@"Please load an image", @"Error Loading Image");
            return checkVoter;
        }
        private int Verify(Byte[] image1, Byte[] image2, Byte[] image3)
        {
            string select = "SELECT Id,m_Reg1, m_Reg2, m_Reg3 FROM VoterRegistration";
            using (_cmd = new SqlCommand(select, _cnn))
            {
                using (_dr = _cmd.ExecuteReader())
                {
                    Int32 iError;
                    bool matched1 = false;
                    bool matched2 = false;
                    bool matched3 = false;
                    var secuLevel = SGFPMSecurityLevel.NORMAL;
                    int id = -1;

                    while (_dr.Read())
                    {
                        matched1 = false;
                        matched2 = false;
                        matched3 = false;
                        iError = _mFpm.MatchTemplate((Byte[])_dr[1], image1, secuLevel, ref matched1);
                        iError = _mFpm.MatchTemplate((Byte[])_dr[2], image2, secuLevel, ref matched2);
                        iError = _mFpm.MatchTemplate((Byte[])_dr[3], image3, secuLevel, ref matched3);

                        if (iError == (Int32)SGFPMError.ERROR_NONE)
                        {
                            if (matched1 & matched2 & matched3)
                            {
                                id = int.Parse(_dr[0].ToString());
                                break;
                            }
                        }
                        else
                        {
                            statusBar.Text = _error.DisplayError("MatchTemplate()", iError);
                            break;
                        }
                    }
                    return id;
                }
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var popup = new PopupNotifier();
            popup.Image = Properties.Resources.email;
            popup.TitleText = "Email Notification";
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
                var r = MetroMessageBox.Show(this,@"Are you sure you want to SUBMIT?", @"eVoting System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            
                if (r == DialogResult.Yes)
                {
                    using (_cnn = new SqlConnection(Properties.Settings.Default.DbConn))
                    {
                        _cnn.Open();
                        if (CheckVoter())
                        {
                            var k = Verify(_mRegMin1, _mRegMin2, _mRegMin3);
                            if (k == -1)
                            {
                                using (_cmd = new SqlCommand("spAddVoter", _cnn))
                                {
                                    _cmd.CommandType = CommandType.StoredProcedure;
                                    _cmd.Parameters.AddWithValue("@voterPin", voterPin);
                                    _cmd.Parameters.AddWithValue("@firstName", txtFirstname.Text);
                                    _cmd.Parameters.AddWithValue("@lastName", txtLastname.Text);
                                    _cmd.Parameters.AddWithValue("@gender", cmbGender.Text);
                                    _cmd.Parameters.AddWithValue("@phoneNumber", txtPhoneNumber.Text);
                                    _cmd.Parameters.AddWithValue("@email", txtEmail.Text);
                                    _cmd.Parameters.AddWithValue("m_reg1", _mRegMin1);
                                    _cmd.Parameters.AddWithValue("m_reg2", _mRegMin2);
                                    _cmd.Parameters.AddWithValue("m_reg3", _mRegMin3);

                                    var outParameter = new SqlParameter();
                                    outParameter.ParameterName = "@voterId";
                                    outParameter.SqlDbType = SqlDbType.UniqueIdentifier;
                                    outParameter.Direction = ParameterDirection.Output;
                                    _cmd.Parameters.Add(outParameter);

                                    var ms = new MemoryStream();
                                    picImage.Image.Save(ms, ImageFormat.Bmp);
                                    byte[] data = ms.ToArray();
                                    _cmd.Parameters.AddWithValue("@pic", data);

                                    try
                                    {
                                        _cmd.ExecuteNonQuery();
                                        voterId = outParameter.Value.ToString();
                                        var body =
                                            string.Format(
                                                "Hi, you are registered successfully. " + Environment.NewLine +
                                                "Your Security Key is {0}. Your Voter ID is {1}", voterId, voterPin);
                                        var emailReply = SendNotifications.SendEmail(txtEmail.Text, body);
                                        if (emailReply != null) popup.ContentText = emailReply;
                                        MetroMessageBox.Show(this,@"Data Submitted Successfully!", @"eVoting System",
                                            MessageBoxButtons.OK,
                                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                        ClearAll();
                                        popup.Popup();
                                    }
                                    catch (SqlException ex)
                                    {
                                        MetroMessageBox.Show(this,@"Data unable to save due to " + ex.Message);
                                    }
                                }
                            }
                            else
                            {
                                MetroMessageBox.Show(this,@"You have registered before", @"eVoting System", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                                _mFpm.EnableAutoOnEvent(false, 0);
                            }
                        }
                        else
                        {
                            MetroMessageBox.Show(this,@"Fingerprint does no match", @"eVoting System", MessageBoxButtons.OK,
                                    MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        }
                    }
                }
            }
            
        }

        private void ClearAll()
        {
            txtFirstname.Clear();
            txtLastname.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            txtSearch.Clear();
            cmbGender.SelectedIndex = -1;
            picImage.Image = null;
            imgR1.Image = null;
            imgR2.Image = null;
            imgR3.Image = null;
            pgbR1.Value = 0;
            pgbR2.Value = 0;
            pgbR3.Value = 0;
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
             var rEMail = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (!string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                if (!rEMail.IsMatch(txtEmail.Text))
                {
                    errProvider.SetError(txtEmail, @"Wrong email format");
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    errProvider.SetError(txtEmail, "");
                }
            }
            else
            {
                e.Cancel = true;
                errProvider.SetError(txtEmail, "Email address is required");
            }
        }

        private void txtFirstname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                errProvider.SetError(txtFirstname, "");
                e.Handled = false;
            }
            else
            {
                MetroMessageBox.Show(this, @"Invalid Input, Characters only", @"Wrong Input Data");
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var matchPhoneNumberPattern = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{4})[-. ]?([0-9]{4})$");
            if (!string.IsNullOrWhiteSpace(txtPhoneNumber.Text))
            {
                if (!matchPhoneNumberPattern.IsMatch(txtPhoneNumber.Text))
                {
                    errProvider.SetError(txtPhoneNumber, @"Wrong phone number format");
                    e.Cancel = true;
                }
                else
                {
                    e.Cancel = false;
                    errProvider.SetError(txtPhoneNumber, "");
                }
            }
            else
            {
                e.Cancel = true;
                errProvider.SetError(txtPhoneNumber, "Phone number is required");
            }
        }

        private bool IsValidateData()
        {
            if (Validators.IsPresent(txtFirstname) &&
                Validators.IsPresent(txtLastname) &&
                Validators.IsPresent(cmbGender) &&
                Validators.IsPresent(txtEmail) &&
                Validators.IsPresent(txtPhoneNumber) &&
                Validators.IsImagePresent(picImage) &&
                Validators.IsImagePresent(imgR1) &&
                Validators.IsImagePresent(imgR2) &&
                Validators.IsImagePresent(imgR3))
            {
                return true;
            }
            else
                return false;
        }

        private bool IsValidateData2()
        {
            if (Validators.IsPresent(txtFirstname) &&
                Validators.IsPresent(txtLastname) &&
                Validators.IsPresent(cmbGender) &&
                Validators.IsPresent(txtEmail) &&
                Validators.IsPresent(txtPhoneNumber) &&
                Validators.IsImagePresent(picImage))
            {
                return true;
            }
            else
                return false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var voter = new Voters();
            var updateVoter = new VoterRegistration();

            if (IsValidateData2())
            {
                voter.Firstname = txtFirstname.Text.Trim().ToUpper();
                voter.Lastname = txtLastname.Text.Trim().ToUpper();
                voter.Gender = cmbGender.Text;
                voter.Email = txtEmail.Text.Trim();
                voter.Phonenumber = txtPhoneNumber.Text.Trim();
                voter.VoterImg = picImage.Image;

                var r = MetroMessageBox.Show(this,@"Are you sure you want to UPDATE this record?", @"eVoting System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                if (r == DialogResult.Yes)
                {
                    var rowAffected = updateVoter.UpdateVoter(voter, voterPin);
                    if (rowAffected == -1)
                    {
                        MetroMessageBox.Show(this,@"Record not updated successful", @"Voting System", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                    else if (rowAffected == 1)
                    {
                        MetroMessageBox.Show(this,@"Record has been updated successful", @"Voting System", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearAll();
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        btnSubmit.Enabled = true;
                        panel2.Enabled = true;
                    }
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var voter = new Voters();
            string msg = "";
            var searchVoter = new VoterRegistration();
            voter = searchVoter.SearchVoters(txtSearch.Text, out msg);
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                if (!string.IsNullOrWhiteSpace(msg))
                {
                    MetroMessageBox.Show(this,msg, @"Voting System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //btnDelete.Enabled = false;
                }
                else
                {
                    txtFirstname.Text = voter.Firstname;
                    txtLastname.Text = voter.Lastname;
                    cmbGender.SelectedIndex = voter.Gender == "Male" ? 0 : 1;
                    txtEmail.Text = voter.Email;
                    txtPhoneNumber.Text = voter.Phonenumber;
                    picImage.Image = voter.VoterImg;
                    voterPin = voter.VoterPin;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnSubmit.Enabled = false;
                    panel2.Enabled = false;
                }
            }
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAll();
            panel2.Enabled = true;
            btnSubmit.Enabled = true;
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = MetroMessageBox.Show(this,@"Are you sure you want to DELETE this record?", @"eVoting System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

            if (r == DialogResult.Yes)
            {
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    var voterPin = new VoterRegistration();
                    var rowAffected = voterPin.DeleteVoter(txtSearch.Text);
                    if (rowAffected == 1)
                    {
                        MetroMessageBox.Show(this,@"Record DELETED successfully", @"Electronic Voting System",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearAll();
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        btnSubmit.Enabled = true;
                        panel2.Enabled = true;
                    }
                    else if (rowAffected == -1)
                    {
                        MetroMessageBox.Show(this,@"Record NOT found", @"Electronic Voting System", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            
        }

        private void txtFirstname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFirstname.Text))
            {
                errProvider.SetError(txtFirstname, "Firsname should not be left blank");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtFirstname, null);
            }
                
        }

        private void txtLastname_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtLastname.Text))
            {
                errProvider.SetError(txtLastname, "Lastname should not be left blank");
                e.Cancel = true;
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(txtLastname, null);
            }
               
        }

        private void cmbGender_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (cmbGender.SelectedIndex == -1)
            {
                e.Cancel = true;
                cmbGender.Focus();
                errProvider.SetError(cmbGender, "Select a gender");
            }
            else
            {
                e.Cancel = false;
                errProvider.SetError(cmbGender, "");
            }
        }

        private void txtLastname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 65 && e.KeyChar <= 90) || (e.KeyChar >= 97 && e.KeyChar <= 122) || e.KeyChar == 32 || e.KeyChar == 8)
            {
                errProvider.SetError(txtLastname, "");
                e.Handled = false;
            }
            else
            {
                MetroMessageBox.Show(this, @"Invalid Input, Characters only", @"Wrong Input Data");
                e.Handled = true;
            }
        }

        private void cmbGender_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGender.SelectedIndex == -1)
            {
                cmbGender.Focus();
                errProvider.SetError(cmbGender, "Select a gender");
            }
            else
            {
                errProvider.SetError(cmbGender, "");
            }
        }

        private void txtEmail_KeyPress(object sender, KeyPressEventArgs e)
        {
           
            errProvider.SetError(txtEmail, "");
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            errProvider.SetError(txtPhoneNumber, "");
        }
    }
}
