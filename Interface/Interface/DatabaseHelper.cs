using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace Interface
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static List<Feat> GetFeatsFromDatabase(int limit = 20)
        {
            var feats = new List<Feat>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT TOP {limit} Name, Rarity, Prerequisite, Summary, Level FROM Feats ORDER BY Name";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var feat = new Feat
                        {
                            name = reader["Name"].ToString(),
                            rarity = reader["Rarity"].ToString(),
                            prerequisite = reader["Prerequisite"].ToString(),
                            summary = reader["Summary"].ToString(),
                            level = Convert.ToInt32(reader["Level"])
                        };
                        feats.Add(feat);
                    }
                }
            }

            return feats;
        }

        public static List<Feat> GetAllFeatsFromDatabase()
        {
            return GetFeatsFromDatabase(int.MaxValue);
        }
    }
}
