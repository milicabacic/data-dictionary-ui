

using MySqlConnector;
using System;
using System.ComponentModel;

namespace Domain
{
    [Serializable]
    public class UniversityMember : Entity
    {
        public string Type { get; set; }
        public int MemberID { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }

        [Browsable(false)]
        public int? Professor { get; set; }
        [Browsable(false)]
        public int? Student { get; set; }

        [Browsable(false)]
        public string TableName => "UniversityMember";

        [Browsable(false)]
        public string InsertValues => "";

        [Browsable(false)]
        public string WhereCondition => $"member_id={MemberID}";

        public UniversityMember() { }

        public override string ToString()
        {
            return $"UniversityMember{{ MemberID = {MemberID}, Name = '{Name}', Email = '{Email}' }}";
        }

        public Entity ReadRow(MySqlDataReader reader)
        {
            return new UniversityMember
            {
                MemberID = (int)reader["member_id"],
                Name = (string)reader["name"],
                Email = (string)reader["email"],
                Professor = reader["professor_id"] is DBNull ? null : (int?)reader["professor_id"],
                Student = reader["student_id"] is DBNull ? null : (int?)reader["student_id"],
            };
        }
    }
}
