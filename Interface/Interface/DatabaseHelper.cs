using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Configuration;
using static System.Windows.Forms.Design.AxImporter;

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
                string query = $"SELECT TOP {limit} ID,Name, Rarity, Prerequisite, Summary, Level FROM Feats ORDER BY Name";
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
                            level = Convert.ToInt32(reader["Level"]),
                            ID = Convert.ToInt32(reader["ID"])
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

        public static List<Spell> GetSpellsFromDatabase(int limit = 20, string columnName = null, string searchString = null, string rankFilter = null, string rarityFilter = null, string sortBy = "name", bool sortOrderAscending = true)
        {
            var spells = new List<Spell>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = $"SELECT TOP {limit} ID, name, rarity, actions, rank, range FROM Spells";

                var conditions = new List<string>();
                if (!string.IsNullOrEmpty(columnName) && !string.IsNullOrEmpty(searchString))
                {
                    conditions.Add($"{columnName} LIKE '%{searchString}%'");
                }
                if (!string.IsNullOrEmpty(rankFilter))
                {
                    conditions.Add($"rank = '{rankFilter}'");
                }
                if (!string.IsNullOrEmpty(rarityFilter))
                {
                    conditions.Add($"rarity = '{rarityFilter}'");
                }

                if (conditions.Count > 0)
                {
                    query += " WHERE " + string.Join(" AND ", conditions);
                }

                string sortOrder = sortOrderAscending ? "ASC" : "DESC";
                query += $" ORDER BY {sortBy} {sortOrder}";

                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        var spell = new Spell
                        {
                            ID = Convert.ToInt32(reader["ID"]),
                            Name = reader["name"].ToString(),
                            Rarity = reader["rarity"].ToString(),
                            Actions = reader["actions"].ToString(),
                            Rank = Convert.ToInt32(reader["rank"]),
                            Range = reader["range"].ToString()
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
                string query = $"SELECT TOP {limit} ID,designation, details FROM Traits";
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
                            details = reader["details"].ToString(),
                            ID = Convert.ToInt32(reader["ID"])

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
                string query = $"SELECT TOP {limit} ID,name, HP, size, speed,ability_boost,ability_flaw,rarity FROM Ancestry ORDER BY name";
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
                            ID = Convert.ToInt32(reader["ID"]),




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
                string query = $"SELECT TOP {limit} ID,name, ability, skill, feat,rarity,summary FROM Background ORDER BY name";
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
                            summary = reader["summary"].ToString(),
                            ID = Convert.ToInt32(reader["ID"])




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
                string query = $"SELECT TOP {limit} ID,[name], item_category, item_sub_category, weapon_category,[level],price,rarity,usage,[bulk] FROM Equipment ORDER BY [name]";
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
                            bulk = reader["bulk"].ToString(),
                            ID = Convert.ToInt32(reader["ID"])
                            



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
                string query = $"SELECT TOP {limit} ID,[name],HP , prof_attack, prof_defense, ability, spell_progression_id FROM Class ORDER BY [name]";
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
                            ID = Convert.ToInt32(reader["ID"]),
                          



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
        public static bool DeleteRecordsByIds(string tableName, string idColumnName, List<int> ids)
        {
            try
            {
                using (var connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Construir a consulta de exclusão
                    var idList = string.Join(",", ids);
                    var query = $"DELETE FROM {tableName} WHERE {idColumnName} IN ({idList})";

                    using (var command = new SqlCommand(query, connection))
                    {
                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Tratar exceções conforme necessário
                MessageBox.Show("Error deleting records: " + ex.Message);
                return false;
            }
        }


        public static bool UpdateAncestry(Ancestry ancestry)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Ancestry SET 
                            name = @Name, 
                            HP = @HP, 
                            size = @Size, 
                            speed = @Speed, 
                            ability_boost = @AbilityBoost, 
                            ability_flaw = @AbilityFlaw, 
                            rarity = @Rarity 
                        WHERE ID = @ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", ancestry.name);
                command.Parameters.AddWithValue("@HP", ancestry.HP);
                command.Parameters.AddWithValue("@Size", ancestry.size);
                command.Parameters.AddWithValue("@Speed", ancestry.speed);
                command.Parameters.AddWithValue("@AbilityBoost", ancestry.ability_boost);
                command.Parameters.AddWithValue("@AbilityFlaw", ancestry.ability_flaw);
                command.Parameters.AddWithValue("@Rarity", ancestry.rarity);
                command.Parameters.AddWithValue("@ID", ancestry.ID);

                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();

                return result > 0;
            }
            

        }
        public static bool UpdateSpell(Spell spell)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Spells SET 
                            Name = @Name, 
                            Rank = @Rank, 
                            Actions = @Actions, 
                            Rarity = @Rarity, 
                            Range = @Range 
                        WHERE ID = @ID";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", spell.Name);
                command.Parameters.AddWithValue("@Rank", spell.Rank);
                command.Parameters.AddWithValue("@Actions", spell.Actions);
                command.Parameters.AddWithValue("@Rarity", spell.Rarity);
                command.Parameters.AddWithValue("@Range", spell.Range);
                command.Parameters.AddWithValue("@ID", spell.ID);

                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();

                return result > 0;
            }
        }
        public static bool CreateSpell(Spell spell)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = @"insert into Spells values('',
                            @Name, @Actions, '','', @Rarity, '','',@Rank,'','',@Range)
                        ";

                
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", spell.Name);
                command.Parameters.AddWithValue("@Rank", spell.Rank);
                command.Parameters.AddWithValue("@Actions", spell.Actions);
                command.Parameters.AddWithValue("@Rarity", spell.Rarity);
                command.Parameters.AddWithValue("@Range", spell.Range);
                

                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();

                return result > 0;
            }
        }
        public static bool CreateFeat(Feat feat)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = @"insert into Feats values(@Name,@Pre,@Summary,@Rarity,@Level)";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", feat.name);
                command.Parameters.AddWithValue("@Summary", feat.summary);
                command.Parameters.AddWithValue("@pre", feat.prerequisite);
                command.Parameters.AddWithValue("@Rarity", feat.rarity);
                command.Parameters.AddWithValue("@Level", feat.level);


                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();

                return result > 0;
            }
        }

        public static bool CreateEquipment(Equipment equipment)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {

                string query = @"insert into Equipment values(@Name, @ic, @isc, @usage, @bulk, @rarity,@wc, @level, @price)";


                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Name", equipment.name);
                command.Parameters.AddWithValue("@ic", equipment.item_category);
                command.Parameters.AddWithValue("@isc", equipment.item_sub_category);
                command.Parameters.AddWithValue("@usage", equipment.usage);
                command.Parameters.AddWithValue("@bulk", equipment.bulk);
                command.Parameters.AddWithValue("@rarity", equipment.rarity);
                command.Parameters.AddWithValue("@wc", equipment.weapon_category);
                command.Parameters.AddWithValue("@Level", equipment.level);
                command.Parameters.AddWithValue("@price", equipment.price);

                connection.Open();
                int result = command.ExecuteNonQuery();
                connection.Close();

                return result > 0;
            }
        }
        public static int CreateAbilityScores(int strength, int wisdom, int intelligence, int charisma, int dexterity, int constitution)
        {
            int abilityScoresId = 0;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                
                string query = @"INSERT INTO Ability_scores 
                             VALUES (@strength, @dexterity, @constitution, @intelligence,@wisdom,  @charisma);
                             SELECT SCOPE_IDENTITY();"; 

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@strength", strength);
                command.Parameters.AddWithValue("@wisdom", wisdom);
                command.Parameters.AddWithValue("@intelligence", intelligence);
                command.Parameters.AddWithValue("@charisma", charisma);
                command.Parameters.AddWithValue("@dexterity", dexterity);
                command.Parameters.AddWithValue("@constitution", constitution);

                connection.Open();

                abilityScoresId = Convert.ToInt32(command.ExecuteScalar());
            }

            return abilityScoresId;
        }
        public static void UpdateAbilityScores(int abilityScoresId, int strength, int wisdom, int intelligence, int charisma, int dexterity, int constitution)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE Ability_scores 
                         SET 
                            STRENGTH = @strength,
                            WISDOM = @wisdom,
                            INTELLIGENCE = @intelligence,
                            CHARISMA = @charisma,
                            DEXTERITY = @dexterity,
                            CONSTITUTION = @constitution
                         WHERE ID = @abilityScoresId;";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@strength", strength);
                command.Parameters.AddWithValue("@wisdom", wisdom);
                command.Parameters.AddWithValue("@intelligence", intelligence);
                command.Parameters.AddWithValue("@charisma", charisma);
                command.Parameters.AddWithValue("@dexterity", dexterity);
                command.Parameters.AddWithValue("@constitution", constitution);
                command.Parameters.AddWithValue("@abilityScoresId", abilityScoresId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }

        public static Character CreateCharacter(Character character)
        {
            int characterId = 0;

            // Criar a AbilityScores associada ao personagem
            int abilityScoresId = CreateAbilityScores(character.Str, character.Wis, character.Int, character.Cha, character.Dex, character.Con);
            character.id_abilityScores = abilityScoresId;
            // Conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                // Comando SQL para inserir um novo personagem na tabela Character e obter o ID gerado
                string query = @"INSERT INTO [Character] 
                         VALUES (@Name, @HP, @Level,@Speed, @ClassId, @AncestryId, @BackgroundId, @AbilityScoresId,@Str_mod, @Dex_mod, @Con_mod,@Int_mod,@Wis_mod,@Cha_mod);
                         SELECT SCOPE_IDENTITY();"; // Retorna o ID da última linha inserida                       
                                                                                                                  
                SqlCommand command = new SqlCommand(query, connection);                                            
                                                                                                                   
                // Parâmetros do comando SQL                                                                       
                command.Parameters.AddWithValue("@Name", character.name);
                command.Parameters.AddWithValue("@HP", character.HP);
                command.Parameters.AddWithValue("@Level", character.Level);
                command.Parameters.AddWithValue("@ClassId", character.Class.ID);
                command.Parameters.AddWithValue("@AncestryId", character.ancestry.ID);
                command.Parameters.AddWithValue("@BackgroundId", character.background.ID);
                command.Parameters.AddWithValue("@AbilityScoresId", abilityScoresId); // Usando o ID da AbilityScores criada
                command.Parameters.AddWithValue("@Speed", character.speed);
                command.Parameters.AddWithValue("@Str_mod", character.Str_mod);
                command.Parameters.AddWithValue("@Dex_mod", character.Dex_mod);
                command.Parameters.AddWithValue("@Con_mod", character.Con_mod);
                command.Parameters.AddWithValue("@Int_mod", character.Int_mod);
                command.Parameters.AddWithValue("@Wis_mod", character.Wis_mod);
                command.Parameters.AddWithValue("@Cha_mod", character.Cha_mod);

                connection.Open();

                // Executar o comando SQL e obter o ID gerado
                characterId = Convert.ToInt32(command.ExecuteScalar());
                character.ID = characterId;
            }

            return character;
        }
        public static Character UpdateCharacter(Character character)
        {
            

            UpdateAbilityScores(character.id_abilityScores, character.Str, character.Wis, character.Int, character.Cha, character.Dex, character.Con);

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"UPDATE [Character] 
                        SET 
                            name = @Name,
                            HP = @HP,
                            [Level] = @Level,
                            speed = @Speed,
                            class_id = @ClassId,
                            ancestry_id = @AncestryId,
                            background_id = @BackgroundId,
                            ability_scores_id = @AbilityScoresId,
                            Str_mod = @Str_mod,
                            Dex_mod = @Dex_mod,
                            Con_mod = @Con_mod,
                            Int_mod = @Int_mod,
                            Wis_mod = @Wis_mod,
                            Cha_mod = @Cha_mod
                        WHERE ID = @CharacterId;";                      

                SqlCommand command = new SqlCommand(query, connection);

                // Parâmetros do comando SQL                                                                       
                command.Parameters.AddWithValue("@Name", character.name);
                command.Parameters.AddWithValue("@HP", character.HP);
                command.Parameters.AddWithValue("@Level", character.Level);
                command.Parameters.AddWithValue("@ClassId", character.Class.ID);
                command.Parameters.AddWithValue("@AncestryId", character.ancestry.ID);
                command.Parameters.AddWithValue("@BackgroundId", character.background.ID);
                command.Parameters.AddWithValue("@AbilityScoresId", character.id_abilityScores); 
                command.Parameters.AddWithValue("@Speed", character.speed);
                command.Parameters.AddWithValue("@Str_mod", character.Str_mod);
                command.Parameters.AddWithValue("@Dex_mod", character.Dex_mod);
                command.Parameters.AddWithValue("@Con_mod", character.Con_mod);
                command.Parameters.AddWithValue("@Int_mod", character.Int_mod);
                command.Parameters.AddWithValue("@Wis_mod", character.Wis_mod);
                command.Parameters.AddWithValue("@Cha_mod", character.Cha_mod);
                command.Parameters.AddWithValue("@CharacterId", character.ID);

                connection.Open();

                // Executar o comando SQL e obter o ID gerado
                command.ExecuteScalar();
                
            }

            return character;
        }
        public static void AddCharacterEquipment(int characterId, List<Equipment> equipments)
        {
            // Conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Loop pelos equipamentos selecionados
                foreach (var equipment in equipments)
                {
                    // Comando SQL para inserir um registro na tabela de junção Character_tem_equipment
                    string query = @"INSERT INTO Character_tem_equipment (id_character, id_equipment) 
                             VALUES (@CharacterId, @EquipmentId)";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Parâmetros do comando SQL
                    command.Parameters.AddWithValue("@CharacterId", characterId);
                    command.Parameters.AddWithValue("@EquipmentId", equipment.ID);

                    // Executar o comando SQL
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddCharacterFeats(int characterId, List<Feat> feats)
        {
            // Conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Loop pelos feats selecionados
                foreach (var feat in feats)
                {
                    // Comando SQL para inserir um registro na tabela de junção Character_tem_feats
                    string query = @"INSERT INTO Character_tem_feats (id_character, id_feats) 
                             VALUES (@CharacterId, @FeatId)";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Parâmetros do comando SQL
                    command.Parameters.AddWithValue("@CharacterId", characterId);
                    command.Parameters.AddWithValue("@FeatId", feat.ID);

                    // Executar o comando SQL
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddCharacterSpells(int characterId, List<Spell> spells)
        {
            // Conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Loop pelos spells selecionados
                foreach (var spell in spells)
                {
                    // Comando SQL para inserir um registro na tabela de junção Character_tem_spells
                    string query = @"INSERT INTO Character_tem_spells (id_character, id_spells) 
                             VALUES (@CharacterId, @SpellId)";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Parâmetros do comando SQL
                    command.Parameters.AddWithValue("@CharacterId", characterId);
                    command.Parameters.AddWithValue("@SpellId", spell.ID);

                    // Executar o comando SQL
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void AddCharacterLanguages(int characterId, List<string> languages)
        {
            // Conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Loop pelas línguas selecionadas
                foreach (var language in languages)
                {
                    // Consulta SQL para obter o ID da língua pelo nome
                    string languageQuery = "SELECT ID FROM Language WHERE Designation = @LanguageName";

                    SqlCommand languageCommand = new SqlCommand(languageQuery, connection);
                    languageCommand.Parameters.AddWithValue("@LanguageName", language);

                    int languageId = Convert.ToInt32(languageCommand.ExecuteScalar());

                    // Comando SQL para inserir um registro na tabela de junção Character_tem_language
                    string query = @"INSERT INTO Character_tem_language (id_character, id_language) 
                             VALUES (@CharacterId, @LanguageId)";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Parâmetros do comando SQL
                    command.Parameters.AddWithValue("@CharacterId", characterId);
                    command.Parameters.AddWithValue("@LanguageId", languageId);

                    // Executar o comando SQL
                    command.ExecuteNonQuery();
                }
            }
        }
        public static void UpdateCharacterEquipment(int characterId, List<Equipment> equipments)
        {
            // Conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                try
                {
                    // Limpar os equipamentos anteriores do personagem
                    string deleteQuery = @"delete from Character_tem_equipment where id_character = @CharacterId";
                    SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                    deleteCommand.Parameters.AddWithValue("@CharacterId", characterId);
                    int rowsAffected = deleteCommand.ExecuteNonQuery();

                    // Log para verificar se os equipamentos foram realmente deletados
                    Console.WriteLine($"Equipamentos deletados: {rowsAffected} para CharacterId: {characterId}");

                    // Loop pelos novos equipamentos selecionados
                    AddCharacterEquipment(characterId, equipments);

                    Console.WriteLine("Equipamentos atualizados com sucesso.");
                }
                catch (Exception ex)
                {
                    // Log de erro para facilitar a depuração
                    Console.WriteLine($"Erro ao atualizar os equipamentos: {ex.Message}");
                    throw;
                }
            }
        }

        public static void UpdateCharacterFeats(int characterId, List<Feat> feats)
        {
            // Conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Limpar os feats anteriores do personagem
                string deleteQuery = @"DELETE FROM Character_tem_feats WHERE id_character = @CharacterId";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@CharacterId", characterId);
                deleteCommand.ExecuteNonQuery();

                // Loop pelos novos feats selecionados
                foreach (var feat in feats)
                {
                    // Comando SQL para atualizar a tabela de junção Character_tem_feats
                    string query = @"INSERT INTO Character_tem_feats (id_character, id_feats) 
                             VALUES (@CharacterId, @FeatId)";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Parâmetros do comando SQL
                    command.Parameters.AddWithValue("@CharacterId", characterId);
                    command.Parameters.AddWithValue("@FeatId", feat.ID);

                    // Executar o comando SQL
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateCharacterSpells(int characterId, List<Spell> spells)
        {
            // Conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Limpar os spells anteriores do personagem
                string deleteQuery = @"DELETE FROM Character_tem_spells WHERE id_character = @CharacterId";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@CharacterId", characterId);
                deleteCommand.ExecuteNonQuery();

                // Loop pelos novos spells selecionados
                foreach (var spell in spells)
                {
                    // Comando SQL para atualizar a tabela de junção Character_tem_spells
                    string query = @"INSERT INTO Character_tem_spells (id_character, id_spells) 
                             VALUES (@CharacterId, @SpellId)";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Parâmetros do comando SQL
                    command.Parameters.AddWithValue("@CharacterId", characterId);
                    command.Parameters.AddWithValue("@SpellId", spell.ID);

                    // Executar o comando SQL
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void UpdateCharacterLanguages(int characterId, List<string> languages)
        {
            // Conexão com o banco de dados
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                // Limpar as línguas anteriores do personagem
                string deleteQuery = @"DELETE FROM Character_tem_language WHERE id_character = @CharacterId";
                SqlCommand deleteCommand = new SqlCommand(deleteQuery, connection);
                deleteCommand.Parameters.AddWithValue("@CharacterId", characterId);
                deleteCommand.ExecuteNonQuery();

                // Loop pelas novas línguas selecionadas
                foreach (var language in languages)
                {
                    // Consulta SQL para obter o ID da língua pelo nome
                    string languageQuery = "SELECT ID FROM Language WHERE Designation = @LanguageName";

                    SqlCommand languageCommand = new SqlCommand(languageQuery, connection);
                    languageCommand.Parameters.AddWithValue("@LanguageName", language);

                    int languageId = Convert.ToInt32(languageCommand.ExecuteScalar());

                    // Comando SQL para inserir um registro na tabela de junção Character_tem_language
                    string query = @"INSERT INTO Character_tem_language (id_character, id_language) 
                             VALUES (@CharacterId, @LanguageId)";

                    SqlCommand command = new SqlCommand(query, connection);

                    // Parâmetros do comando SQL
                    command.Parameters.AddWithValue("@CharacterId", characterId);
                    command.Parameters.AddWithValue("@LanguageId", languageId);

                    // Executar o comando SQL
                    command.ExecuteNonQuery();
                }
            }
        }

        public static void AddUserCharacter(int userId, int characterId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();

                string query = @"INSERT INTO User_tem_character (id_user, id_character) 
                         VALUES (@UserId, @CharacterId)";

                SqlCommand command = new SqlCommand(query, connection);

                command.Parameters.AddWithValue("@UserId", userId);
                command.Parameters.AddWithValue("@CharacterId", characterId);

                command.ExecuteNonQuery();
            }
        }
        public static void DeleteCharacter(int characterId)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"DELETE FROM [Character] WHERE ID = @CharacterId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CharacterId", characterId);

                connection.Open();
                command.ExecuteNonQuery();
            }
        }
       
        public static List<Character> GetCharacters(int userId)
        {
            List<Character> characters = new List<Character>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT c.ID, c.[name], c.HP, c.[Level], c.speed, c.class_id, c.ancestry_id, 
                       c.background_id, c.ability_scores_id, c.Str_mod, c.Dex_mod, c.Con_mod, 
                       c.Int_mod, c.Wis_mod, c.Cha_mod
                FROM [Character] c
                JOIN User_tem_character utc ON c.ID = utc.id_character
                WHERE utc.id_user = @UserId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@UserId", userId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    List<int> abss = new List<int>();
                    while (reader.Read())
                    {
                        abss = GetAbilityScoresById(reader.GetInt32(8));
                        Character character = new Character
                        {
                            ID = reader.GetInt32(0),
                            name = reader.GetString(1),
                            HP = reader.GetInt32(2),
                            Level = reader.GetInt32(3),
                            speed = reader.GetInt32(4),
                            Class = GetClassById(reader.GetInt32(5)),
                            ancestry = GetAncestryById(reader.GetInt32(6)),
                            background = GetBackgroundById(reader.GetInt32(7)),
                            id_abilityScores = reader.GetInt32(8),
                            Str_mod = reader.GetInt32(9),
                            Dex_mod = reader.GetInt32(10),
                            Con_mod = reader.GetInt32(11),
                            Int_mod = reader.GetInt32(12),
                            Wis_mod = reader.GetInt32(13),
                            Cha_mod = reader.GetInt32(14),
                            Str = abss[0],
                            Dex = abss[1],
                            Con = abss[2],
                            Int = abss[3],
                            Wis = abss[4],
                            Cha = abss[5]
                               




                        };

                        character.equipment = GetCharacterEquipment(character.ID);
                        character.feats = GetCharacterFeats(character.ID);
                        character.spells = GetCharacterSpells(character.ID);
                        character.Languages = GetCharacterLanguages(character.ID);
                        //character.traits = GetCharacterTraits(character.ID);

                        characters.Add(character);
                    }
                }
            }

            return characters;
        }

        private static Class GetClassById(int classId)
        {
            Class characterClass = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, [name], HP, prof_attack, prof_defense, ability, spell_progression_id FROM Class WHERE ID = @ClassId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@ClassId", classId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        characterClass = new Class
                        {
                            ID = reader.GetInt32(0),
                            name = reader.GetString(1),
                            HP = reader.GetInt32(2),
                            prof_attack = reader.IsDBNull(3) ? string.Empty : reader.GetString(3),
                            prof_defense = reader.IsDBNull(4) ? string.Empty : reader.GetString(4),
                            ability = reader.IsDBNull(5) ? string.Empty : reader.GetString(5),
                            spell_progression_id = reader.IsDBNull(6) ? 0 : reader.GetInt32(6)
                        };

                    }
                }
            }

            return characterClass;
        }
        public static List<int> GetAbilityScoresById(int abilityScoresId)
        {
            List<int> abilityScores = new List<int>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"SELECT STRENGTH, DEXTERITY, CONSTITUTION, INTELLIGENCE, WISDOM, CHARISMA
                         FROM Ability_scores
                         WHERE ID = @AbilityScoresId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AbilityScoresId", abilityScoresId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        abilityScores.Add(reader.GetInt32(0)); // Strength
                        abilityScores.Add(reader.GetInt32(1)); // Dexterity
                        abilityScores.Add(reader.GetInt32(2)); // Constitution
                        abilityScores.Add(reader.GetInt32(3)); // Intelligence
                        abilityScores.Add(reader.GetInt32(4)); // Wisdom
                        abilityScores.Add(reader.GetInt32(5)); // Charisma
                    }
                }
            }

            return abilityScores;
        }


        private static Ancestry GetAncestryById(int ancestryId)
        {
            Ancestry ancestry = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, name, HP, size, speed, ability_flaw, ability_boost, vision, rarity FROM Ancestry WHERE ID = @AncestryId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@AncestryId", ancestryId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        ancestry = new Ancestry
                        {
                            ID = reader.GetInt32(0),
                            name = reader.GetString(1),
                            HP = reader.GetInt32(2),
                            size = reader.GetString(3),
                            speed = reader.GetInt32(4),
                            ability_flaw = reader.GetString(5),
                            ability_boost = reader.GetString(6),
                            vision = reader.GetString(7),
                            rarity = reader.GetString(8)
                        };
                    }
                }
            }

            return ancestry;
        }

        private static Background GetBackgroundById(int backgroundId)
        {
            Background background = null;

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "SELECT ID, name, ability, skill, feat, rarity, summary FROM Background WHERE ID = @BackgroundId";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@BackgroundId", backgroundId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        background = new Background
                        {
                            ID = reader.GetInt32(0),
                            name = reader.GetString(1),
                            ability = reader.GetString(2),
                            skill = reader.GetString(3),
                            feat = reader.GetString(4),
                            rarity = reader.GetString(5),
                            summary = reader.GetString(6)
                        };
                    }
                }
            }

            return background;
        }

        private static List<Equipment> GetCharacterEquipment(int characterId)
        {
            List<Equipment> equipment = new List<Equipment>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT e.ID, e.[name], e.item_category, e.item_sub_category, e.usage, e.[bulk], 
                       e.rarity, e.weapon_category, e.[level], e.price
                FROM Equipment e
                JOIN Character_tem_equipment cte ON e.ID = cte.id_equipment
                WHERE cte.id_character = @CharacterId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CharacterId", characterId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        equipment.Add(new Equipment
                        {
                            ID = reader.GetInt32(0),
                            name = reader.GetString(1),
                            item_category = reader.GetString(2),
                            item_sub_category = reader.IsDBNull(3) ? null : reader.GetString(3),
                            usage = reader.IsDBNull(4) ? null : reader.GetString(4),
                            bulk = reader.IsDBNull(5) ? null : reader.GetString(5),
                            rarity = reader.GetString(6),
                            weapon_category = reader.GetString(7),
                            level = reader.GetInt32(8),
                            price = reader.IsDBNull(9) ?  0 : reader.GetInt32(9)
                        });
                    }
                }
            }

            return equipment;
        }

        private static List<Feat> GetCharacterFeats(int characterId)
        {
            List<Feat> feats = new List<Feat>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT f.ID, f.rarity, f.prerequisite, f.summary, f.name, f.level
                FROM Feats f
                JOIN Character_tem_feats ctf ON f.ID = ctf.id_feats
                WHERE ctf.id_character = @CharacterId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CharacterId", characterId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        feats.Add(new Feat
                        {
                            ID = reader.GetInt32(0),
                            rarity = reader.GetString(1),
                            prerequisite = reader.IsDBNull(2) ? null : reader.GetString(2),
                            summary = reader.IsDBNull(3) ? null : reader.GetString(3),
                            name = reader.GetString(4),
                            level = reader.GetInt32(5)
                        });
                    }
                }
            }

            return feats;
        }

        private static List<Spell> GetCharacterSpells(int characterId)
        {
            List<Spell> spells = new List<Spell>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT s.ID, s.spell_type, s.name, s.actions, s.defense, s.target, s.rarity, 
                       s.[trigger], s.area, s.rank, s.heighten, s.duration, s.range
                FROM Spells s
                JOIN Character_tem_spells cts ON s.ID = cts.id_spells
                WHERE cts.id_character = @CharacterId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CharacterId", characterId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        spells.Add(new Spell
                        {
                            ID = reader.GetInt32(0),
                            SpellType = reader.GetString(1),
                            Name = reader.GetString(2),
                            Actions = reader.IsDBNull(3) ? null : reader.GetString(3),
                            Defense = reader.IsDBNull(4) ? null : reader.GetString(4),
                            Target = reader.IsDBNull(5) ? null : reader.GetString(5),
                            Rarity = reader.GetString(6),
                            Trigger = reader.IsDBNull(7) ? null : reader.GetString(7),
                            Area = reader.IsDBNull(8) ? null : reader.GetString(8),
                            Rank = reader.GetInt32(9),
                            Heighten = reader.IsDBNull(10) ? null : reader.GetString(10),
                            Duration = reader.IsDBNull(11) ? null : reader.GetString(11),
                            Range = reader.IsDBNull(12) ? null : reader.GetString(12)
                        });
                    }
                }
            }

            return spells;
        }

        private static List<string> GetCharacterLanguages(int characterId)
        {
            List<string> languages = new List<string>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT l.designation
                FROM Language l
                JOIN Character_tem_language ctl ON l.ID = ctl.id_language
                WHERE ctl.id_character = @CharacterId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CharacterId", characterId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        languages.Add(reader.GetString(0));
                    }
                }
            }

            return languages;
        }

        private static List<Trait> GetCharacterTraits(int characterId)
        {
            List<Trait> traits = new List<Trait>();

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = @"
                SELECT t.ID, t.name, t.description
                FROM Trait t
                JOIN Character_tem_traits ctt ON t.ID = ctt.id_trait
                WHERE ctt.id_character = @CharacterId;";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CharacterId", characterId);

                connection.Open();
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        traits.Add(new Trait
                        {
                            ID = reader.GetInt32(0),
                            designation = reader.GetString(1),
                            details = reader.GetString(2)
                        });
                    }
                }
            }

            return traits;
        }








    }




}

