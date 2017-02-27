using System;
using MetroFramework.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using VotingSystem.Properties;

namespace VotingSystem
{
    public partial class FrmDbRetore : MetroForm
    {
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        public FrmDbRetore()
        {
            InitializeComponent();
        }

        private void lnkBrowse_Click(object sender, EventArgs e)
        {
            var dlg = new OpenFileDialog
            {
                Title = @"Database backup",  
                Filter = @"Backup Files(*.bak)|*.bak|All Files(*.*)|*.*",
                FilterIndex = 0
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackupLocation.Text = dlg.FileName;
                lblError.Text = "";
                lblPercent.Text = @"0 %";
                lblStatus.Text = string.Empty;
                progressBar.Value = 0;
            }
        }

        private void lnkCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void lnkBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtBackupLocation.Text))
                lblError.Text = @"Select a location path first";
            else
            {
                Cursor.Current = Cursors.WaitCursor;
                progressBar.Value = 0;
                lblError.Text = string.Empty;
                var result = MetroMessageBox.Show(this, "Are you sure you want to restore this database?", "Database restore",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
                try
                {
                    var dbServer = new Server(new ServerConnection(Properties.Settings.Default.Server, Properties.Settings.Default.Username, Properties.Settings.Default.Password));
                    var dbRestore = new Restore()
                    {
                        Database = Properties.Settings.Default.Database,
                        Action = RestoreActionType.Database,
                        ReplaceDatabase = true,
                        NoRecovery = false
                    };
                    dbRestore.Devices.AddDevice(txtBackupLocation.Text, DeviceType.File);
                    dbRestore.PercentComplete += DbRestore_PercentComplete;
                    dbRestore.Complete += DbRestore_Complete;
                    dbRestore.SqlRestoreAsync(dbServer);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Error restoring database", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                }
                Cursor.Current = Cursors.Default;
            }
        }

        private void DbRestore_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus.Invoke((MethodInvoker) delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbRestore_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker) delegate
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            });
            lblPercent.Invoke((MethodInvoker) delegate
            {
                lblPercent.Text = $"{e.Percent}";
            });
        }


        private void txtBackupLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtBackupLocation.Text != string.Empty)
                lblError.Text = "";
        }
    }
}
