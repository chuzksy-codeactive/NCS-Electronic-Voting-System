using System.Collections.Generic;
using System.Data.SqlClient;
using VotingSystem.Properties;

namespace VotingSystem.Models
{
    public static class VoteStatic
    {
        private static SqlConnection _cnn;
        private static SqlCommand _cmd;
        private static SqlDataReader _dr;
        public static IEnumerable<Election> GetElection()
        {
            var electionList = new List<Election>();
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand("Select *From AddNewElection", _cnn))
                {
                    using (_dr = _cmd.ExecuteReader())
                    {
                        while (_dr.Read())
                        {
                            electionList.Add(new Election()
                            {
                                ElectionId = _dr["ElectionId"].ToString(),
                                NoOfCandidates = (int)_dr["NoOfCandidates"],
                                Post = (string)_dr["ElectionPost"]
                            });
                        }   
                    }
                }
            }  
            return electionList;
        }

        public static IEnumerable<Candidate> GetCandidates()
        {
            var candidateList =  new List<Candidate>();
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand("Select *from CandidateReg", _cnn))
                {
                    using (_dr = _cmd.ExecuteReader())
                    {
                        while (_dr.Read())
                        {
                            candidateList.Add(new Candidate()
                            {
                                CandidatePin = (string) _dr["CandidatePin"],
                                Firstname = (string) _dr["Firstname"],
                                Lastname = (string) _dr["Lastname"],
                                Post = (string) _dr["Post"],
                                Img = (byte[])_dr["picImage"]
                            });
                        }
                    }
                }
            }
            return candidateList;
        }

        public static IEnumerable<GetVoteCount> GetVoteCount()
        {
            var getVoteCount = new List<GetVoteCount>();
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd =new SqlCommand("select * from VoteProcess", _cnn))
                {
                    using (_dr = _cmd.ExecuteReader())
                    {
                        while (_dr.Read())
                        {
                            getVoteCount.Add(new GetVoteCount()
                            {
                                VoterPin = (string) _dr["VoterPin"],
                                CandidatePin = (string) _dr["CandidatePin"],
                                Post = (string) _dr["Post"],
                                Count = (int) _dr["Count"]
                            });
                        }
                    }
                }
            }
            return getVoteCount;
        }

        public static IEnumerable<Election> GetAllPostion()
        {
            var positions = new List<Election>();
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand("Select ElectionPost From AddNewElection", _cnn))
                {
                    using (_dr = _cmd.ExecuteReader())
                    {
                        while (_dr.Read())
                        {
                            positions.Add(new Election()
                            {
                                Post = _dr["ElectionPost"].ToString()
                            });
                        }
                    }
                }
            }
            return positions;
        }

        public static int VoterCount()
        {
            int count;
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                 _cnn.Open();
                using(_cmd = new SqlCommand("select Count(VoterPin) from VoterRegistration", _cnn))
                {
                    using (_dr = _cmd.ExecuteReader())
                    {
                        _dr.Read();
                        count = (int) _dr.GetValue(0);
                    }
                }
            }
            return count;
        }

        
    }
}
