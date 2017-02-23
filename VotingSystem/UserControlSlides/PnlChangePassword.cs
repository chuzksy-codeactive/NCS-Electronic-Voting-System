using System;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using MetroFramework;
using VotingSystem.Properties;

namespace VotingSystem.UserControlSlides
{
    public partial class PnlChangePassword : pnlSlider
    {
        public event EventHandler ChangePasswordSuccess;
        public event EventHandler Close;
        public static  EventHandler Open { get; set; }
        public static EventHandler SlideBack { get; set; }
        public static string Username { get; set; }
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        Form _owner = null;
        public PnlChangePassword(Form owner) : base(owner)
        {
            InitializeComponent();
            _owner = owner;
            lnkUsername.Text = Username;
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            const string @select = "Select Password From [User] Where Username = @user and Password = @password";
            const string @update = "Update [User] Set Password = @password Where Username = @user";
            bool password = false;
            if (txtOldPassword.Text == "" || txtConfirmPassword.Text == "" || txtNewPassword.Text == "")
            {
                MetroMessageBox.Show(this, "All fields are required", "Change Password", MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }
            if (txtConfirmPassword.Text != txtNewPassword.Text)
            {
                MetroMessageBox.Show(this, "Password Mismatch", "Change Password", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return;
            }

            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand(select, _cnn))
                {
                    _cmd.Parameters.AddWithValue("@user", Username);
                    _cmd.Parameters.AddWithValue("@password", txtOldPassword.Text);
                    using (_dr = _cmd.ExecuteReader())
                    {
                        if (_dr.Read())
                        {
                            password = true;
                        }
                        else
                        {
                            MetroMessageBox.Show(this, "Wrong password entered", "Change Password", MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                            txtOldPassword.Clear();
                            txtConfirmPassword.Clear();
                            txtNewPassword.Clear();
                        }
                            
                    }
                }
                if (password)
                {
                    using (_cmd = new SqlCommand(update, _cnn))
                    {
                        _cmd.Parameters.AddWithValue("@password", txtNewPassword.Text);
                        _cmd.Parameters.AddWithValue("@user", Username);
                        _cmd.ExecuteNonQuery();
                        MetroMessageBox.Show(this, "You have successfully changed your password", "Change Password", MessageBoxButtons.OK,
                                MessageBoxIcon.Information);
                        txtOldPassword.Clear();
                        txtConfirmPassword.Clear();
                        txtNewPassword.Clear();
                    }
                }
            }
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

        private void PnlChangePassword_Load(object sender, EventArgs e)
        {
            lnkUsername.Text = Username;
        }
    }
}
