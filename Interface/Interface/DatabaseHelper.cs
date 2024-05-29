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

        public static List<Spell> GetSpellsFromDatabase(int limit = 20)
        {
            var spells = new List<Spell>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT TOP {limit} name, rarity, actions, rank, range FROM Spells ORDER BY name";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var spell = new Spell
                        {
                            Name = reader["name"].ToString(),
                            Rarity = reader["rarity"].ToString(),
                            Actions = reader["actions"].ToString(),
                            Rank = Convert.ToInt32(reader["rank"]),
                            Range = reader["range"].ToString(),
                        };
                        spells.Add(spell);
                    }
                }
            }

            return spells;
        }
        public static List<Spell> GetAllSpellsFromDatabase()
        {
            return GetSpellsFromDatabase(int.MaxValue);
        }

    }
}
