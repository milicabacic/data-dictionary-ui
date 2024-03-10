using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetProductsOperationHandler : OperationHandler
    {
        public Response Handle(Request request)
        {
            Response response = new Response();
            response.Object = Controller.Instance.GetProducts();
            if (response.Object == null)
            {
                response.Message = "Error: Get products failed!";
                response.Success = false;
                return response;
            }
            return response;
        }
    }
}
