using MySqlConnector;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    [Serializable]
    public class AnimalSpecies : Entity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int ParentID { get; set; }
        public string PathStr { get; set; }

        [Browsable(false)]
        public string TableName => "AnimalSpecies";

        [Browsable(false)]
        public string InsertValues => "";

        [Browsable(false)]
        public string WhereCondition => $"id={ID}";

        public Entity ReadRow(MySqlDataReader reader)
        {
            return new AnimalSpecies()
            {
                ID = (int)reader["id"],
                Name = (string)reader["name"],
                ParentID = reader["parent_id"] is DBNull ? 0 : (int)reader["parent_id"],
                PathStr = (string)reader["path_str"]
            };
        }
    }
}
