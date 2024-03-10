using Common;
using Server;
using System;
using System.Net.Sockets;

namespace Project.Server
{
    public class ClientHandler
    {
        private Socket _socket;
        private CommunicationHelper _helper;

        private bool _running = true;
        private object _clientLock = new object();

        public ClientHandler(Socket socket)
        {
            _socket = socket;
            _helper = new CommunicationHelper(_socket);
        }

        public void Handle()
        {
            try
            {
                while (_running)
                {
                    Request request = _helper.Receive<Request>();
                    OperationHandler operationHandler = GetOperationHandler(request.Operation);
                    Response response = operationHandler.Handle(request);
                    if (!_running) break;
                    _helper.Send(response);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error: " + e.Message);
            }
            finally
            {
                Close();
                Console.WriteLine("Client disconnected!");
            }
        }

        private OperationHandler GetOperationHandler(Operation operation)
        {
            switch (operation)
            {
                case Operation.GET_UNIVERSITY_MEMBER:
                    return new GetUniversityMemberOperationHandler();

                case Operation.GET_UNIVERSITY_MEMBERS:
                    return new GetUniversityMembersOperationHandler();

                case Operation.GET_PROFESSOR:
                    return new GetProffessorOperationHandler();

                case Operation.GET_STUDENT:
                    return new GetStudentOperationHandler();

                case Operation.GET_USERS:
                    return new GetUsersOperationHandler();

                case Operation.SAVE_USER:
                    return new SaveUserOperationHandler();

                case Operation.GET_PRODUCTS:
                    return new GetProductsOperationHandler();

                case Operation.GET_ANIMAL_SPECIES_LIST:
                    return new GetAnimalSpeciesOperationHandler();
                case Operation.GET_ANIMALS:
                    return new GetAnimalsOperationHandler();
                case Operation.GET_ANIMAL_SPECIES:
                    return new GetSpecificAnimalSpeciesOperationHandler();
                case Operation.GET_ANIMAL_FOR_SPECIES:
                    return new GetAnimalsForSpeciesOperationHandler();

                case Operation.END:
                    return new EndOperationHandler(this);

                default:
                    throw new Exception("Error: Unhandled operation!");
            }
        }

        public void Stop()
        {
            _running = false;
        }

        private void Close()
        {
            lock (_clientLock)
            {
                if (_socket != null)
                {
                    _running = false;
                    _socket.Shutdown(SocketShutdown.Both);
                    _socket.Close();
                    _socket = null;
                }
            }
        }
    }
}
