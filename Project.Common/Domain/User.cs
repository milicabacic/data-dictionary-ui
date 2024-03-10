using MySqlConnector;
using System;
using System.ComponentModel;

namespace Domain
{
    [Serializable]
    public class User : Entity
    {
        [Browsable(false)]
        public string TableName => "User";

        public int ID { get; set; }
        public string Username { get; set; }

        [Browsable(false)]
        public string InsertValues => $"(username) VALUES ('{Username}')";

        [Browsable(false)]
        public string WhereCondition => $"ID={ID}";

        public Entity ReadRow(MySqlDataReader reader)
        {
            return new User
            {
                ID = (int)reader["ID"],
                Username = (string)reader["Username"]
            };
        }

        public override string ToString()
        {
            return $"ID: {ID} | Username: {Username}";
        }
    }
}
