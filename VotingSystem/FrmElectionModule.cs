using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Controls;
using SecuGen.FDxSDKPro.Windows;
using VotingSystem.Models;
using VotingSystem.Properties;

namespace VotingSystem
{
    public partial class FrmElectionModule : MetroFramework.Forms.MetroForm
    {
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;

        private readonly List<Election> _electionList = new List<Election>();
        private List<Candidate> candidates = new List<Candidate>(); 
        private List<string> links = new List<string>(4);
        private string candidatePin;

        private Error _error = new Error();
        private SGFingerPrintManager _mFpm;
        private bool _mLedOn = false;
        private Int32 _mImageWidth;
        private Int32 _mImageHeight;
        private Byte[] _mRegMin1;
        private Byte[] _mRegMin2;
        private Byte[] _mRegMin3;
        private SGFPMDeviceList[] _mDevList;

        public FrmElectionModule()
        {
            InitializeComponent();
        }

        private void DrawImage(Byte[] imgData, PictureBox picBox)
        {
            int colorval;
            var bmp = new Bitmap(_mImageWidth, _mImageHeight);
            picBox.Image = (Image) bmp;

            for (int i = 0; i < bmp.Width; i++)
            {
                for (int j = 0; j < bmp.Height; j++)
                {
                    colorval = (int) imgData[(j*_mImageWidth) + i];
                    bmp.SetPixel(i, j, Color.FromArgb(colorval, colorval, colorval));
                }
            }
            picBox.Refresh();
        }

        protected override void WndProc(ref Message message)
        {
            if (message.Msg == (int) SGFPMMessages.DEV_AUTOONEVENT)
            {
                if (message.WParam.ToInt32() == (int) SGFPMAutoOnEvent.FINGER_ON)
                {
                    Status.Text = @" Device Message: Finger On";
                    btnScan_Click(null, null);
                }

                else
                    Status.Text = @" Device Message: Finger Off";
            }
            base.WndProc(ref message);
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
                Status.Text = @"A device found, click on Init button to activate device";
            }
            else
                Status.Text = @"No device found. Connect a device and click on the Enum button";
        }

        private void btnInit_Click(object sender, EventArgs e)
        {
            var error = new Error();
            if (_mFpm.NumberOfDevice == 0)
            {
                Status.Text = @"Please Plug Device And Then Click On Enumerate Device";
                return;
            }
            if (cmbDeviceName.SelectedIndex == -1) return;
            Int32 iError;
            SGFPMDeviceName deviceName;
            Int32 deviceId;

            Int32 numberOfDevices = cmbDeviceName.Items.Count;
            Int32 deviceSelected = cmbDeviceName.SelectedIndex;
            Boolean autoSelection = (deviceSelected == (numberOfDevices - 1)); // Last index

            if (autoSelection)
            {
                // Order of search: Hamster IV(HFDU04) -> Plus(HFDU03) -> III (HFDU02)
                deviceName = SGFPMDeviceName.DEV_AUTO;

                deviceId = (Int32) (SGFPMPortAddr.USB_AUTO_DETECT);
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
            if (iError == (Int32) SGFPMError.ERROR_NONE)
            {
                SGFPMDeviceInfoParam pInfo = new SGFPMDeviceInfoParam();
                Int32 iError2 = _mFpm.GetDeviceInfo(pInfo);

                if (iError2 == (Int32) SGFPMError.ERROR_NONE)
                {
                    _mImageWidth = pInfo.ImageWidth;
                    _mImageHeight = pInfo.ImageHeight;
                }
                Status.Text = @"Device Initialization Success";
                //GetBtn_Click(sender, e);
            }
            else
                error.DisplayError("OpenDevice()", iError);
            panel2.Enabled = true;
        }

        private void CheckBoxAutoOn_CheckedChanged(object sender, EventArgs e)
        {
            if (CheckBoxAutoOn.Checked)
                _mFpm.EnableAutoOnEvent(true, (int) this.Handle);
            else
                _mFpm.EnableAutoOnEvent(false, 0);
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
                Status.Text = @"No device found. Connect a device and click on the Enum button";

        }

        private void FrmElectionModule_Load(object sender, EventArgs e)
        {
            _mLedOn = false;

            _mRegMin1 = new Byte[400];
            _mRegMin2 = new Byte[400];

            _mFpm = new SGFingerPrintManager();
            EnumerateBtn_Click(sender, e);

            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand("Select ElectionId, ElectionPost, NoOfCandidates From AddNewElection", _cnn))
                {
                    using (_dr = _cmd.ExecuteReader())
                    {
                        while (_dr.Read())
                        {
                            cmbElectionId.Items.Add(_dr["ElectionPost"].ToString());
                            _electionList.Add(new Election()
                            {
                                ElectionId = _dr["ElectionId"].ToString(),
                                Post = _dr["ElectionPost"].ToString(),
                                NoOfCandidates = (int)_dr["NoOfCandidates"]
                            });
                        }
                    }
                }
            }
        }

        private Voters Verify(byte[] image1, byte[] image2, byte[] image3)
        {
            var voters = new Voters();
            const string select =
                "Select VoterPin, Firstname, Lastname, picImage, m_Reg1, m_Reg2, m_Reg3 From VoterRegistration";
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand(select, _cnn))
                {
                    using (_dr = _cmd.ExecuteReader())
                    {
                        var secuLevel = SGFPMSecurityLevel.NORMAL;
                        while (_dr.Read())
                        {
                            var matched1 = false;
                            var matched2 = false;
                            var matched3 = false;
                            var iError = _mFpm.MatchTemplate((Byte[]) _dr[4], image1, secuLevel, ref matched1);
                            iError = _mFpm.MatchTemplate((Byte[]) _dr[5], image2, secuLevel, ref matched2);
                            iError = _mFpm.MatchTemplate((Byte[]) _dr[6], image3, secuLevel, ref matched3);

                            if (iError == (Int32) SGFPMError.ERROR_NONE)
                            {
                                if (matched1 & matched2 & matched3)
                                {
                                    voters.VoterPin = _dr["VoterPin"].ToString();
                                    voters.Firstname = _dr["Firstname"].ToString();
                                    voters.Lastname = _dr["Lastname"].ToString();
                                    var data = (byte[]) _dr["picImage"];
                                    var ms = new MemoryStream(data);
                                    voters.VoterImg = Image.FromStream(ms);
                                    break;
                                }
                            }
                            else
                            {
                                Status.Text = _error.DisplayError(" MatchTemplate()", iError);
                                break;
                            }
                        }
                    }
                    return voters;
                }
            }
        }

        private void btnScan_Click(object sender, EventArgs e)
        {
            Status.Text = "";
            Int32 iError;
            Byte[] fp_image;
            Int32 img_qlty;

            fp_image = new Byte[_mImageWidth*_mImageHeight];
            img_qlty = 0;

            iError = _mFpm.GetImage(fp_image);

            _mFpm.GetImageQuality(_mImageWidth, _mImageHeight, fp_image, ref img_qlty);

            if (iError == (int) SGFPMError.ERROR_NONE)
            {
                DrawImage(fp_image, pictureBox1);
                iError = _mFpm.CreateTemplate(fp_image, _mRegMin1);
                if (iError == (int) SGFPMError.ERROR_NONE)
                {
                    var voters = Verify(_mRegMin1, _mRegMin1, _mRegMin1);
                    if (voters.VoterPin != null)
                    {
                        lblName.Text = voters.Firstname + @" " + voters.Lastname;
                        lblVoterPin.Text = voters.VoterPin;
                        picImage.Image = voters.VoterImg;
                        radioButton4.Checked = false;
                        radioButton3.Checked = false;
                        radioButton2.Checked = false;
                        radioButton1.Checked = false;
                        btnCastVote.Enabled = false;
                        metroPanel3.Visible = true;
                    }
                    else
                        MetroMessageBox.Show(this,@"Your record not found in the database", @"eVoting System",
                            MessageBoxButtons.OK, MessageBoxIcon.Stop);
                }
                else
                    Status.Text = _error.DisplayError("CreateTemplate()", iError);
            }
            else
                Status.Text = _error.DisplayError("CreateTemplate()", iError);
        }

        private void cmbElectionId_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var noOfCandidates =
            //    _electionList.Where(x => x.Post == cmbElectionId.Text).Select(x => x.NoOfCandidates).First();
            var loadElection = LoadElection.ElectionList();
            var selectedCandidates = loadElection.Where(x => x.Post == cmbElectionId.Text).ToList();
            candidates = selectedCandidates;
            var countCnd = selectedCandidates.Count;
            var metroLinks = new List<MetroLink> {linkLabel4, linkLabel3, linkLabel2, linkLabel1};
            #region LotsOfLogic

            if (countCnd == 0)
            {
                radioButton1.Visible = false;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton4.Visible = false;
                linkLabel4.Visible = false;
                linkLabel3.Visible = false;
                linkLabel2.Visible = false;
                linkLabel1.Visible = false;

            }
            else if (countCnd == 1)
            {
                int counter = 0;
                foreach (var radio in from object control in metroPanel.Controls select control as MetroRadioButton)
                {
                    if (radio != null)
                    {
                        radio.Text = selectedCandidates[counter].Fullname;
                        metroLinks[counter].Text = selectedCandidates[counter].CandidatePin;
                        counter++;
                    }
                    if (counter != countCnd) continue;
                    break;
                }
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                radioButton1.Visible = false;
                radioButton4.Visible = true;
                linkLabel3.Visible = false;
                linkLabel2.Visible = false;
                linkLabel1.Visible = false;
                linkLabel4.Visible = true;

            }
            else if (countCnd == 2)
            {
                int counter = 0;
                foreach (var radio in from object control in metroPanel.Controls select control as MetroRadioButton)
                {
                    if (radio != null)
                    {
                        radio.Text = selectedCandidates[counter].Fullname;
                        metroLinks[counter].Text = selectedCandidates[counter].CandidatePin;
                        counter++;
                    }
                    if (counter != countCnd) continue;
                    break;
                }
                radioButton1.Visible = true;
                radioButton4.Visible = true;
                radioButton2.Visible = false;
                radioButton3.Visible = false;
                linkLabel2.Visible = false;
                linkLabel1.Visible = false;
                linkLabel4.Visible = true;
                linkLabel3.Visible = true;
            }
            else if (countCnd == 3)
            {
                int counter = 0;
                foreach (var control in metroPanel.Controls)
                {
                    var radio = control as MetroRadioButton;
                    if (radio != null)
                    {
                        radio.Text = selectedCandidates[counter].Fullname;
                        metroLinks[counter].Text = selectedCandidates[counter].CandidatePin;
                        counter++;
                    }
                    if (counter != countCnd) continue;
                    break;
                }
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton4.Visible = true;
                radioButton3.Visible = false;
                linkLabel1.Visible = false;
                linkLabel2.Visible = true;
                linkLabel3.Visible = true;
                linkLabel4.Visible = true;
            }
            else if (countCnd == 4)
            {
                int counter = 0;
                foreach (var radio in from object control in metroPanel.Controls select control as MetroRadioButton)
                {
                    if (radio != null)
                    {
                        radio.Text = selectedCandidates[counter].Fullname;
                        metroLinks[counter].Text = selectedCandidates[counter].CandidatePin;
                        counter++;
                    }
                    if (counter != countCnd) continue;
                    break;
                }
                radioButton1.Visible = true;
                radioButton2.Visible = true;
                radioButton4.Visible = true;
                radioButton3.Visible = true;
                linkLabel1.Visible = true;
                linkLabel2.Visible = true;
                linkLabel3.Visible = true;
                linkLabel4.Visible = true;
            }

            #endregion

            #region CodeNeedToChange

            //switch (noOfCandidates)
            //{
            //    case 2:
            //        radioButton3.Visible = false;
            //        radioButton4.Visible = false;
            //        linkLabel3.Visible = false;
            //        linkLabel4.Visible = false;
            //        break;
            //    case 3:
            //        radioButton4.Visible = false;
            //        linkLabel4.Visible = false;
            //        radioButton3.Visible = true;
            //        linkLabel3.Visible = true;
            //        break;
            //}
            //if (selectedCandidates.Count == 2)
            //{
            //    radios[0].Text = selectedCandidates[0].Fullname;
            //    radios[1].Text = selectedCandidates[1].Fullname;
            //}
            //else if (selectedCandidates.Count == 3)
            //{
            //    radios[0].Text = selectedCandidates[0].Fullname;
            //    radios[1].Text = selectedCandidates[1].Fullname;
            //    radios[2].Text = selectedCandidates[2].Fullname;
            //}
            //else if (selectedCandidates.Count == 4)
            //{
            //    radios[0].Text = selectedCandidates[0].Fullname;
            //    radios[1].Text = selectedCandidates[1].Fullname;
            //    radios[2].Text = selectedCandidates[2].Fullname;
            //    radios[3].Text = selectedCandidates[3].Fullname;
            //}

            #endregion

            metroPanel.Visible = true;
            radioButton4.Checked = false;
            radioButton3.Checked = false;
            radioButton2.Checked = false;
            radioButton1.Checked = false;
            btnCastVote.Enabled = false;
        }
        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked || radioButton3.Checked || radioButton2.Checked || radioButton1.Checked)
            {
                btnCastVote.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnCastVote_Click(object sender, EventArgs e)
        {
            var check = VoterProcess.CheckIfVoted(lblVoterPin.Text, cmbElectionId.Text);
            if (check)
            {
                if (radioButton4.Checked)
                {
                    var saveVote = VoterProcess.SaveVote(lblVoterPin.Text, linkLabel1.Text, cmbElectionId.Text, 1);
                    if (saveVote > 0)
                    {
                        MetroMessageBox.Show(this,@"You have voted successfully", @"eVoting System", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }else if(radioButton3.Checked)
                {
                    var saveVote = VoterProcess.SaveVote(lblVoterPin.Text, linkLabel2.Text, cmbElectionId.Text, 1);
                    if (saveVote > 0)
                    {
                        MetroMessageBox.Show(this,@"You have voted successfully", @"eVoting System", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else if (radioButton2.Checked)
                {
                    var saveVote = VoterProcess.SaveVote(lblVoterPin.Text, linkLabel3.Text, cmbElectionId.Text, 1);
                    if (saveVote > 0)
                    {
                        MetroMessageBox.Show(this,@"You have voted successfully", @"eVoting System", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
                else if (radioButton1.Checked)
                {
                    var saveVote = VoterProcess.SaveVote(lblVoterPin.Text, linkLabel4.Text, cmbElectionId.Text, 1);
                    if (saveVote > 0)
                    {
                        MetroMessageBox.Show(this,@"You have voted successfully", @"eVoting System", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this,@"Sorry! You can only vote for this Position once ", @"eVoting System",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void linkLabel4_Click(object sender, EventArgs e)
        {
            FrmCandidateProfile.Candidates = candidates.Where(x => x.CandidatePin == linkLabel4.Text).ToList();
            var showForm = new FrmCandidateProfile();
            showForm.ShowDialog();
        }

        private void linkLabel3_Click(object sender, EventArgs e)
        {
            FrmCandidateProfile.Candidates = candidates.Where(x => x.CandidatePin == linkLabel3.Text).ToList();
            var showForm = new FrmCandidateProfile();
            showForm.ShowDialog();
        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            FrmCandidateProfile.Candidates = candidates.Where(x => x.CandidatePin == linkLabel2.Text).ToList();
            var showForm = new FrmCandidateProfile();
            showForm.ShowDialog();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            FrmCandidateProfile.Candidates = candidates.Where(x => x.CandidatePin == linkLabel1.Text).ToList();
            var showForm = new FrmCandidateProfile();
            showForm.ShowDialog();
        }
    }
    
}
