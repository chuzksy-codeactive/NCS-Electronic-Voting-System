using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using MetroFramework;
using VotingSystem.Models;
using Tulpep.NotificationWindow;

namespace VotingSystem
{
    public partial class FrmVoteWithPincs : MetroFramework.Forms.MetroForm
    {
        private string CandidatePin { get; set; }
        private string VoterPin { get; set; }
        public FrmVoteWithPincs(string candidatePin, string voterPin)
        {
            InitializeComponent();
            if (candidatePin != null)
            {
                CandidatePin = candidatePin;
                VoterPin = voterPin;
            }
        }
        
        private void FrmVoteWithPincs_Load(object sender, EventArgs e)
        {
            #region Populate the Candidate List
            var candidateList = LoadElection.ElectionList();
            var list = candidateList.First(x => x.CandidatePin == CandidatePin);
            lblCandidatePin.Text = list.CandidatePin;
            lblFullname.Text = list.Firstname + " " + list.Lastname;
            lblPhonenumber.Text = list.Phonenumber;
            lblEmail.Text = list.Email;
            //lblManifesto.Text = list.Manifesto;
            Text = list.Post;
            var data = list.Img;
            var ms = new MemoryStream(data);
            picImage.Image = Image.FromStream(ms);
            #endregion

            #region Populating the Voters List
            string msg = "";
            var voter = new VoterRegistration();
            var getVoter = new Voters();
            getVoter = voter.SearchVoters(VoterPin, out msg);
            lblVoterPin.Text = getVoter.VoterPin;
            lblVoterFullname.Text = getVoter.Firstname + @" " + getVoter.Lastname;
            lblVoterEmail.Text = getVoter.Email;
            picVoterImg.Image = getVoter.VoterImg;

            #endregion
        }

        private void metroLink2_Click(object sender, EventArgs e)
        {
            var check = VoterProcess.CheckIfVoted(lblVoterPin.Text, Text);
            if (check)
            {
                var saveVote = VoterProcess.SaveVote(lblVoterPin.Text, lblCandidatePin.Text, Text, 1);
                if (saveVote > 0)
                {
                    var popup = new PopupNotifier();
                    popup.Image = Properties.Resources.like;
                    popup.TitleText = "Voter for " + Text;
                    popup.ContentText = "You have voted successfully. Thank you for voting. ";
                    popup.Popup();
                    MetroMessageBox.Show(this, @"You have voted successfully", @"eVoting System", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                }
            }
            else
            {
                lblDenied.Visible = true;
            }
        }
    }
}
