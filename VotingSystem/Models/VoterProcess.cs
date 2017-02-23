using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingSystem.Properties;

namespace VotingSystem.Models
{
    public static class VoterProcess
    {
        private static SqlConnection _cnn;
        private static SqlCommand _cmd;
        private static SqlDataReader _dr;
        const string Select = "Select * From VoteProcess Where VoterPin = @voterPin and Post = @post";
        const string Insert =
            "Insert Into VoteProcess (VoterPin,CandidatePin,Post,Count) Values (@voterPin, @cand, @post, @count)";

        public static bool CheckIfVoted(string voterPin, string post)
        {
            var check = false;
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand(Select, _cnn))
                {
                    _cmd.Parameters.AddWithValue("@voterPin", voterPin);
                    _cmd.Parameters.AddWithValue("@post", post);
                    using (_dr = _cmd.ExecuteReader())
                    {
                        if (!_dr.Read())
                            check = true;
                    }
                }
            }
            return check;
        }

        public static int SaveVote(string voterPin, string candiatePin, string post, int count)
        {
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                using (_cmd = new SqlCommand(Insert, _cnn))
                {
                    _cmd.Parameters.AddWithValue("@voterPin", voterPin);
                    _cmd.Parameters.AddWithValue("@cand", candiatePin);
                    _cmd.Parameters.AddWithValue("@post", post);
                    _cmd.Parameters.AddWithValue("@count", count);

                    _cnn.Open();
                    return _cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
