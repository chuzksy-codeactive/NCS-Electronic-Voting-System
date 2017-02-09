using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework;
using VotingSystem.Models;
using VotingSystem.Properties;

namespace VotingSystem
{
    public partial class FrmPrivileges : MetroFramework.Forms.MetroForm
    {
        private SqlCommand _cmd;
        private SqlConnection _cnn;
        private SqlDataReader _dr;

        private string Registration { get; set; }
        private string CastVote { get; set; }
        private string Admin { get; set; }
        private string View { get; set; }
        private string SelectedItem { get; set; }

        public FrmPrivileges()
        {
            InitializeComponent();
        }

        private void FrmPrivileges_Load(object sender, EventArgs e)
        {
            GetUsers();
        }

        private void LoadUsers()
        {
            var users = Privilege.GetAllUsers();
            foreach (var user in users)
            {
                lstUsers.Items.Add(user);
                cmbDeleteUser.Items.Add(user);
            }
        }

        private void GetUsers()
        {
            lstUsers.Items.Clear();
            chkListbox.SetItemChecked(0, false);
            chkListbox.SetItemChecked(1, false);
            chkListbox.SetItemChecked(2, false);
            chkListbox.SetItemChecked(3, false);
            LoadUsers();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = lstUsers.SelectedItems[0].Text;
            const string @select = "Select * from [User] where Username = @username";
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand(select, _cnn))
                {
                    _cmd.Parameters.AddWithValue("@username", SelectedItem);
                    using (_dr = _cmd.ExecuteReader())
                    {
                        if (_dr.Read())
                        {
                            chkListbox.SetItemChecked(0, _dr.GetValue(2).ToString() != "0");
                            chkListbox.SetItemChecked(1, _dr.GetValue(3).ToString() != "0");
                            chkListbox.SetItemChecked(2, _dr.GetValue(4).ToString() != "0");
                            chkListbox.SetItemChecked(3, _dr.GetValue(5).ToString() != "0");
                        }
                        else
                        {
                            MetroMessageBox.Show(this,@"Cannot read data","Message",MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            if (!string.IsNullOrEmpty(SelectedItem))
            {
                Registration = chkListbox.GetItemChecked(0) == false ? "0" : "1";
                CastVote = chkListbox.GetItemChecked(1) == false ? "0" : "1";
                Admin = chkListbox.GetItemChecked(2) == false ? "0" : "1";
                View = chkListbox.GetItemChecked(3) == false ? "0" : "1";
                const string @update =
                    "update [User] set Registration=@reg, CastVote=@cast, " +
                    "[Admin]=@admin,[View]=@view Where Username=@username";
                using (_cnn = new SqlConnection(Settings.Default.DbConn))
                {
                    _cnn.Open();
                    using (_cmd = new SqlCommand(update, _cnn))
                    {
                        _cmd.Parameters.AddWithValue("@username", SelectedItem);
                        _cmd.Parameters.AddWithValue("@reg", Registration);
                        _cmd.Parameters.AddWithValue("@cast", CastVote);
                        _cmd.Parameters.AddWithValue("@admin", Admin);
                        _cmd.Parameters.AddWithValue("@view", View);
                        _cmd.ExecuteNonQuery();
                        MetroMessageBox.Show(this,@"Privilege assigned successfully", @"Assign Privilege to Users",MessageBoxButtons.OK, MessageBoxIcon.Information);
                        GetUsers();
                    }
                }
            }
            else
                MetroMessageBox.Show(this,@"Please select a username", @"Assign Privilege to Users", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            if (cmbDeleteUser.Text != "")
            {
                using (_cnn = new SqlConnection(Settings.Default.DbConn))
                {
                    _cnn.Open();
                    using (_cmd = new SqlCommand("Delete [User] Where Username=@user", _cnn))
                    {
                        _cmd.Parameters.AddWithValue("@user", cmbDeleteUser.Text);
                        _cmd.ExecuteNonQuery();
                        MetroMessageBox.Show(this, @"Username deleted successfully", @"Assign Privilege to User",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cmbDeleteUser.Items.Clear();
                        GetUsers();
                    }
                }
            }
            else
            {
                MetroMessageBox.Show(this, @"Please! Select a username to delete", @"Assign Privilege to User",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void metroButton3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
