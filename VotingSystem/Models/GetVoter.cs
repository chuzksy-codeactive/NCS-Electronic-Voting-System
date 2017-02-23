using System.Collections.Generic;
using System.Data.SqlClient;
using VotingSystem.Properties;

namespace VotingSystem.Models
{
    public class GetVoter
    {
        private SqlConnection _cnn;
        private SqlCommand _cmd;
        private SqlDataReader _dr;
        public IEnumerable<Voters> GetVotersEnumerable()
        {
            var getVotersList = new List<Voters>();
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand("Select *From VoterRegistration", _cnn))
                {
                    using (_dr = _cmd.ExecuteReader())
                    {
                        while (_dr.Read())
                        {
                            getVotersList.Add(new Voters()
                            {
                                VoterPin = (string)_dr["VoterPin"],
                                Firstname = (string)_dr["Firstname"],
                                Lastname = (string)_dr["Lastname"],
                                ImgBytes = (byte[])_dr["picImage"],
                                Email = (string)_dr["Email"]
                            });
                        }
                    }
                }
            }
            return getVotersList;
        } 
    }
}
