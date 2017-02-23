using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using VotingSystem.Models;

namespace VotingSystem
{
    public partial class FrmVoteStats : MetroFramework.Forms.MetroForm
    {
        private IEnumerable<Candidate> _candidates; 
        public FrmVoteStats()
        {
            InitializeComponent();
        }

        private void FrmVoteStats_Load(object sender, EventArgs e)
        {
            _candidates = VoteStatic.GetCandidates();
            var positionList = VoteStatic.GetElection();
            if (positionList == null) return;
            foreach (var item in positionList)
            {
                lstPosition.Items.Add(item.Post);
            }
        }

        private void lstPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            var pic = new List<PictureBox>() {pictureBox1, pictureBox2, pictureBox3, pictureBox4};
            var label = new List<Label>()
            {
                label3,
                label4,
                label5,
                label6,
                label7,
                label8,
                label9,
                label10,
                label11,
                label12,
                label13,
                label14
            };
            chartPosition.Series["Position"].Points.Clear();
            lblPosition.Text = @"Position";
            if (lstPosition.SelectedItems.Count > 0)
            {
                var getVoteCount = VoteStatic.GetVoteCount();
                var selectedElection = lstPosition.SelectedItems[0].Text;
                lblPosition.Text = selectedElection;
                var cand = _candidates.Where(x => x.Post == selectedElection).ToList();
                var count = cand.Count;
                foreach (var item in cand)
                {
                    var countVote = getVoteCount.Count(x => x.CandidatePin == item.CandidatePin && x.Post == item.Post);
                    chartPosition.Series["Position"].Points.AddXY(item.Fullname, countVote);
                }
                if (count == 1)
                {
                    var data = cand[0].Img;
                    var ms = new MemoryStream(data);
                    pic[0].Image = Image.FromStream(ms);
                    panel3.Visible = false;
                    panel4.Visible = false;
                    panel5.Visible = false;

                    label[0].Text = cand[0].Fullname;
                    label[1].Text = @"Total No. Of Votes: " +
                                    getVoteCount.Count(
                                        x => x.CandidatePin == cand[0].CandidatePin && x.Post == cand[0].Post);
                }
                else if (count == 2)
                {
                    var data = cand[0].Img;
                    var ms = new MemoryStream(data);
                    pic[0].Image = Image.FromStream(ms);

                    var data1 = cand[1].Img;
                    var ms1 = new MemoryStream(data1);
                    pic[1].Image = Image.FromStream(ms1);
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = false;
                    panel5.Visible = false;

                    label[0].Text = cand[0].Fullname;
                    label[3].Text = cand[1].Fullname;
                    label[1].Text = @"Total No. Of Votes: " +
                                    getVoteCount.Count(
                                        x => x.CandidatePin == cand[0].CandidatePin && x.Post == cand[0].Post);
                    label[4].Text = @"Total No. Of Votes: " +
                                    getVoteCount.Count(
                                        x => x.CandidatePin == cand[1].CandidatePin && x.Post == cand[1].Post);
                }
                else if (count == 3)
                {
                    var data = cand[0].Img;
                    var ms = new MemoryStream(data);
                    pic[0].Image = Image.FromStream(ms);

                    var data1 = cand[1].Img;
                    var ms1 = new MemoryStream(data1);
                    pic[1].Image = Image.FromStream(ms1);

                    var data2 = cand[2].Img;
                    var ms2 = new MemoryStream(data2);
                    pic[2].Image = Image.FromStream(ms2);
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = true;
                    panel5.Visible = false;

                    label[0].Text = cand[0].Fullname;
                    label[3].Text = cand[1].Fullname;
                    label[6].Text = cand[2].Fullname;

                    label[1].Text = @"Total No. Of Votes: " +
                                    getVoteCount.Count(
                                        x => x.CandidatePin == cand[0].CandidatePin && x.Post == cand[0].Post);
                    label[4].Text = @"Total No. Of Votes: " +
                                    getVoteCount.Count(
                                        x => x.CandidatePin == cand[1].CandidatePin && x.Post == cand[1].Post);
                    label[7].Text = @"Total No. Of Votes: " +
                                    getVoteCount.Count(
                                        x => x.CandidatePin == cand[2].CandidatePin && x.Post == cand[2].Post);
                }
                else if (count == 4)
                {
                    var data = cand[0].Img;
                    var ms = new MemoryStream(data);
                    pic[0].Image = Image.FromStream(ms);

                    var data1 = cand[1].Img;
                    var ms1 = new MemoryStream(data1);
                    pic[1].Image = Image.FromStream(ms1);

                    var data2 = cand[2].Img;
                    var ms2 = new MemoryStream(data2);
                    pic[2].Image = Image.FromStream(ms2);

                    var data3 = cand[3].Img;
                    var ms3 = new MemoryStream(data3);
                    pic[3].Image = Image.FromStream(ms3);
                    panel2.Visible = true;
                    panel3.Visible = true;
                    panel4.Visible = true;
                    panel5.Visible = true;

                    label[0].Text = cand[0].Fullname;
                    label[3].Text = cand[1].Fullname;
                    label[6].Text = cand[2].Fullname;
                    label[9].Text = cand[3].Fullname;

                    label[1].Text = @"Total No. Of Votes: " +
                                    getVoteCount.Count(
                                        x => x.CandidatePin == cand[0].CandidatePin && x.Post == cand[0].Post);
                    label[4].Text = @"Total No. Of Votes: " +
                                    getVoteCount.Count(
                                        x => x.CandidatePin == cand[1].CandidatePin && x.Post == cand[1].Post);
                    label[7].Text = @"Total No. Of Votes: " +
                                    getVoteCount.Count(
                                        x => x.CandidatePin == cand[2].CandidatePin && x.Post == cand[2].Post);
                    label[10].Text = @"Total No. Of Votes: " +
                                    getVoteCount.Count(
                                        x => x.CandidatePin == cand[3].CandidatePin && x.Post == cand[3].Post);
                }
            }
            else
            {
                foreach (var pictureBox in pic)
                {
                    pictureBox.Image = null;
                }
            }
        }
    }
}
