using Common;
using Exceptions;

using System;
using System.IO;
using System.Net.Sockets;

namespace Project.Client.ServerCommunication
{
    public class Communication
    {
        private static Communication _instance;
        private static object _instanceLock = new object();

        private Socket _socket;
        private CommunicationHelper _helper;

        public static Communication Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_instanceLock)
                    {
                        if (_instance == null)
                        {
                            _instance = new Communication();
                        }
                    }
                }

                return _instance;
            }
        }

        public void Connect(string host, int port)
        {
            if (_socket == null || !_socket.Connected)
            {
                _socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                _socket.Connect(host, port);
                _helper = new CommunicationHelper(_socket);
            }
        }

        public T SendRequestGetResponse<T>(Operation operation, object requestObject = null) where T : class
        {
            SendRequest(operation, requestObject);
            return GetResponse<T>();
        }

        public void SendRequestNoResponse(Operation operation, object requestObject = null)
        {
            SendRequest(operation, requestObject);
            GetResponse();
        }

        private void SendRequest(Operation operation, object requestObject)
        {
            try
            {
                Request request = new Request
                {
                    Operation = operation,
                    Object = requestObject
                };
                _helper.Send(request);
            }
            catch (IOException e)
            {
                throw new Exception("Error: Sending request failed! " + e.Message);
            }
        }

        private T GetResponse<T>() where T : class 
        {
            Response response = _helper.Receive<Response>();
            if (response.ErrorCode == 23505)
            {
                throw new EntityDuplicateException(response.Message);
            }
            ValidateResponse(response);
            return (T)response.Object;
        }

        private void GetResponse()
        {
            Response response = _helper.Receive<Response>();
            if (response.ErrorCode == 23505)
            {
                throw new EntityDuplicateException(response.Message);
            }
            ValidateResponse(response);
        }

        private void ValidateResponse(Response response)
        {
            if (response.Success) return;
            throw new Exception(response.Message);
        }

        public void Disconnect()
        {
            if (_socket == null) return;
            SendCloseRequest();
            CloseSocket();
            Environment.Exit(0);
        }

        private void SendCloseRequest()
        {
            Request request = new Request()
            {
                Operation = Operation.END
            };
            _helper.Send(request);
        }

        private void CloseSocket()
        {
            _socket.Shutdown(SocketShutdown.Both);
            _socket.Close();
            _socket = null;
        }
    }
}
