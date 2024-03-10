

using MySqlConnector;
using System;
using System.ComponentModel;

namespace Domain
{
    [Serializable]
    public class Student : Entity
    {
        public int ID { get; set; }
        public string Major { get; set; }
        public int EnrollmentYear { get; set; }

        public string TableName => "Student";

        [Browsable(false)]
        public string InsertValues => throw new System.NotImplementedException();

        [Browsable(false)]
        public string WhereCondition => $"id={ID}";

        public Student() { }

        public new string ToString()
        {
            return $"Student{{ id = {ID}, Major = '{Major}', EnrollmentYear = {EnrollmentYear} }}";
        }

        public Entity ReadRow(MySqlDataReader reader)
        {
            return new Student()
            {
                ID = (int)reader["id"],
                Major = (string)reader["major"],
                EnrollmentYear = (int)reader["enrollment_year"]
            };
        }
    }
}
