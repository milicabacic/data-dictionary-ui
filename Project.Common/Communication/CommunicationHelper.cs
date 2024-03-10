using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class CommunicationHelper
    {
        private NetworkStream _stream;
        private BinaryFormatter _formatter;

        public CommunicationHelper(Socket socket)
        {
            _stream = new NetworkStream(socket);
            _formatter = new BinaryFormatter();
        }

        public void Send<T>(T obj) where T : class 
        {
            _formatter.Serialize(_stream, obj);
        }

        public T Receive<T>() where T : class 
        {
            return (T)_formatter.Deserialize(_stream);
        }
    }
}
