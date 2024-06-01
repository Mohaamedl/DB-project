using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;

namespace Interface
{
    public static class DatabaseHelper
    {
        private static string connectionString = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;

        public static List<Feat> GetFeatsFromDatabase(int limit = 20, string columnName = null, string searchString = null)
        {
            var feats = new List<Feat>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT TOP {limit} Name, Rarity, Prerequisite, Summary, Level FROM Feats ORDER BY Name";
                if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchString))
                {
                    query += $" WHERE {columnName} LIKE '%{searchString}%'";
                }
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

        public static List<Spell> GetSpellsFromDatabase(int limit = 20, string columnName = null, string searchString = null)
        {
            var spells = new List<Spell>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT TOP {limit} name, rarity, actions, rank, range FROM Spells ORDER BY name";
                if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchString))
                {
                    query += $" WHERE {columnName} LIKE '%{searchString}%'";
                }
                SqlCommand command = new(query, connection);
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
        public static List<Trait> GetTraitsFromDatabase(int limit = 20, string columnName = null, string searchString = null)
        {
            var traits = new List<Trait>();

            using (SqlConnection connection = new(connectionString))
            {
                string query = $"SELECT TOP {limit} designation, details FROM Traits";
                if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchString))
                {
                    query += $" WHERE {columnName} LIKE '%{searchString}%'";
                }
                SqlCommand command = new(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var trait = new Trait
                        {
                            designation = reader["designation"].ToString(),
                            details = reader["details"].ToString()
                            
                        };
                        traits.Add(trait);
                    }
                }
            }

            return traits;
        }
        public static List<Ancestry> GetAncestriesFromDatabase(int limit = 20, string columnName = null, string searchString = null)
        {
            var Ancestries = new List<Ancestry>();

            using (SqlConnection connection = new(connectionString))
            {
                string query = $"SELECT TOP {limit} name, HP, size, speed,ability_boost,ability_flaw,rarity FROM Ancestry ORDER BY name";
                if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchString))
                {
                    query += $" WHERE {columnName} LIKE '%{searchString}%'";
                }
                SqlCommand command = new(query, connection);
                connection.Open();

                using ( SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ancestry = new Ancestry
                        {
                            name = reader["name"].ToString(),
                            HP = Convert.ToInt32(reader["HP"]),
                            size = reader["size"].ToString(),
                            speed = Convert.ToInt32(reader["speed"]),
                            ability_boost = reader["ability_boost"].ToString(),
                            ability_flaw = reader["ability_flaw"].ToString(),
                            rarity = reader["rarity"].ToString(),
                           



                        };
                        Ancestries.Add(ancestry);
                    }
                }
            }

            return Ancestries;
        }
        public static List<Trait> GetAllTraitsFromDatabase()
        {
            return GetTraitsFromDatabase(int.MaxValue);
        }

        internal static List<Ancestry> GetAllAncestriesFromDatabase()
        {
            return GetAncestriesFromDatabase(int.MaxValue);
        }
        public static List<string> GetLanguagesByAncestry(string ancestryName)
        {
            var languages = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand("GetLanguagesByAncestry", connection))
                {
                    command.CommandType = System.Data.CommandType.StoredProcedure;
                    command.Parameters.AddWithValue("@AncestryName", ancestryName);

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            languages.Add(reader["Designation"].ToString());
                        }
                    }
                }
            }

            return languages;
        }


        
        public static List<Background> GetBackgroundsFromDatabase(int limit = 20, string columnName = null, string searchString = null)
        {
            var Backgrounds = new List<Background>();

            using (SqlConnection connection = new(connectionString))
            {
                string query = $"SELECT TOP {limit} name, ability, skill, feat,rarity,summary FROM Background ORDER BY name";
                if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchString))
                {
                    query += $" WHERE {columnName} LIKE '%{searchString}%'";
                }
                SqlCommand command = new(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var background = new Background
                        {
                            name = reader["name"].ToString(),
                            ability = reader["ability"].ToString(),
                            skill = reader["skill"].ToString(),
                            feat = reader["feat"].ToString(),
                            rarity = reader["rarity"].ToString(),
                            summary = reader["summary"].ToString()




                        };
                        Backgrounds.Add(background);
                    }
                }
            }

            return Backgrounds;
        }
        public static List<Background> GetAllBackgroundsFromDatabase()
        {
            return GetBackgroundsFromDatabase(int.MaxValue);
        }
        public static List<Equipment> GetEquipmentsFromDatabase(int limit = 20, string columnName = null, string searchString = null)
        {
            var Equipments = new List<Equipment>();

            using (SqlConnection connection = new(connectionString))
            {
                string query = $"SELECT TOP {limit} [name], item_category, item_sub_category, weapon_category,[level],price,rarity,usage,[bulk] FROM Equipment ORDER BY [name]";
                if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchString))
                {
                    query += $" WHERE {columnName} LIKE '%{searchString}%'";
                }
                SqlCommand command = new(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var equipment = new Equipment
                        {
                            name = reader["name"].ToString(),
                            item_category = reader["item_category"].ToString(),
                            item_sub_category = reader["item_sub_category"].ToString(),
                            weapon_category = reader["weapon_category"].ToString(),
                            level = Convert.ToInt32(reader["level"]),
                            price = Convert.ToInt32(reader["price"]),
                            rarity = reader["rarity"].ToString(),
                            usage = reader["usage"].ToString(),
                            bulk = reader["bulk"].ToString()




                        };
                        Equipments.Add(equipment);
                    }
                }
            }

            return Equipments;
        }
        public static List<Equipment> GetAllEquipmentsFromDatabase()
        {
            return GetEquipmentsFromDatabase(int.MaxValue);
        }
        public static List<Class> GetClassesFromDatabase(int limit = 20, string columnName = null, string searchString = null)
        {
            var Classes = new List<Class>();

            using (SqlConnection connection = new(connectionString))
            {
                string query = $"SELECT TOP {limit} [name],HP , prof_attack, prof_defense, ability, spell_progression_id FROM Class ORDER BY [name]";
                if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchString))
                {
                    query += $" WHERE {columnName} LIKE '%{searchString}%'";
                }
                SqlCommand command = new(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var cla = new Class
                        {
                            name = reader["name"].ToString(),
                            HP = Convert.ToInt32(reader["HP"]),
                            prof_attack = reader["prof_attack"].ToString(),
                            prof_defense = reader["prof_defense"].ToString(),
                            ability = reader["ability"].ToString(),
                            
                          



                        };
                        Classes.Add(cla);
                    }
                }
                connection.Close();
            }

            return Classes;
        }
        public static List<Class> GetAllClassesFromDatabase()
        {
            return GetClassesFromDatabase(int.MaxValue);
        }
        public static bool RegisterUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string query = "INSERT INTO Users (Username, Password) VALUES (@Username, @Password)";
                    SqlCommand command = new SqlCommand(query, connection, transaction);

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    command.ExecuteNonQuery();
                    transaction.Commit();

                    return true; 
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false; 
                }
                finally
                {
                    connection.Close();
                }
            }
        }
        public static bool LoginUser(string username, string password)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();

                try
                {
                    string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username AND [Password] = @Password";
                    SqlCommand command = new SqlCommand(query, connection, transaction);

                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@Password", password);

                    int userCount = (int)command.ExecuteScalar();
                    transaction.Commit();

                    return userCount > 0; 
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    Console.WriteLine("An error occurred: " + ex.Message);
                    return false; 
                }
                finally
                {
                    connection.Close();
                }
            }
        }


        public static List<Skill> GetSkillsFromDatabase()
        {
            var Skills = new List<Skill>();

            using (SqlConnection connection = new(connectionString))
            {
                string query = $"SELECT   designation , details FROM Skills ORDER BY designation";

                SqlCommand command = new(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var ski = new Skill
                        {
                            designation = reader["designation"].ToString(),
                            value = 0,
                            details = reader["details"].ToString(),




                        };
                        Skills.Add(ski);
                    }
                }
                connection.Close();
            }

            return Skills;
        }
        public static User Login(string username, string password)
        {
            User user = null;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("SELECT ID, Username, PasswordHash, PasswordSalt, Role FROM Users WHERE Username = @Username", connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    using (var reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            byte[] storedHash = (byte[])reader["PasswordHash"];
                            byte[] storedSalt = (byte[])reader["PasswordSalt"];

                            if (PasswordHelper.VerifyPasswordHash(password, storedHash, storedSalt))
                            {
                                user = new User
                                {
                                    ID = (int)reader["ID"],
                                    Username = (string)reader["Username"],
                                    PasswordHash = storedHash,
                                    PasswordSalt = storedSalt,
                                    Role = (string)reader["Role"]
                                };
                            }
                        }
                    }
                }
            }

            return user;
        }
        public static bool Register(string username, string password, string role)
        {
            byte[] passwordHash, passwordSalt;
            PasswordHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand("INSERT INTO Users (Username, PasswordHash, PasswordSalt, Role, CreatedAt) VALUES (@Username, @PasswordHash, @PasswordSalt, @Role, @CreatedAt)", connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    command.Parameters.AddWithValue("@PasswordHash", passwordHash);
                    command.Parameters.AddWithValue("@PasswordSalt", passwordSalt);
                    command.Parameters.AddWithValue("@Role", role);
                    command.Parameters.AddWithValue("@CreatedAt", DateTime.Now);

                    int result = command.ExecuteNonQuery();
                    return result > 0;
                }
            }
        }
        public static bool UserExists(string username)
        {
            bool exists = false;

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = "SELECT COUNT(*) FROM Users WHERE Username = @Username";
                using (var command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@Username", username);
                    int count = (int)command.ExecuteScalar();
                    exists = count > 0;
                }
            }

            return exists;
        }
        //public static bool searchstringincolumn(string tablename, string columnname, string searchstring)
        //{
        //    bool found = false;

        //    using (var connection = new sqlconnection(connectionstring))
        //    {
        //        connection.open();

        //        string query = $"select count(*) from {tablename} where {columnname} like @searchstring";
        //        using (var command = new sqlcommand(query, connection))
        //        {
        //            command.parameters.addwithvalue("@searchstring", $"%{searchstring}%");
        //            int count = (int)command.executescalar();
        //            found = count > 0;
        //        }
        //    }

        //    return found;
        //}

    }
}
