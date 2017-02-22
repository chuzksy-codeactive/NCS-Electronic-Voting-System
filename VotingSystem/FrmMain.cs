using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Forms;
using VotingSystem.Properties;
using VotingSystem.UserControlSlides;

namespace VotingSystem
{
    public partial class FrmMain : MetroForm
    {
        PnlLogin _login = null;
        private PnlMenu _menu = null;
        private PnlChangePassword _change = null;
        public static string Username { get; set; }
        public FrmMain()
        {
            InitializeComponent();
            StyleManager = msmMain;

            Shown += FrmMain_Shown;

            _login = new PnlLogin(this);
            _menu = new PnlMenu(this);
            _change = new PnlChangePassword(this);
            
            _login.SettingClosed += _login_SettingClosed;
            _login.LogInSuccess += _login_LogInSuccess;
            _change.Close += _change_Close;
            PnlLogin.LogOff += _login_LogOff;
            PnlLogin.ShowDem += ShowDem;
            //PnlChangePassword.Open += Open;
            PnlChangePassword.SlideBack += SlideBack;

            _login.Swipe();

            StyleManager.Theme = Settings.Default.Theme;
            StyleManager.Style = Settings.Default.Style;
        }

        private void SlideBack(object sender, EventArgs eventArgs)
        {
            _change.Swipe(false);
            _menu = new PnlMenu(this);
            _menu.Swipe();
            lnkUser.Visible = true;
        }

        //private void Open(object sender, EventArgs eventArgs)
        //{
        //    _change.Swipe(false);
        //    _menu = new PnlMenu(this);
        //    _menu.Swipe(false);
        //    lnkUser.Visible = false;
        //}

        private void _change_Close(object sender, EventArgs e)
        {
            _change.Swipe(false);
            _menu = new PnlMenu(this);
            _menu.Swipe();
            lnkUser.Visible = true;
        }

        private void ShowDem(object sender, EventArgs eventArgs)
        {
            lnkClose.Visible = true;
            lnkSettings.Visible = true;
        }

        private void FrmMain_Shown(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            FormBorderStyle = FormBorderStyle.None;
            Bounds = Screen.PrimaryScreen.Bounds;
            Focus();
        }

        private void _login_LogOff(object sender, EventArgs e)
        {
            _login.Swipe(false);
            _menu = new PnlMenu(this);
            _menu.Swipe();
            lnkSettings.Visible = false;
            lnkClose.Visible = false;
            lnkUser.Visible = true;
            lnkUser.Text = Username;
            FrmUserLock.Username = Username;
            PnlChangePassword.Username = Username;
        }

        private void _login_SettingClosed(object sender, EventArgs e)
        {
            lnkSettings.Visible = true;
            lnkClose.Visible = true;
        }

        private void _login_LogInSuccess(object sender, EventArgs e)
        {
            _login.Swipe(false);
            _menu.Swipe();
            lnkSettings.Visible = false;
            lnkClose.Visible = false;
            lnkUser.Visible = true;
            lnkUser.Text = Username;
            FrmUserLock.Username = Username;
            PnlChangePassword.Username = Username;

        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            lnkUser.Visible = false;
        }

        private void lnkSettings_Click(object sender, EventArgs e)
        {
            lnkSettings.Visible = false;
            lnkClose.Visible = false;
            lnkUser.Visible = false;

            _login.ShowSettings();
        }

        private void lnkClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lnkUser_Click(object sender, EventArgs e)
        {
            mContextMenuUser.Show(lnkUser, new Point(0, lnkUser.Height));
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logOffToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _menu.Swipe(false);
            _login = new PnlLogin(this);
            _login.Swipe();
            lnkSettings.Visible = true;
            lnkClose.Visible = true;
            lnkUser.Visible = false;
        }

        private void lockToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var user = new FrmUserLock();
            user.ShowDialog(this);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _menu.Swipe(false);
            _change = new PnlChangePassword(this);
            _change.Swipe();
            lnkUser.Visible = false;
        }
    }
}
