using System;
using System.Drawing;
using System.Threading;
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
        private PnlCreateUser _user = null;
        public static string Username { get; set; }
        public FrmMain()
        {
            //var t = new Thread(StartForm);
            //t.Start();
            //Thread.Sleep(2000);
            InitializeComponent();
            //t.Abort();
            StyleManager = msmMain;

            Shown += FrmMain_Shown;

            _login = new PnlLogin(this);
            _menu = new PnlMenu(this);
            _change = new PnlChangePassword(this);
            _user = new PnlCreateUser(this);
            
            _login.SettingClosed += _login_SettingClosed;
            _login.LogInSuccess += _login_LogInSuccess;
            _change.Close += _change_Close;
            //_user.Close += UserOnClose;
            PnlLogin.LogOff += _login_LogOff;
            PnlLogin.ShowDem += ShowDem;
            PnlChangePassword.SlideBack += SlideBack;
            //PnlCreateUser.SlideBack += User_SlideBack;

            _login.Swipe();

            StyleManager.Theme = Settings.Default.Theme;
            StyleManager.Style = Settings.Default.Style;
        }

        private void User_SlideBack(object sender, EventArgs eventArgs)
        {
            _user.Swipe(false);
            _menu = new PnlMenu(this);
            _menu.Swipe();
            lnkUser.Visible = true;
        }

        private void UserOnClose(object sender, EventArgs eventArgs)
        {
            _user.Swipe(false);
            _menu = new PnlMenu(this);
            _menu.Swipe();
            lnkUser.Visible = true;
        }

        //public void StartForm()
        //{
        //    Application.Run(new FrmSplashScreen());
        //}

        private void SlideBack(object sender, EventArgs eventArgs)
        {
            _change.Swipe(false);
            _menu = new PnlMenu(this);
            _menu.Swipe();
            lnkUser.Visible = true;
        }

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
            PnlMenu.Username = Username;
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
            PnlMenu.Username = Username;

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

        public void btnUser_Click(object sender, EventArgs e)
        {
            _menu.Swipe(false);
            _user = new PnlCreateUser(this);
            _user.Swipe();
            lnkSettings.Visible = false;
            lnkClose.Visible = true;
            lnkUser.Visible = true;
        }
    }
}
