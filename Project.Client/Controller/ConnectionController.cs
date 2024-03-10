using Project.Client.ServerCommunication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client
{
    public class ConnectionController
    {
        private static readonly string HOST = "127.0.0.1";
        private static readonly int PORT = 8080;

        public void Connect()
        {
            Communication.Instance.Connect(HOST, PORT);
        }

        public void Disconnect()
        {
            Communication.Instance.Disconnect();
        }
    }
}
