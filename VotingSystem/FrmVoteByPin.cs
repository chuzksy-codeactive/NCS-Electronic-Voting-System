using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VotingSystem.Models;
using System.Data.SqlClient;
using VotingSystem.Properties;

namespace VotingSystem
{
    public partial class FrmVoteByPin : MetroFramework.Forms.MetroForm
    {
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;

        public FrmVoteByPin()
        {
            InitializeComponent();
            
        }
        IEnumerable<Voters> _list = new List<Voters>();
        private List<Candidate> candidates = new List<Candidate>();
        public static string CandidatePin { get; set; }

        private void FrmVoteByPin_Load(object sender, EventArgs e)
        {
            int count = 0;
            var getVoterList = new GetVoter();
            _list = getVoterList.GetVotersEnumerable();
            foreach (var voter in _list)
            {
                int n = grdVoter.Rows.Add();
                grdVoter.Rows[n].Cells[0].Value = voter.VoterPin.ToUpper();
                grdVoter.Rows[n].Cells[1].Value = voter.Firstname.ToUpper();
                grdVoter.Rows[n].Cells[2].Value = voter.Lastname.ToUpper();
                grdVoter.Rows[n].Cells[3].Value = voter.Email;
            }

            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand("Select ElectionPost From AddNewElection", _cnn))
                {
                    using (_dr = _cmd.ExecuteReader())
                    {
                        while (_dr.Read())
                        {
                            cmbPost.Items.Add(_dr["ElectionPost"].ToString());
                        }
                    }
                }
            }
        }

        private void grdVoter_MouseClick(object sender, MouseEventArgs e)
        {
            var voterPin = grdVoter.SelectedRows[0].Cells[0].Value.ToString();
            lblVoterPin.Text = voterPin;
            var imgByte = _list.Where(x => x.VoterPin == voterPin).Select(x => x.ImgBytes).SingleOrDefault();

            if (imgByte == null) return;
            var data = imgByte;
            var ms = new MemoryStream(data);
            picImage.Image = Image.FromStream(ms);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            #region Optional
            grdVoter.Rows.Clear();
            picImage.Image = null;
            lblVoterPin.Text = "";
            var getVotersList = new List<Voters>();
            string @select = "Select *From VoterRegistration Where (Firstname Like '%" + txtSearch.Text + "%') " +
                             "OR (Lastname like '%" + txtSearch.Text + "%')";
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand(select, _cnn))
                {
                    using (_dr = _cmd.ExecuteReader())
                    {
                        while (_dr.Read())
                        {
                            getVotersList.Add(new Voters()
                            {
                                VoterPin = (string)_dr["VoterPin"],
                                Firstname = (string)_dr["Firstname"],
                                Lastname = (string)_dr["Lastname"],
                                ImgBytes = (byte[])_dr["picImage"],
                                Email = (string)_dr["Email"]
                            });
                        }
                    }
                }
            }
            foreach (var voter in getVotersList)
            {
                int n = grdVoter.Rows.Add();
                grdVoter.Rows[n].Cells[0].Value = voter.VoterPin.ToUpper();
                grdVoter.Rows[n].Cells[1].Value = voter.Firstname.ToUpper();
                grdVoter.Rows[n].Cells[2].Value = voter.Lastname.ToUpper();
                grdVoter.Rows[n].Cells[3].Value = voter.Email;
            }
            #endregion

            #region Option2
            //grdVoter.Rows.Clear();
            //var getList =
            //    _list.Where(
            //        x =>
            //            x.Firstname.StartsWith(txtSearch.Text) || x.Firstname.EndsWith(txtSearch.Text));
            //foreach (var voter in getList)
            //{
            //    int n = grdVoter.Rows.Add();
            //    grdVoter.Rows[n].Cells[0].Value = voter.VoterPin;
            //    grdVoter.Rows[n].Cells[1].Value = voter.Firstname;
            //    grdVoter.Rows[n].Cells[2].Value = voter.Lastname;
            //    grdVoter.Rows[n].Cells[3].Value = voter.Email;
            //}
            #endregion

        }
        private void btnView_Click(object sender, EventArgs e)
        {
            if (cmbPost.SelectedIndex != -1)
            {
                grdCandidate.Rows.Clear();
                var loadElection = LoadElection.ElectionList();
                var selectedCandidates = loadElection.Where(x => x.Post == cmbPost.Text).ToList();
                candidates = selectedCandidates;

                foreach (var candidate in candidates)
                {
                    int n = grdCandidate.Rows.Add();
                    grdCandidate.Rows[n].Cells[0].Value = candidate.CandidatePin.ToUpper();
                    grdCandidate.Rows[n].Cells[1].Value = candidate.Firstname.ToUpper();
                    grdCandidate.Rows[n].Cells[2].Value = candidate.Lastname.ToUpper();
                    grdCandidate.Rows[n].Cells[3].Value = candidate.Email;
                } 
            }

        }

        private void grdCandidate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (grdCandidate.Columns[e.ColumnIndex].Name == "View")
            {
                CandidatePin = (string) grdCandidate.Rows[e.RowIndex].Cells[0].Value;
                var form = new FrmVoteWithPincs(CandidatePin, lblVoterPin.Text);
                form.ShowDialog(this);
            }
        }
    }
}
