using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;
using MetroFramework.Forms;
using VotingSystem.Properties;

namespace VotingSystem
{
    public partial class FrmLogin : MetroForm
    {
        private static FrmLogin _instance;
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            _instance = this;
        }

        public static FrmLogin Instance => _instance ?? (_instance = new FrmLogin());

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text) || string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, @"Username or Password must not be empty", @"User Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            }
            else
            {
                if (CheckUser(txtUsername.Text, txtPassword.Text))
                {
                    txtUsername.Clear();
                    txtPassword.Clear();
                    Hide();
                    var frm = new FrmIndex();
                    frm.ShowDialog();
                }
                else
                {
                    MetroMessageBox.Show(this,@"You have entered a wrong username or password", @"User Login", 
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPassword.Clear();
                    txtUsername.Clear();
                    txtUsername.Focus();
                }
            }
        }

        private bool CheckUser(string username, string password)
        {
            var check = false;
            try
            {
                const string @select = "Select * from [User] where Username = @username and Password = @password";
                using (_cnn = new SqlConnection(Settings.Default.DbConn))
                {
                    using (_cmd = new SqlCommand(select, _cnn))
                    {
                        _cmd.Parameters.AddWithValue("@username", username);
                        _cmd.Parameters.AddWithValue("@password", password);
                        _cnn.Open();
                        using (_dr = _cmd.ExecuteReader())
                        {
                            if (_dr.Read())
                                check = true;
                        }
                    }
                }

            }
            catch (System.Exception ex)
            {
                MetroMessageBox.Show(this, ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return check;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
