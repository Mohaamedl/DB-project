using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    public class User
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public User()
        {
            CreatedAt = DateTime.Now;
        }

        // Constructor with basic initialization
        

        // Constructor with all parameters
        public User(int id, string username, byte[] passwordHash, byte[] passwordSalt, string role, DateTime createdAt)
        {
            ID = id;
            Username = username;
            PasswordHash = passwordHash;
            PasswordSalt = passwordSalt;
            Role = role;
            CreatedAt = createdAt;
        }
        public override string ToString()
        {
            return $"ID: {ID}, Username: {Username}, Role: {Role}, CreatedAt: {CreatedAt}";
        }

    }

}

