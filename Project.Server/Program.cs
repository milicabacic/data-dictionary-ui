using System;
using System.Threading;

namespace Project.Server
{
    internal class Program
    {
        private static readonly string HOST = "127.0.0.1";
        private static readonly int PORT = 8080;

        static void Main(string[] args)
        {
            Server server = new Server();
            server.Start(HOST, PORT);
            Console.WriteLine("Server Started");
        }
    }
}
