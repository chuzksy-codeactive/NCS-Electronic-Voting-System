using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using MetroFramework.Components;

namespace VotingSystem
{
    public partial class FrmIndex : MetroFramework.Forms.MetroForm
    {
        public static MetroStyleManager Index { get; set; }
        public FrmIndex()
        {
            InitializeComponent();
            StyleManager = msmIndex;
            Index = msmIndex;
        }

        private void FrmIndex_Load(object sender, EventArgs e)
        {

        }

        private bool _logOut;
        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _logOut = true;
            Close();
            FrmLogin.Instance.Show();
            FrmLogin.Instance.StyleManager = StyleManager;

        }

        private void FrmIndex_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(!_logOut)
                Application.Exit();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Gets the currently active MDI child window.
            var a = ActiveMdiChild;
            //Close the MDI child window
            a?.Close();
        }

        private void closeAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Gets forms that represent the MDI child forms 
            //that are parented to this form in an array
            var charr = MdiChildren;

            //for each child form set the window state to Minimized
            foreach (var chform in charr)
                chform.Close();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void candidateMenu_Click(object sender, EventArgs e)
        {

        }

        private FrmVotersRegistration _voter;
        private void votersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_voter == null)
            {
                _voter = new FrmVotersRegistration {MdiParent = this};
                _voter.FormClosed += _voter_FormClosed;
                _voter.Show();
                _voter.StyleManager = StyleManager;
            }
            else
            {
                _voter.Activate();
                _voter.WindowState = FormWindowState.Normal;
            }
        }

        private void _voter_FormClosed(object sender, FormClosedEventArgs e)
        {
            _voter = null;
        }

        private FrmCandidate _candidate;
        private void candidatesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_candidate == null)
            {
                _candidate = new FrmCandidate {MdiParent = this};
                _candidate.FormClosed += _candidate_FormClosed;
                _candidate.Show();
                _candidate.StyleManager = StyleManager;
            }
            else
            {
                _candidate.Activate();
                _candidate.WindowState = FormWindowState.Normal;
            }
        }

        private void _candidate_FormClosed(object sender, FormClosedEventArgs e)
        {
            _candidate = null;
        }

        private FrmElectionModule _election;
        private void castVoteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (_election == null)
            {
                _election = new FrmElectionModule {MdiParent = this};
                _election.FormClosed += _election_FormClosed;
                _election.Show();
                _election.StyleManager = StyleManager;
            }
            else
            {
                _election.Activate();
                _election.WindowState = FormWindowState.Normal;
            }
        }

        private void _election_FormClosed(object sender, FormClosedEventArgs e)
        {
            _election = null;
        }

        private FrmCreateUser _create;
        private void createUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_create == null)
            {
                _create = new FrmCreateUser {MdiParent = this};
                _create.FormClosed += _create_FormClosed;
                _create.Show();
                _create.StyleManager = StyleManager;
            }
            else
            {
                _create.Activate();
                _create.WindowState = FormWindowState.Normal;
            }
        }

        private void _create_FormClosed(object sender, FormClosedEventArgs e)
        {
            _create = null;
        }

        private FrmAddNewElection _addNew;
        private void setElectionDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_addNew == null)
            {
                _addNew = new FrmAddNewElection {MdiParent = this};
                _addNew.FormClosed += _addNew_FormClosed;
                _addNew.Show();
                _addNew.StyleManager = StyleManager;
            }
            else
            {
                _addNew.Activate();
                _addNew.WindowState = FormWindowState.Normal;
            }
        }

        private void _addNew_FormClosed(object sender, FormClosedEventArgs e)
        {
            _addNew = null;
        }

        private FrmVoteStats _stats;
        private void statisticsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_stats == null)
            {
                _stats = new FrmVoteStats {MdiParent = this};
                _stats.FormClosed += _stats_FormClosed;
                _stats.Show();
                _stats.StyleManager = StyleManager;
            }
            else
            {
                _stats.Activate();
                _stats.WindowState = FormWindowState.Normal;
            }
        }

        private void _stats_FormClosed(object sender, FormClosedEventArgs e)
        {
            _stats = null;
        }

        private FrmPrivileges _privileges;
        private void privilegeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_privileges == null)
            {
                _privileges = new FrmPrivileges {MdiParent = this};
                _privileges.FormClosed += _privileges_FormClosed;
                _privileges.Show();
                _privileges.StyleManager = StyleManager;
            }
            else
            {
                _privileges.Activate();
                _privileges.WindowState = FormWindowState.Normal;
            }
        }

        private void _privileges_FormClosed(object sender, FormClosedEventArgs e)
        {
            _privileges = null;
        }

        private void cascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void tileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void arrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private FrmTheme _theme;
        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (_theme == null)
            {
                _theme = new FrmTheme {MdiParent = this};
                _theme.FormClosed += _theme_FormClosed;
                _theme.Show();
                _theme.StyleManager = StyleManager;
            }
            else
            {
                _theme.Activate();
                _theme.WindowState = FormWindowState.Normal;
            }
        }

        private void _theme_FormClosed(object sender, FormClosedEventArgs e)
        {
            _theme = null;
        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmIndex.Theme = MetroThemeStyle.Dark;
        }

        private void lightToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmIndex.Theme = MetroThemeStyle.Light;
        }

        private void defaultToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmIndex.Theme = MetroThemeStyle.Default;
        }

        private void blackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmIndex.Style = (MetroColorStyle) 1;
        }

        private void whiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmIndex.Style = (MetroColorStyle) 2;
        }

        private void blueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmIndex.Style = (MetroColorStyle) 4;
        }

        private void greenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmIndex.Style = (MetroColorStyle)5;
        }

        private void limeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmIndex.Style = (MetroColorStyle)6;
        }

        private void redToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmIndex.Style = (MetroColorStyle)13;
        }

        private void pinkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmIndex.Style = (MetroColorStyle)10;
        }

        private void purpleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            msmIndex.Style = (MetroColorStyle)12;
        }
    }
}
