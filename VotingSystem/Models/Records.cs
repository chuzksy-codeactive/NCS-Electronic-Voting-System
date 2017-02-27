using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using VotingSystem.Properties;

namespace VotingSystem.Models
{
    public class Records
    {
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;

        public string  CandidatePin { get; set; }
        public string Position { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string CandidateEmail { get; set; }
        public string VoterPin { get; set; }
        public string Gender { get; set; }
        public string Phonenumber { get; set; }
        public string VoterEmail { get; set; }
        public byte[] CandidateImage { get; set; }

        private readonly List<Records> _records = new List<Records>();

        public IEnumerable<Records> GetAllRecords()
        {
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand("spGetRecords", _cnn))
                {
                    _cmd.CommandType = CommandType.StoredProcedure;
                    using (_dr = _cmd.ExecuteReader())
                    {
                        while (_dr.Read())
                        {
                            _records.Add(new Records
                            {
                                CandidatePin = (string)_dr["Candidate Pin"],
                                Position = (string)_dr["Position"],
                                Firstname = (string)_dr["Candidate Firstname"],
                                Lastname = (string)_dr["Candidate Lastname"],
                                CandidateEmail = (string)_dr["Candidate Email"],
                                VoterPin = (string)_dr["Voter Pin"],
                                Gender = (string)_dr["Gender"],
                                Phonenumber = (string)_dr["Voters Phonenumber"],
                                VoterEmail = (string)_dr["Voters Email"],
                                CandidateImage = (byte[])_dr["Candidate Image"]
                            });
                        }
                    }   
                }
            }
            return _records;
        }

    }
}
