using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using VotingSystem.Properties;

namespace VotingSystem.Models
{
    public class CandidateRegistration
    {
        private SqlConnection cnn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public string GetCandidatePin()
        {
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("spCandidatePin", cnn))
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

        public int InsertCandidate(Candidate candidate)
        {
            int insertedRow = 0;
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                using (cmd = new SqlCommand("spAddNewCandidate", cnn))
                {
                    cmd.Parameters.AddWithValue("@candidatePin", candidate.CandidatePin);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@firstname", candidate.Firstname);
                    cmd.Parameters.AddWithValue("@lastname", candidate.Lastname);
                    cmd.Parameters.AddWithValue("@gender", candidate.Gender);
                    cmd.Parameters.AddWithValue("email", candidate.Email);
                    cmd.Parameters.AddWithValue("@phonenumber", candidate.Phonenumber);
                    cmd.Parameters.AddWithValue("@post", candidate.Post);
                    cmd.Parameters.AddWithValue("@man", candidate.Manifesto);

                    var outParameter = new SqlParameter
                    {
                        ParameterName = "@candidateId",
                        SqlDbType = SqlDbType.UniqueIdentifier,
                        Direction = ParameterDirection.Output
                    };
                    cmd.Parameters.Add(outParameter);

                    var ms = new MemoryStream();
                    candidate.PicImage.Save(ms, ImageFormat.Gif);
                    byte[] data = ms.ToArray();
                    cmd.Parameters.AddWithValue("@pic", data);

                    cnn.Open();
                    insertedRow = cmd.ExecuteNonQuery();
                    FrmCandidate.CandidateId = outParameter.Value.ToString();
                }
            }
            return insertedRow;
        }

        public Candidate SearchCandidate(string candidatePin, out string msg)
        {
            var candidate = new Candidate();
            var message = "";
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("Select *from CandidateReg Where CandidatePin = @candidatePin", cnn))
                {
                    cmd.Parameters.AddWithValue("@candidatePin", candidatePin);
                    using (dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            candidate.Firstname = dr["Firstname"].ToString();
                            candidate.Lastname = dr["Lastname"].ToString();
                            candidate.Email = dr["Email"].ToString();
                            candidate.Phonenumber = dr["PhoneNumber"].ToString();
                            candidate.Gender = dr["Gender"].ToString();
                            candidate.Post = dr["Post"].ToString();
                            candidate.Manifesto = dr["Manifesto"].ToString();

                            var data = (byte[])dr["picImage"];
                            var ms = new MemoryStream(data);
                            candidate.PicImage = Image.FromStream(ms);
                        }
                        else
                            message = candidatePin.ToUpper() + " can not be found in the record";
                    }
                }
            }
            msg = message;
            return candidate;
        }
        public int UpdateCandidate(Candidate candidate)
        {
            int rowAffected = 0;
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                using (cmd = new SqlCommand("spUpdateCandidateByPin", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@candidatePin", candidate.CandidatePin);
                    cmd.Parameters.AddWithValue("@firstname", candidate.Firstname);
                    cmd.Parameters.AddWithValue("@lastname", candidate.Lastname);
                    cmd.Parameters.AddWithValue("@gender", candidate.Gender);
                    cmd.Parameters.AddWithValue("@phonenumber", candidate.Phonenumber);
                    cmd.Parameters.AddWithValue("@email", candidate.Email);
                    cmd.Parameters.AddWithValue("@post", candidate.Post);
                    cmd.Parameters.AddWithValue("@man", candidate.Manifesto);

                    var ms = new MemoryStream();
                    candidate.PicImage.Save(ms, ImageFormat.Bmp);
                    byte[] data = ms.ToArray();
                    cmd.Parameters.AddWithValue("@pic", data);

                    cnn.Open();
                    rowAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowAffected;
        }
        public int DeleteCandidate(string voterPin)
        {
            var rowAffected = 0;
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                using (cmd = new SqlCommand("spDeleteCandidateById", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@candidatePin", voterPin);

                    cnn.Open();
                    rowAffected = cmd.ExecuteNonQuery();
                }
            }
            return rowAffected;
        }
        public bool CountCandidates(string post)
        {
            var countPost = 0;
            var num = 0;
            bool result = false;
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("spSelectCandidate", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@post", post);
                    cmd.Parameters.AddWithValue("@electionPost", post);
                    using (dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        countPost = Convert.ToInt32(dr.GetValue(0).ToString());

                        dr.NextResult();
                        dr.Read();
                        num = Convert.ToInt32(dr.GetValue(0).ToString());
                    }
                }
            }
            if (num > countPost)
                result = true;
            return result;
        }
    }
}
