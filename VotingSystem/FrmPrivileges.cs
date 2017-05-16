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

        private string Voter { get; set; }
        private string Candidate { get; set; }
        private string Pin { get; set; }
        private string Biometric { get; set; }
        private string Privileges { get; set; }
        private string CreateUser { get; set; }
        private string ViewStats { get; set; }
        private string  SetDate { get; set; }
        private string DbBackUp { get; set; }
        private string DbRestore { get; set; }
        public string Export { get; set; }
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
            cmbDeleteUser.Items.Clear();
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
            chkListbox.SetItemChecked(4, false);
            chkListbox.SetItemChecked(5, false);
            chkListbox.SetItemChecked(6, false);
            chkListbox.SetItemChecked(7, false);
            chkListbox.SetItemChecked(8, false);
            chkListbox.SetItemChecked(9, false);
            chkListbox.SetItemChecked(10, false);
            LoadUsers();
        }

        private void lstUsers_SelectedIndexChanged(object sender, EventArgs e)
        {
            SelectedItem = lstUsers.Text;
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
                            chkListbox.SetItemChecked(4, _dr.GetValue(6).ToString() != "0");
                            chkListbox.SetItemChecked(5, _dr.GetValue(7).ToString() != "0");
                            chkListbox.SetItemChecked(6, _dr.GetValue(8).ToString() != "0");
                            chkListbox.SetItemChecked(7, _dr.GetValue(9).ToString() != "0");
                            chkListbox.SetItemChecked(8, _dr.GetValue(10).ToString() != "0");
                            chkListbox.SetItemChecked(9, _dr.GetValue(11).ToString() != "0");
                            chkListbox.SetItemChecked(10, _dr.GetValue(12).ToString() != "0");
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
                Voter = chkListbox.GetItemChecked(0) == false ? "0" : "1";
                Candidate = chkListbox.GetItemChecked(1) == false ? "0" : "1";
                Pin = chkListbox.GetItemChecked(2) == false ? "0" : "1";
                Biometric = chkListbox.GetItemChecked(3) == false ? "0" : "1";
                Privileges = chkListbox.GetItemChecked(4) == false ? "0" : "1";
                CreateUser = chkListbox.GetItemChecked(5) == false ? "0" : "1";
                ViewStats = chkListbox.GetItemChecked(6) == false ? "0" : "1";
                SetDate = chkListbox.GetItemChecked(7) == false ? "0" : "1";
                DbBackUp = chkListbox.GetItemChecked(8) == false ? "0" : "1";
                DbRestore = chkListbox.GetItemChecked(9) == false ? "0" : "1";
                Export = chkListbox.GetItemChecked(10) == false ? "0" : "1";
                
                const string @update =
                    "update [User] set Voter=@voter, Candidate=@cand, " +
                    "Pin=@pin, Biometric=@bio, Privilege=@pre, CreateUser=@user, "+
                    "ViewStats=@view, SetDate=@set, DbBackUp=@db, "+
                    "DbRestore=@res, Export=@exp " +
                    "Where Username=@username";
                using (_cnn = new SqlConnection(Settings.Default.DbConn))
                {
                    _cnn.Open();
                    using (_cmd = new SqlCommand(update, _cnn))
                    {
                        _cmd.Parameters.AddWithValue("@username", SelectedItem);
                        _cmd.Parameters.AddWithValue("@voter", Voter);
                        _cmd.Parameters.AddWithValue("@cand", Candidate);
                        _cmd.Parameters.AddWithValue("@pin", Pin);
                        _cmd.Parameters.AddWithValue("@bio", Biometric);
                        _cmd.Parameters.AddWithValue("@pre", Privileges);
                        _cmd.Parameters.AddWithValue("@user", CreateUser);
                        _cmd.Parameters.AddWithValue("@view", ViewStats);
                        _cmd.Parameters.AddWithValue("@set", SetDate);
                        _cmd.Parameters.AddWithValue("@db", DbBackUp);
                        _cmd.Parameters.AddWithValue("@res", DbRestore);
                        _cmd.Parameters.AddWithValue("@exp", Export);
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
