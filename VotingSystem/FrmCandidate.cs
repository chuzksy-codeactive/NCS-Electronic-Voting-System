using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using VotingSystem.Models;
using VotingSystem.Properties;

namespace VotingSystem
{
    public partial class FrmCandidate : Form
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        private static readonly ErrorProvider errProvider = new ErrorProvider();

        public static string CandidatePin { get; set; }
        public static string CandidateId { get; set; }
        public static int NoOfCandidates { get; set; }

        public FrmCandidate()
        {
            InitializeComponent();
            var candidate = new CandidateRegistration();
            CandidatePin = candidate.GetCandidatePin();
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearAll();
        }

        private void ClearAll()
        {
            txtSearch.Clear();
            txtFirstname.Clear();
            txtLastname.Clear();
            txtEmail.Clear();
            txtPhoneNumber.Clear();
            cmbGender.SelectedIndex = 0;
            picImage.Image = null;
            cmbPost.SelectedIndex = 0;
            txtManifesto.Clear();
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
                MessageBox.Show(ex.Message);
            }
        }

        private void FrmCandidate_Load(object sender, EventArgs e)
        {
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("Select ElectionPost From AddNewElection", cnn))
                {
                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cmbPost.Items.Add(dr["ElectionPost"].ToString());
                        }
                    }
                }
            }
            GroupListView();
        }

        private bool IsValidateData()
        {
            if (Validators.IsPresent(txtFirstname) &&
                Validators.IsPresent(txtLastname) &&
                Validators.IsPresent(cmbGender) &&
                Validators.IsPresent(txtEmail) &&
                Validators.IsPresent(txtPhoneNumber) &&
                Validators.IsPresent(cmbPost) &&
                Validators.IsImagePresent(picImage))
            {
                return true;
            }
            else
                return false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            var candidateRegistration = new CandidateRegistration();
            var result = candidateRegistration.CountCandidates(cmbPost.Text);
            if (IsValidateData() )
            {
                if (result)
                {
                    var r = MessageBox.Show(@"Are you sure you want to SUBMIT?", @"eVoting System",
                    MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2,
                    MessageBoxOptions.DefaultDesktopOnly);


                    if (r != DialogResult.Yes) return;
                    var candidate = new Candidate
                    {
                        CandidatePin = CandidatePin,
                        Email = txtEmail.Text.Trim(),
                        Firstname = txtFirstname.Text.Trim().ToUpper(),
                        Gender = cmbGender.Text,
                        Lastname = txtLastname.Text.Trim().ToUpper(),
                        Post = cmbPost.Text,
                        Manifesto = txtManifesto.Text,
                        Phonenumber = txtPhoneNumber.Text.Trim(),
                        PicImage = picImage.Image
                    };
                    //var candidateRegistration = new CandidateRegistration();
                    int insertedRow = candidateRegistration.InsertCandidate(candidate);
                    if (insertedRow == 1)
                    {
                        MessageBox.Show(@"Data Submitted Successfully!", @"eVoting System",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                        ClearAll();
                    }
                    else
                    {
                        MessageBox.Show(@"Error submitting data Successfully!", @"eVoting System",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information, MessageBoxDefaultButton.Button1);
                    }
                }
                else
                {
                    errProvider.SetError(cmbPost, "Sorry! You can't register for this post");
                }
            }
        }

        private void txtEmail_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var rEMail = new Regex(@"^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$");
            if (txtEmail.Text.Length > 0)
            {
                if (!rEMail.IsMatch(txtEmail.Text))
                {
                    errProvider.SetError(txtEmail, @"Wrong email format");
                    txtEmail.Focus();
                    txtEmail.SelectAll();
                    //MessageBox.Show(@"E-Mail expected", @"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    e.Cancel = true;
                }
                else
                {
                    errProvider.SetError(txtEmail, "");
                }
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
                errProvider.SetError(txtFirstname, "Accepts only letter A-Z");
                e.Handled = true;
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
                errProvider.SetError(txtLastname, "Accepts only letter A-Z");
                e.Handled = true;
            }
        }

        private void txtPhoneNumber_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var matchPhoneNumberPattern = new Regex(@"^\(?([0-9]{3})\)?[-. ]?([0-9]{4})[-. ]?([0-9]{4})$");
            if (txtPhoneNumber.Text.Length > 0)
            {
                if (!matchPhoneNumberPattern.IsMatch(txtPhoneNumber.Text))
                {
                    errProvider.SetError(txtPhoneNumber, @"Wrong phone number format");
                    txtPhoneNumber.Focus();
                    txtPhoneNumber.SelectAll();
                    e.Cancel = true;
                }
                else
                {
                    errProvider.SetError(txtPhoneNumber, "");
                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            var message = "";
            var candidate = new Candidate();
            var candidateRegistration = new CandidateRegistration();
            if (!string.IsNullOrWhiteSpace(txtSearch.Text))
            {
                candidate = candidateRegistration.SearchCandidate(txtSearch.Text.Trim(), out message);
                if (!string.IsNullOrWhiteSpace(message))
                {
                    MessageBox.Show(message, @"Voting System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    CandidatePin = txtSearch.Text;
                    txtFirstname.Text = candidate.Firstname;
                    txtLastname.Text = candidate.Lastname;
                    txtEmail.Text = candidate.Email;
                    txtPhoneNumber.Text = candidate.Phonenumber;
                    picImage.Image = candidate.PicImage;
                    cmbPost.SelectedIndex = cmbPost.FindStringExact(candidate.Post);
                    txtManifesto.Text = candidate.Manifesto;
                    cmbGender.SelectedIndex = candidate.Gender == "Male" ? 0 : 1;
                    btnDelete.Enabled = true;
                    btnUpdate.Enabled = true;
                    btnSubmit.Enabled = false;
                }
                
            }
            else
            {
                MessageBox.Show(@"Search textbox is empty", @"eVoting System", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var candidate = new Candidate();
            var candidateRegistration = new CandidateRegistration();
            var result = candidateRegistration.CountCandidates(cmbPost.Text);
            if (result)
            {
                if (IsValidateData())
                {
                    candidate.CandidatePin = CandidatePin;
                    candidate.Firstname = txtFirstname.Text.Trim().ToUpper();
                    candidate.Lastname = txtLastname.Text.Trim().ToUpper();
                    candidate.Email = txtEmail.Text.Trim();
                    candidate.Phonenumber = txtPhoneNumber.Text.Trim();
                    candidate.Gender = cmbGender.Text;
                    candidate.PicImage = picImage.Image;
                    candidate.Post = cmbPost.Text;
                    candidate.Manifesto = txtManifesto.Text;

                    var r = MessageBox.Show(@"Are you sure you want to UPDATE this record?", @"eVoting System",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2,
                        MessageBoxOptions.DefaultDesktopOnly);

                    if (r == DialogResult.Yes)
                    {
                        var rowAffected = candidateRegistration.UpdateCandidate(candidate);
                        if (rowAffected == -1)
                        {
                            MessageBox.Show(@"Record not updated successful", @"Voting System", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                        else if (rowAffected == 1)
                        {
                            MessageBox.Show(@"Record has been updated successful", @"Voting System",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                            ClearAll();
                            btnUpdate.Enabled = false;
                            btnDelete.Enabled = false;
                            btnSubmit.Enabled = true;
                        }
                    }
                }
            }
            else
            {
                errProvider.SetError(cmbPost, "Sorry! You can't register for this post");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var r = MessageBox.Show(@"Are you sure you want to DELETE this record?", @"eVoting System",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2,
                 MessageBoxOptions.DefaultDesktopOnly);

            if (r == DialogResult.Yes)
            {
                if (!string.IsNullOrWhiteSpace(txtSearch.Text))
                {
                    var candidateRegistration = new CandidateRegistration();
                    var rowAffected = candidateRegistration.DeleteCandidate(txtSearch.Text);
                    if (rowAffected == 1)
                    {
                        MessageBox.Show(@"Record DELETED successfully", @"Electronic Voting System",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                        ClearAll();
                        btnUpdate.Enabled = false;
                        btnDelete.Enabled = false;
                        btnSubmit.Enabled = true;
                    }
                    else if (rowAffected == -1)
                    {
                        MessageBox.Show(@"Record NOT found", @"Electronic Voting System", MessageBoxButtons.OK,
                            MessageBoxIcon.Information);
                    }
                }
            }
        }

        private void GroupListView()
        {
            var getList = GroupCandidate.GetCandidates();
            var orderedEnumerable = getList.GroupBy(item => item.Post).OrderBy(newGroup => newGroup.Key);

            foreach (var newGroup in orderedEnumerable)
            {
                var listViewGroup = new ListViewGroup(newGroup.Key);
                listView1.Groups.Add(listViewGroup);
                foreach (var item in newGroup)
                {
                    listView1.Items.Add(new ListViewItem( new[]
                    {
                        item.Fullname,
                        item.Gender,
                        item.Email,
                        item.Post
                    }, listViewGroup));
                }
            }
        }
    }
}
