using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VotingSystem.Models;

namespace VotingSystem
{
    public partial class FrmVoteByPin : MetroFramework.Forms.MetroForm
    {
        public FrmVoteByPin()
        {
            InitializeComponent();
            
        }
        IEnumerable<Voters> _list = new List<Voters>();
        private void FrmVoteByPin_Load(object sender, EventArgs e)
        {
            int count = 0;
            var getVoterList = new GetVoter();
            _list = getVoterList.GetVotersEnumerable();
            foreach (var voter in _list)
            {
                int n = grdVoter.Rows.Add();
                grdVoter.Rows[n].Cells[0].Value = voter.VoterPin;
                grdVoter.Rows[n].Cells[1].Value = voter.Firstname;
                grdVoter.Rows[n].Cells[2].Value = voter.Lastname;
                grdVoter.Rows[n].Cells[3].Value = voter.Email;
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
    }
}
