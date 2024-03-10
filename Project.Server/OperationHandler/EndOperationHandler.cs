using Common;
using Project.Server;

namespace Server
{
    public class EndOperationHandler : OperationHandler
    {
        private ClientHandler _client;

        public EndOperationHandler(ClientHandler client)
        {
            _client = client;
        }

        public Response Handle(Request request)
        {
            _client.Stop();
            return new Response();
        }
    }
}
