using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data;
using System.Data.SqlClient;
using MetroFramework;
using Microsoft.SqlServer.Management.Common;
using Microsoft.SqlServer.Management.Smo;
using VotingSystem.Properties;

namespace VotingSystem
{
    public partial class FrmBackup : MetroForm
    {
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        public FrmBackup()
        {
            InitializeComponent();
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
                var location = txtBackupLocation.Text +"\\"+ "VotingSystem" + DateTime.Now.Ticks + ".bak";
                lblError.Text = string.Empty;
                progressBar.Value = 0;
                var result = MetroMessageBox.Show(this, "Are you sure you want to back up the database?", "Database backup",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
                try
                {
                    var dbServer =
                        new Server(new ServerConnection(Properties.Settings.Default.Server,
                            Properties.Settings.Default.Username, Properties.Settings.Default.Password));
                    var dbBackup = new Backup()
                    {
                        Action = BackupActionType.Database,
                        Database = Properties.Settings.Default.Database
                    };
                    dbBackup.Devices.AddDevice(location, DeviceType.File);
                    dbBackup.Initialize = true;
                    dbBackup.PercentComplete += DbBackup_PercentComplete;
                    dbBackup.Complete += DbBackup_Complete;
                    dbBackup.SqlBackupAsync(dbServer);
                }
                catch (Exception ex)
                {
                    MetroMessageBox.Show(this, ex.Message, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
        }

        private void DbBackup_Complete(object sender, ServerMessageEventArgs e)
        {
            if (e.Error != null)
            {
                lblStatus.Invoke((MethodInvoker)delegate
                {
                    lblStatus.Text = e.Error.Message;
                });
            }
        }

        private void DbBackup_PercentComplete(object sender, PercentCompleteEventArgs e)
        {
            progressBar.Invoke((MethodInvoker)delegate
            {
                progressBar.Value = e.Percent;
                progressBar.Update();
            });
            lblPercent.Invoke((MethodInvoker)delegate
            {
                lblPercent.Text = $"{e.Percent}";
            });
        }

        private void lnkBrowse_Click(object sender, EventArgs e)
        {
            var dlg = new FolderBrowserDialog();
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackupLocation.Text = dlg.SelectedPath;
            }
        }

        private void txtBackupLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtBackupLocation.Text != string.Empty)
                lblError.Text = "";
        }
    }
}
