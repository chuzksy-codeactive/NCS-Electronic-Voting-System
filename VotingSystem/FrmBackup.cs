using System;
using System.Windows.Forms;
using MetroFramework.Forms;
using System.Data;
using System.Data.SqlClient;
using MetroFramework;
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
                lblError.Text = string.Empty;
                var result = MetroMessageBox.Show(this, "Are you sure you want to back up the database?", "Database backup",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.No) return;
                const string database = "VotingSystem";
                var backup = "BACKUP DATABASE " +
                                database +
                                " TO DISK = '" + txtBackupLocation.Text + "\\" + database + "-" +
                                DateTime.Now.Ticks + ".bak' ";
                using (_cnn = new SqlConnection(Settings.Default.DbConn))
                {
                    _cnn.Open();
                    using (_cmd = new SqlCommand(backup, _cnn))
                    {
                        Cursor.Current = Cursors.WaitCursor;
                        _cmd.ExecuteNonQuery();
                        Cursor.Current = Cursors.Default;
                        MetroMessageBox.Show(this, "Database has been backup successfully", "Database Backup",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
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
