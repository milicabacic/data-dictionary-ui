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
    public class Animal : Entity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        [Browsable(false)]
        public int SpeciesID { get; set; }
        [Browsable(false)]
        public string TableName => "Animal";
        [Browsable(false)]
        public string InsertValues => "";
        [Browsable(false)]
        public string WhereCondition => "";
        public string Species { get; set; }

        public Entity ReadRow(MySqlDataReader reader)
        {
            return new Animal()
            {
                ID = (int)reader["id"],
                Name = (string)reader["name"],
                SpeciesID = (int)reader["species_id"]
            };
        }
    }
}
