
using System;
using System.Data;
using System.Data.SqlClient;
using VotingSystem.Properties;

namespace VotingSystem.Models
{
    static class Functions
    {
        static string ConnectionString => "Data Source =" + Settings.Default.Server + "; Initial Catalog=" + Settings.Default.Database +
                                                 "; User Id = " + Settings.Default.Username + "; Password = " + Settings.Default.Password + ";";

        public static bool TestConnection()
        {
            bool _return = true;
            using (var con = new SqlConnection(ConnectionString))
            {
                try
                {
                    con.Open();
                }
                catch (Exception)
                {
                    _return = false;
                }
            }
            return _return;
        }

        public static DataTable DataTable(string sql)
        {
            var _table = new DataTable();
            using (var con = new SqlConnection(ConnectionString))
            {
                using(var adp = new SqlDataAdapter(sql, con))
                {
                    adp.Fill(_table);
                }
            }
            return _table;
        }

    }
    
    
}
