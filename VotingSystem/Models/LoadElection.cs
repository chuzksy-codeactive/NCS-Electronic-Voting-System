using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Xml.Schema;
using VotingSystem.Properties;

namespace VotingSystem.Models
{
    public static class LoadElection
    {
        private static SqlConnection cnn;
        private static SqlCommand cmd;
        private static SqlDataReader dr;
        public static List<Candidate> ElectionList()
        {
            var electionList = new List<Candidate>();
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("Select *From CandidateReg", cnn))
                {
                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            electionList.Add(new Candidate()
                            {
                                CandidatePin = dr["CandidatePin"].ToString(),
                                Firstname = dr["Firstname"].ToString(),
                                Lastname = dr["Lastname"].ToString(),
                                Email = dr["Email"].ToString(),
                                Gender = dr["Gender"].ToString(),
                                Manifesto = dr["Manifesto"].ToString(),
                                Phonenumber = dr["PhoneNumber"].ToString(),
                                Fullname = dr["Firstname"] +@" " +dr["Lastname"],
                                Img = (byte[])dr["picImage"], 
                                Post = dr["Post"].ToString()
                            });
                        }
                    }
                }
            }
            return electionList;
        }
    }
}
