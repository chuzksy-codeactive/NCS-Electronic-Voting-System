
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using VotingSystem.Properties;

namespace VotingSystem.UserControlSlides
{
    public partial class PnlMenu : pnlSlider
    {
        private Form _owner = null;
        public static string Username { get; set; }
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        public PnlMenu(Form owner) : base(owner)
        {
            InitializeComponent();
            _owner = owner;
            Username = FrmMain.Username;

        }

        private void metroTile2_Click(object sender, System.EventArgs e)
        {

        }

        private void metroTile4_Click(object sender, System.EventArgs e)
        {

        }

        private void PnlMenu_Load(object sender, EventArgs e)
        {
            Username = FrmMain.Username;
            const string @select = "Select *from [User] Where Username = @username";
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand(select, _cnn))
                {
                    _cmd.Parameters.AddWithValue("@username", Username);
                    using (_dr = _cmd.ExecuteReader())
                    {
                        if (!_dr.Read()) return;
                        mtVoter.Enabled = _dr.GetValue(2).ToString() != "0";
                        mtCandidate.Enabled = _dr.GetValue(3).ToString() != "0";
                        mtPin.Enabled = _dr.GetValue(4).ToString() != "0";
                        mtBiometric.Enabled = _dr.GetValue(5).ToString() != "0";
                        mtPrivilege.Enabled = _dr.GetValue(6).ToString() != "0";
                        mtUser.Enabled = _dr.GetValue(7).ToString() != "0";
                        mtStatistics.Enabled = _dr.GetValue(8).ToString() != "0";
                        mtSetDate.Enabled = _dr.GetValue(9).ToString() != "0";
                        mtBackupDB.Enabled = _dr.GetValue(10).ToString() != "0";
                    }
                }
            }

        }
    }
}
