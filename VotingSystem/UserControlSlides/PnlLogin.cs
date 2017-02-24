using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using VotingSystem.UserControlSlides;
using MetroFramework.Controls;
using MetroFramework.Forms;
using VotingSystem.Models;
using VotingSystem.Properties;

namespace VotingSystem.UserControlSlides
{
    public partial class PnlLogin : pnlSlider
    {
        public event EventHandler SettingClosed;
        public event EventHandler LogInSuccess;
        public event EventHandler Show;

        public static EventHandler LogOff { get; set; }
        public static EventHandler ShowDem { get; set; }
        Form _owner = null;
        public PnlLogin(Form owner) : base(owner)
        {
            InitializeComponent();
            _owner = owner;
            for (int i = 3; i < 13; i++)
            {
                MetroTile _tile = new MetroTile();
                _tile.Size = new Size(30, 30);
                _tile.Tag = i;
                _tile.Style = (MetroColorStyle)i;
                _tile.Click += _tile_Click;
                flpSettings.Controls.Add(_tile);
            }
            mtServer.Text = Settings.Default.Server;
            mtDatabaseName.Text = Settings.Default.Database;
            mtDbUsername.Text = Settings.Default.Username;
            mtDbPassword.Text = Settings.Default.Password;
            mtPortNo.Text = Settings.Default.Port;

            if (Settings.Default.Theme == MetroThemeStyle.Dark)
            {
                mrbDark.Checked = true;
            }
            else
            {
                mrbLight.Checked = true;
            }
        }
        void _tile_Click(object sender, EventArgs e)
        {
            ((MetroForm)this.Parent).StyleManager.Style = (MetroColorStyle)((MetroTile)sender).Tag;
            SaveSettings();
        }

        public void ShowSettings()
        {
            pnlSettings.Visible = true;
            pnlCenter.Enabled = false;
        }

        private void PnlLogin_Load(object sender, EventArgs e)
        {

        }

        private void lnkBack_Click(object sender, EventArgs e)
        {
            pnlSettings.Visible = false;
            pnlCenter.Enabled = true;
            SettingClosed?.Invoke(this, e);
            ShowDem?.Invoke(this, EventArgs.Empty);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void mrbLight_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbLight.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Light;
            }
            SaveSettings();
        }

        private void mrbDark_CheckedChanged(object sender, EventArgs e)
        {
            if (mrbDark.Checked)
            {
                ((MetroForm)this.Parent).StyleManager.Theme = MetroThemeStyle.Dark;
            }
            SaveSettings();
        }
        public void SaveSettings()
        {
            Settings.Default.Server = mtServer.Text;
            Settings.Default.Database = mtDatabaseName.Text;
            Settings.Default.Port = mtPortNo.Text;
            Settings.Default.Username = mtDbUsername.Text;
            Settings.Default.Password = mtDbPassword.Text;
            Settings.Default.Theme = ((MetroForm)this.Parent).StyleManager.Theme;
            Settings.Default.Style = ((MetroForm)this.Parent).StyleManager.Style;
            Settings.Default.StyleManager = ((MetroForm) Parent).StyleManager;
            Settings.Default.Save();
        }

        private void btnTextConn_Click(object sender, EventArgs e)
        {
            SaveSettings();
            TestCon();
        }
        private bool TestCon(bool nomessage = false)
        {
            bool _return = true;
            string _message = "Successfully established a connection!";
            MessageBoxIcon _icon = MessageBoxIcon.Information;
            SaveSettings();

            if (!Functions.TestConnection())
            {
                _message = "Failed to establish a connection using the specified connection values!";
                _icon = MessageBoxIcon.Error;
                _return = false;
            }

            if (!nomessage) MetroFramework.MetroMessageBox.Show(_owner, _message, Application.ProductName, MessageBoxButtons.OK, _icon);

            return _return;
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            if (!TestCon(true)) return;
            string _sql = "select * from [User] where Username = '" + txtUsername.Text + "'";
            DataTable _table = Functions.DataTable(_sql);
            if (_table.Rows.Count > 0)
            {
                if (_table.Rows[0].Field<string>("Password") != txtPassword.Text)
                {
                    txtPassword.Clear();
                    txtPassword.Focus();
                    MetroMessageBox.Show(_owner, "Invalid password!", 
                        Application.ProductName, MessageBoxButtons.OK, 
                        MessageBoxIcon.Warning);
                    return;
                }
            }
            else
            {
                txtUsername.Clear();
                txtPassword.Clear();
                txtUsername.Focus();
                MetroMessageBox.Show(_owner, "Username not found!", 
                    Application.ProductName, MessageBoxButtons.OK, 
                    MessageBoxIcon.Warning);
                return;
            }

            FrmMain.Username = txtUsername.Text;
            EventHandler handler = LogInSuccess;
            if (handler != null)
            {
                handler(this, EventArgs.Empty);
            }
            else
            {
                LogOff?.Invoke(this, EventArgs.Empty);
            }
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {

        }

        private void txtUsername_Click(object sender, EventArgs e)
        {

        }
    }
}
