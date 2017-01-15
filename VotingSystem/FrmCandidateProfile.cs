using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using VotingSystem.Models;

namespace VotingSystem
{
    public partial class FrmCandidateProfile : Form
    {
        public FrmCandidateProfile()
        {
            InitializeComponent();
        }

        public static List<Candidate> Candidates { private get; set; }
        private void FrmCandidateProfile_Load(object sender, System.EventArgs e)
        {
            var candidates = Candidates;

            lblPost.Text = candidates[0].Post;
            lblCandidatePin.Text = candidates[0].CandidatePin;
            lblFullname.Text = candidates[0].Firstname + @" " + candidates[0].Lastname;
            lblPhonenumber.Text = candidates[0].Phonenumber;
            lblEmail.Text = candidates[0].Email;
            lblManifesto.Text = candidates[0].Manifesto;

            var data = candidates[0].Img;
            var ms = new MemoryStream(data);
            picImage.Image = Image.FromStream(ms);
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
