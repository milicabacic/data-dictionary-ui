using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Project.Server
{
    public class Server
    {
        private Socket _socket;
        private List<ClientHandler> _clients;

        public Server() 
        {
            _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            _clients = new List<ClientHandler>();
        }

        public void Start(string host, int port) 
        {
            Initialize(host, port);
            Listen();
        }

        private void Initialize(string host, int port)
        {
            try
            {
                IPEndPoint endPoint = new IPEndPoint(IPAddress.Parse(host), port);
                _socket.Bind(endPoint);
                _socket.Listen(5);
                Console.WriteLine("Server Started!");
            }
            catch (ArgumentNullException e)
            {
                throw new Exception("Error: Starting server failed. Host is not valid.");
            }
            catch (ArgumentOutOfRangeException e)
            {
                throw new Exception("Error: Starting server failed. Port is not valid.");
            }
        }

        private void Listen()
        {
            try
            {
                while (true)
                {
                    Console.WriteLine("Waiting for connection...");
                    Socket clientSocket = _socket.Accept();
                    Console.WriteLine("New client connected!");
                    ClientHandler client = new ClientHandler(clientSocket);
                    _clients.Add(client);
                    Thread clientThread = new Thread(client.Handle);
                    clientThread.Start();
                }
            }
            catch (SocketException e) 
            {
                throw new Exception("Error: " + e.Message);
            }
        }
    }
}
