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
    public class Product : Entity
    {
        public int ID { get; set; } 
        public string Name { get; set; }
        public int AvailableQuantity { get; set; }
        public int SoldQuantity { get; set; }
        [Browsable(false)]
        public string TableName => "Product";
        [Browsable(false)]
        public string InsertValues => throw new NotImplementedException();
        [Browsable(false)]
        public string WhereCondition => $"id={ID}";
        
        public Product() { }

        public override string ToString()
        {
            return Name;
        }

        public Entity ReadRow(MySqlDataReader reader)
        {
            return new Product()
            {
                ID = (int)reader["id"],
                Name = (string)reader["name"],
                AvailableQuantity = (int)reader["available_quantity"],
                SoldQuantity = (int)reader["sold_quantity"]
            };
        }
    }
}
