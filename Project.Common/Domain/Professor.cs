using Domain;
using MySqlConnector;
using System;
using System.ComponentModel;

namespace Domain
{
    [Serializable]
    public class Professor : Entity
    {
        public int ID { get; set; }
        public string Department { get; set; }
        public string ResearchArea { get; set; }

        public string TableName => "Professor";

        public string InsertValues => throw new NotImplementedException();


        public string WhereCondition => $"id={ID}";

        public Professor() { }

        public override string ToString()
        {
            return $"Professor{{ ID = {ID}, Department = '{Department}', ResearchArea = '{ResearchArea}' }}";
        }

        public Entity ReadRow(MySqlDataReader reader)
        {
            return new Professor()
            {
                ID = (int)reader["id"],
                Department = (string)reader["department"],
                ResearchArea = (string)reader["research_area"]
            };
        }
    }
}
