using System.Collections.Generic;
using System.Data.SqlClient;
using VotingSystem.Properties;

namespace VotingSystem.Models
{
    public static class Privilege
    {
        private static SqlConnection _cnn;
        private static SqlCommand _cmd;
        private static SqlDataReader _dr;

        public static IEnumerable<string> GetAllUsers()
        {
            var users = new List<string>();
            const string select = "Select Username From [User]";
            using (_cnn = new SqlConnection(Settings.Default.DbConn))
            {
                _cnn.Open();
                using (_cmd = new SqlCommand(select, _cnn))
                {
                    using (_dr = _cmd.ExecuteReader())
                    {
                        while (_dr.Read())
                        {
                            users.Add((string)_dr["Username"]);
                        }
                    }
                }
            }
            return users;
        } 
    }
}
