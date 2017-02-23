using System.Data.SqlClient;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MetroFramework;
using VotingSystem.Properties;
using VotingSystem.SMSLive247Api;


namespace VotingSystem
{
    public partial class FrmUserLock : MetroFramework.Forms.MetroForm
    {
        public static string Username { get; set; }
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;

        public FrmUserLock()
        {
            InitializeComponent();
        }

        private void btnPassword_Click(object sender, System.EventArgs e)
        {
            string password = string.Empty;
            string select = "Select Password From [User] Where Username = @user";
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand(select , _cnn))
                {
                    _cmd.Parameters.AddWithValue("@user", Username);
                    using (_dr = _cmd.ExecuteReader())
                    {
                        if (_dr.Read())
                        {
                            password = _dr.GetValue(0).ToString();
                        }
                    }
                }
            }
            if (password == txtPassword.Text)
            {
                FormClosing -= FrmUserLock_FormClosing;
                Close();
            }
            else
            {
                MetroMessageBox.Show(this, "Wrong password", "Enter your password", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                txtPassword.Clear();
            }
        }

        private void FrmUserLock_Load(object sender, System.EventArgs e)
        {
            
            lnkUser.Text = $"Only {Username} can unlock this.";
        }

        private void FrmUserLock_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;

        }
    }
}
