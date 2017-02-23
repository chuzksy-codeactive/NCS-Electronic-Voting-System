using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using VotingSystem.Properties;

namespace VotingSystem.UserControlSlides
{
    public partial class PnlCreateUser : pnlSlider
    {
        public event EventHandler Close;
        public static EventHandler SlideBack { get; set; }
        private Form _owner = null;

        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        public PnlCreateUser(Form owner) : base(owner)
        {
            InitializeComponent();
        }

        public PnlCreateUser()
        {
            
        }

        private void btnCreateUser_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtUsername.Text))
            {
                MetroMessageBox.Show(this, "Please, enter your username", "Message", MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk);
                txtUsername.Focus();
                txtUsername.SelectAll();
                return;
            }
            if (string.IsNullOrEmpty(txtPassword.Text))
            {
                MetroMessageBox.Show(this, "Please, enter your password", "Message", MessageBoxButtons.OK,
                   MessageBoxIcon.Asterisk);
                txtPassword.Focus();
                txtPassword.SelectAll();
                return;
            }
            if (string.IsNullOrEmpty(txtConfirmPassword.Text))
            {
                MetroMessageBox.Show(this, "Confirm password is empty", "Message", MessageBoxButtons.OK,
                   MessageBoxIcon.Asterisk);
                txtConfirmPassword.Focus();
                txtConfirmPassword.SelectAll();
                return;
            }
            if (txtPassword.Text != txtConfirmPassword.Text)
            {
                MetroMessageBox.Show(this, "Password does not match", "Message", MessageBoxButtons.OK,
                   MessageBoxIcon.Asterisk);
                txtPassword.Clear();
                txtConfirmPassword.Clear();
                txtPassword.Focus();
                return;
            }
            if (!CheckUser(txtUsername.Text))
            {
                var saveUser = SaveUser(txtUsername.Text, txtPassword.Text);
                if (saveUser > 0)
                {
                    MetroMessageBox.Show(this, "User created successfully", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtConfirmPassword.Clear();
                }
                else
                {
                    MetroMessageBox.Show(this, "Error creating user", "Message", MessageBoxButtons.OK,
                        MessageBoxIcon.Stop);
                    txtUsername.Clear();
                    txtPassword.Clear();
                    txtConfirmPassword.Clear();
                }
            }
            else
            {
                MetroMessageBox.Show(this, "Username already exist", "Message", MessageBoxButtons.OK,
                   MessageBoxIcon.Stop);
                txtUsername.Clear();
                txtUsername.Focus();
            }

        }

        private bool CheckUser(string username)
        {
            var check = false;
            const string @select = "Select Username from [User] where Username = @username";
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand(select, _cnn))
                {
                    _cmd.Parameters.AddWithValue("@username", username);
                    using (_dr = _cmd.ExecuteReader())
                    {
                        if (_dr.Read())
                            check = true;
                    }
                }
            }
            return check;
        }

        private int SaveUser(string username, string password)
        {
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand("spUser", _cnn))
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    _cmd.Parameters.AddWithValue("@username", username);
                    _cmd.Parameters.AddWithValue("@password", password);
                    return _cmd.ExecuteNonQuery();
                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtUsername.Clear();
            txtConfirmPassword.Clear();
            txtPassword.Clear();
        }

        private void PnlCreateUser_Load(object sender, EventArgs e)
        {

        }

        private void lnkBack_Click(object sender, EventArgs e)
        {
            var handler = Close;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
            else
            {
                SlideBack?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
