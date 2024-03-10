using System;
using System.Data;
using System.Text;
using MySqlConnector;

namespace Server
{
    public class MySQLBroker : Broker
    {
        private readonly string HOST = "127.0.0.1";
        private readonly string PORT = "3306";
        private readonly string DATABASE = "DataDictionary";
        private readonly string USER = "root";
        private readonly string PASSWORD = "Marija1806976!";

        private MySqlConnection _connection;
        private MySqlTransaction _transaction;

        public MySQLBroker()
        {
            try
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("Server=").Append(HOST).Append(";");
                builder.Append("Port=").Append(PORT).Append(";");
                builder.Append("Database=").Append(DATABASE).Append(";");
                builder.Append("User=").Append(USER).Append(";");
                builder.Append("Password=").Append(PASSWORD).Append(";");
                _connection = new MySqlConnection(builder.ToString());
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }

        public void OpenConnection()
        {
            _connection.Open();
        }

        public MySqlCommand CreateCommand()
        {
            MySqlCommand command = new MySqlCommand("", _connection);
            command.Transaction = _transaction;
            return command;
        }

        public void CloseConnection()
        {
            _connection.Close();
        }

        public void BeginTransaction()
        {
            _transaction = _connection.BeginTransaction();
        }

        public void Commit()
        {
            _transaction.Commit();
        }

        public void Rollback()
        {
            _transaction.Rollback();
        }

        public bool IsConnected()
        {
            return _connection.State == System.Data.ConnectionState.Open;
        }
    }
}
