using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using VotingSystem.Properties;
using VotingSystem.Models;

namespace VotingSystem
{
    public partial class FrmAddNewElection : MetroFramework.Forms.MetroForm
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public FrmAddNewElection()
        {
            InitializeComponent();
        }
        private static readonly ErrorProvider errProvider = new ErrorProvider();
        private DateTime StartDate { get; set; }
        private DateTime EndDate { get; set; }
        public static string SelectedItem { get; set; }

        private void FrmAddNewElection_Load(object sender, EventArgs e)
        {
            txtElectionId.Clear();
            txtElectionPost.Clear();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using(cmd = new SqlCommand("Select *from AddNewElection", cnn))
                {
                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var lst = new ListViewItem
                            {
                                ImageIndex = 0,
                                Text = dr["ElectionId"].ToString()
                            };
                            lst.SubItems.Add(dr["ElectionPost"].ToString());
                            lst.SubItems.Add((dr["NoOfCandidates"]).ToString());
                            lst.SubItems.Add(Convert.ToDateTime(dr["StartDate"].ToString()).ToShortDateString());
                            lst.SubItems.Add(Convert.ToDateTime(dr["EndDate"].ToString()).ToShortDateString());
                            lstViewElection.Items.Add(lst);
                        }
                    } 
                }
            }
        }

        private void lstViewElection_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstViewElection.SelectedItems.Count != 0)
            {
                var election = new Election();
                SelectedItem = lstViewElection.SelectedItems[0].Text;
                election = AddNewElection.SelectedItem(SelectedItem);
                txtElectionId.Text = election.ElectionId;
                txtElectionPost.Text = election.Post;
                dtStartDate.Value = election.StartDate;
                dtEndDate.Value = election.EndDate;
                if (election.NoOfCandidates == 2)
                {
                    cmbNoOfCandidates.SelectedIndex = 0;
                }
                else if (election.NoOfCandidates == 3)
                {
                    cmbNoOfCandidates.SelectedIndex = 1;
                }
                else
                {
                    cmbNoOfCandidates.SelectedIndex = 2;
                }
                txtElectionId.ReadOnly = true;
                btnSubmit.Enabled = false;
                btnUpdate.Enabled = true;
                btnDelete.Enabled = true;
            }
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            lstViewElection.Items.Clear();
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("Select *from AddNewElection", cnn))
                {
                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            var lst = new ListViewItem
                            {
                                ImageIndex = 0,
                                Text = dr["ElectionId"].ToString()
                            };
                            lst.SubItems.Add(dr["ElectionPost"].ToString());
                            lst.SubItems.Add((dr["NoOfCandidates"]).ToString());
                            lst.SubItems.Add(Convert.ToDateTime(dr["StartDate"].ToString()).ToShortDateString());
                            lst.SubItems.Add(Convert.ToDateTime(dr["EndDate"].ToString()).ToShortDateString());
                            lstViewElection.Items.Add(lst);
                        }
                    }
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var election = new Election();
            election.ElectionId = txtElectionId.Text.Trim().ToUpper();
            election.Post = txtElectionPost.Text.Trim().ToUpper();
            election.NoOfCandidates = Convert.ToInt32(cmbNoOfCandidates.Text);
            election.StartDate = dtStartDate.Value;
            election.EndDate = dtEndDate.Value;
            var rowAffected = AddNewElection.UpdateElection(election);
            if (rowAffected > 0)
            {
                MessageBox.Show(@"Record updated successfully");
                txtElectionId.Clear();
                txtElectionPost.Clear();
                btnSubmit.Enabled = true;
                btnDelete.Enabled = false;
                btnUpdate.Enabled = false;
                btnView_Click(null, null);
                cmbNoOfCandidates.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(@"Record not updated successfully");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            StartDate = dtStartDate.Value;
            EndDate = dtEndDate.Value;
            var currentDate = DateTime.Now;
            int result = DateTime.Compare(currentDate, StartDate);
            int result2 = DateTime.Compare(currentDate, EndDate);
            if (result >= 1 && result2 <= 1)
            {
                MessageBox.Show(@"Election can't be deleted. Election on process", 
                    @"eVoting System", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                var deleted = AddNewElection.DeleteElection(txtElectionId.Text);
                MessageBox.Show(deleted > 0 ? @"Deleted successfully" : @"Error deleting successfully", @"eVoting System");
                btnView_Click(null, null);
            }
        }

        private void btnCancel_Click_1(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSubmit_Click_1(object sender, EventArgs e)
        {
            StartDate = dtStartDate.Value;
            EndDate = dtEndDate.Value;
            int result = DateTime.Compare(EndDate, StartDate);
            if (result < 0)
            {
                errProvider.SetError(dtEndDate, "Election end date should be greater than start date");
            }
            else
            {
                errProvider.SetError(dtEndDate, "");
                var election = new Election
                {
                    ElectionId = txtElectionId.Text.Trim().ToUpper(),
                    Post = txtElectionPost.Text.Trim().ToUpper(),
                    NoOfCandidates = Convert.ToInt32(cmbNoOfCandidates.Text),
                    StartDate = dtStartDate.Value,
                    EndDate = dtEndDate.Value
                };
                if (AddNewElection.Read(txtElectionId.Text) > 0)
                {
                    var newElection = AddNewElection.NewElection(election);
                    MessageBox.Show(newElection > 0 ? @"Successfully add a new election" : @"Error adding a new election",
                        @"eVoting System");
                }
                else
                {
                    MessageBox.Show(@"Duplicate election Id is not allowed", @"eVoting System"); ;
                }
            }
            lstViewElection.Items.Clear();
            cmbNoOfCandidates.SelectedIndex = -1;
            btnView_Click(null, null);
        }

        private void btnNew_Click_1(object sender, EventArgs e)
        {
            txtElectionId.Clear();
            txtElectionPost.Clear();
            btnDelete.Enabled = false;
            btnUpdate.Enabled = false;
            btnSubmit.Enabled = true;
        }

        private void dtStartDate_ValueChanged_1(object sender, EventArgs e)
        {
            StartDate = dtStartDate.Value;
        }

        private void dtEndDate_ValueChanged_1(object sender, EventArgs e)
        {
            EndDate = dtEndDate.Value;
            int result = DateTime.Compare(EndDate, StartDate);
            if (result < 0)
            {
                errProvider.SetError(dtEndDate, "Election end date should be greater than start date");
            }
            else
            {
                errProvider.SetError(dtEndDate, "");
            }
        }
    }
}
