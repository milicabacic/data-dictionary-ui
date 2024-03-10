using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetAnimalsForSpeciesOperationHandler : OperationHandler
    {
        public Response Handle(Request request)
        {
            Response response = new Response();
            response.Object = Controller.Instance.GetAnimalsForSpecies((AnimalSpecies)request.Object);
            if (response.Object == null)
            {
                response.Message = "Error: Get animals for species failed!";
                response.Success = false;
                return response;
            }
            return response;
        }
    }
}
