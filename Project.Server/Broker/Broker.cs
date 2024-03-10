using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public interface Broker
    {
        void OpenConnection();
        bool IsConnected();
        MySqlCommand CreateCommand();
        void CloseConnection();
        void BeginTransaction();
        void Commit();
        void Rollback();
    }
}
