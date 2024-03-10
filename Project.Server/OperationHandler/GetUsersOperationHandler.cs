using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetUsersOperationHandler : OperationHandler
    {
        public Response Handle(Request request)
        {
            Response response = new Response();
            response.Object = Controller.Instance.GetUsers();
            if (response.Object == null)
            {
                response.Message = "Error: Get users failed!";
                response.Success = false;
                return response;
            }
            return response;
        }
    }
}
