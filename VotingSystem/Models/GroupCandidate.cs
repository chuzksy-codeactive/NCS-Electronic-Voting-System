using System.Collections.Generic;
using System.Data.SqlClient;
using VotingSystem.Properties;

namespace VotingSystem.Models
{
    public class GroupCandidate
    {
        private static SqlConnection cnn;
        private static SqlCommand cmd;
        private static SqlDataReader dr;

        public string ElectionPost { get; set; }
        public string NoOfCandidate { get; set; }

        public static List<string> GetList()
        {
            var getList = new List<string>();
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("Select ElecitonPost, NoOfCandidates From AddNewElection", cnn))
                {
                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            getList.Add(dr["CandidatePin"].ToString());
                        }
                    }
                }                
            }
            return getList;
        }
        public static List<Candidate> GetCandidates()
        {
            var candidateList = new List<Candidate>();
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (
                    cmd =
                        new SqlCommand(
                            "Select CandidatePin, Firstname, Lastname, Gender, Email, Post From CandidateReg",
                            cnn))
                {
                    using (dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            candidateList.Add(new Candidate()
                            {
                                CandidatePin = dr["CandidatePin"].ToString(),
                                Firstname = dr["Firstname"].ToString(),
                                Lastname = dr["Lastname"].ToString(),
                                Gender = dr["Gender"].ToString(),
                                Email = dr["Email"].ToString(),
                                Post = dr["Post"].ToString()
                            });
                        }
                    }
                }
            }
            return candidateList;
        } 


    }
}
