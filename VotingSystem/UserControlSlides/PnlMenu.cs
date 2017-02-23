
using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Data;
using MetroFramework.Components;
using VotingSystem.Properties;

namespace VotingSystem.UserControlSlides
{
    public partial class PnlMenu : pnlSlider
    {
        private Form _owner = null;
        public MetroStyleManager Style { get; set; }
        public static string Username { get; set; }
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        public PnlMenu(Form owner) : base(owner)
        {
            InitializeComponent();
            _owner = owner;
            Username = FrmMain.Username;
            StyleManager = Settings.Default.StyleManager;
        }

        private void metroTile2_Click(object sender, System.EventArgs e)
        {
            var form = new FrmCandidate();
            Settings.Default.StyleManager.Clone(form);
            form.ShowDialog(this);
        }

        private void metroTile4_Click(object sender, System.EventArgs e)
        {
            var form = new FrmAddNewElection();
            Settings.Default.StyleManager.Clone(form);
            form.ShowDialog(this);
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

        private void mtVoter_Click(object sender, EventArgs e)
        {
            var form = new FrmVotersRegistration();
            Settings.Default.StyleManager.Clone(form);
            form.ShowDialog(this);
        }

        private void mtPin_Click(object sender, EventArgs e)
        {
            var form = new FrmVoteByPin();
            Settings.Default.StyleManager.Clone(form);
            form.ShowDialog(this);
        }

        private void mtPrivilege_Click(object sender, EventArgs e)
        {
            var form = new FrmPrivileges();
            Settings.Default.StyleManager.Clone(form);
            form.ShowDialog(this);
        }

        private void mtUser_Click(object sender, EventArgs e)
        {
            var form = new FrmCreateUser();
            Settings.Default.StyleManager.Clone(form);
            form.ShowDialog(this);
        }

        private void mtStatistics_Click(object sender, EventArgs e)
        {
            var form = new FrmVoteStats();
            Settings.Default.StyleManager.Clone(form);
            form.ShowDialog(this);
        }

        private void mtSetDate_Click(object sender, EventArgs e)
        {
            var form = new FrmAddNewElection();
            Settings.Default.StyleManager.Clone(form);
            form.ShowDialog(this);
        }
    }
}
