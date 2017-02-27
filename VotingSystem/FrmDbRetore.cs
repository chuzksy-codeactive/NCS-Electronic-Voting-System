using System;
using MetroFramework.Forms;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using MetroFramework;
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
                Filter = @"Backup Files(*.bak)|*.bak|All Files(*.*)|*.*",
                FilterIndex = 0
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                txtBackupLocation.Text = dlg.FileName;
                lblError.Text = "";
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
                lblError.Text = string.Empty;
                var result = MetroMessageBox.Show(this, "Are you sure you want to back up the database?", "Database backup",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
                const string database = "VotingSystem";
                var backup = "USE MASTER Alter Database " +
                             database +
                             " Set MULTI_USER WITH ROLLBACK IMMEDIATE;";
                backup += "USE MASTER Restore Database " +
                          database +
                          " FROM DISK = '" +
                          txtBackupLocation.Text + "' WITH REPLACE;";
                using (_cnn = new SqlConnection(Settings.Default.DbConn))
                {
                    _cnn.Open();
                    using (_cmd = new SqlCommand(backup, _cnn))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        try
                        {
                            _cmd.ExecuteNonQuery();
                        }
                        catch (Exception ex)
                        {
                            MetroMessageBox.Show(this, ex.Message, "Error Restoring Database");
                        }
                        Cursor.Current = Cursors.Default;
                        MetroMessageBox.Show(this, "Database has been restored successfully", "Restore database",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void txtBackupLocation_TextChanged(object sender, EventArgs e)
        {
            if (txtBackupLocation.Text != string.Empty)
                lblError.Text = "";
        }
    }
}
