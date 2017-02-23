using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using VotingSystem.Properties;

namespace VotingSystem.Models
{
    public class AddNewElection
    {
        private static SqlConnection cnn;
        private static SqlCommand cmd;
        private static SqlDataReader dr;

        public static int NewElection(Election election)
        {
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("spNewElection", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@electionId", election.ElectionId);
                    cmd.Parameters.AddWithValue("@post", election.Post);
                    cmd.Parameters.AddWithValue("@no", election.NoOfCandidates);
                    cmd.Parameters.AddWithValue("@start", election.StartDate);
                    cmd.Parameters.AddWithValue("@end", election.EndDate);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static Election SelectedItem(string selectedItem)
        {
            var election = new Election();
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("Select *from AddNewElection Where ElectionId = @select", cnn))
                {
                    cmd.Parameters.AddWithValue("@select", selectedItem);
                    using (dr = cmd.ExecuteReader())
                    {
                        dr.Read();
                        election.ElectionId = selectedItem;
                        election.Post = dr["ElectionPost"].ToString();
                        election.NoOfCandidates = (int) dr["NoOfCandidates"];
                        election.StartDate = (DateTime) dr["StartDate"];
                        election.EndDate = (DateTime) dr["EndDate"];
                    }
                }
            }
            return election;
        }

        public static int Read(string read)
        {
            var row = -1;
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("Select ElectionId from AddNewElection Where ElectionId = @electionId", cnn))
                {
                    cmd.Parameters.AddWithValue("@electionId", read);
                    using (dr = cmd.ExecuteReader())
                    {
                        if (!dr.Read())
                        {
                            row = 1;
                        }
                    }
                }
            }
            return row;
        }

        public static int UpdateElection(Election election)
        {
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("spUpdateElection", cnn))
                {
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.AddWithValue("@post", election.Post);
                    cmd.Parameters.AddWithValue("@no", election.NoOfCandidates);
                    cmd.Parameters.AddWithValue("@start", election.StartDate);
                    cmd.Parameters.AddWithValue("@end", election.EndDate);
                    cmd.Parameters.AddWithValue("@electionId", election.ElectionId);

                    return cmd.ExecuteNonQuery();
                }
            }
        }

        public static int DeleteElection(string delete)
        {
            using (cnn = new SqlConnection(Settings.Default.DbConn))
            {
                cnn.Open();
                using (cmd = new SqlCommand("Delete AddNewElection Where ElectionId = @electionId", cnn))
                {
                    cmd.Parameters.AddWithValue("@electionId", delete);
                    return cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
