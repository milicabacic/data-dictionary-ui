using MySqlConnector;

namespace Domain
{
    public interface Entity
    {
        string TableName { get; }
        string InsertValues { get; }
        string WhereCondition { get; }
        Entity ReadRow(MySqlDataReader reader);
    }
}
