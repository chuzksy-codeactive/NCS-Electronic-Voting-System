using System.Data.SqlClient;
using VotingSystem.Properties;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Windows.Forms;

namespace VotingSystem.Models
{
    public class VoterRegistration
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dr;

        public string GetVoterId()
        {
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("spVoterPin", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    using (dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        return dr.GetValue(0).ToString();
                    }
                }
            }
        }
        public Voters SearchVoters(string search, out string message)
        {
            var voters = new Voters();
            var msg = "";
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("Select *from VoterRegistration Where VoterPin = @voterPin", cnn))
                {
                    cmd.Parameters.AddWithValue("@voterPin", search);
                    using (dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            voters.VoterPin = dr["VoterPin"].ToString();
                            voters.Firstname = dr["Firstname"].ToString();
                            voters.Lastname = dr["Lastname"].ToString();
                            voters.Gender = dr["Gender"].ToString();
                            voters.Email = dr["Email"].ToString();
                            voters.Phonenumber = dr["PhoneNumber"].ToString();

                            var data = (byte[]) dr["picImage"];
                            var ms= new MemoryStream(data);
                            voters.VoterImg = Image.FromStream(ms);
                        }
                        else
                            msg = search.ToUpper() +" can not be found in the record";

                    }
                }
            }

            message = msg;
            return voters;
        }
        public int UpdateVoter(Voters voters, string voterPin)
        {
            var rowAffected = 0;
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                using (cmd = new SqlCommand("spUpdateByPin", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@voterPin", voterPin);
                    cmd.Parameters.AddWithValue("@firstname", voters.Firstname);
                    cmd.Parameters.AddWithValue("@lastname", voters.Lastname);
                    cmd.Parameters.AddWithValue("@gender", voters.Gender);
                    cmd.Parameters.AddWithValue("@phonenumber", voters.Phonenumber);
                    cmd.Parameters.AddWithValue("@email", voters.Email);
                    var ms = new MemoryStream();
                    voters.VoterImg.Save(ms, ImageFormat.Bmp);
                    byte[] data = ms.ToArray();
                    cmd.Parameters.AddWithValue("@pic", data);

                    cnn.Open();
                    rowAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowAffected;
        }
        public int DeleteVoter(string voterPin)
        {
            var rowAffected = 0;
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                using (cmd = new SqlCommand("spDeleteVoterById", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@voterPin", voterPin);

                    cnn.Open();
                    rowAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowAffected;
        }
    }
}
