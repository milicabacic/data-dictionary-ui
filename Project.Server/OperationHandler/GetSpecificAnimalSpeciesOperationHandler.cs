using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetSpecificAnimalSpeciesOperationHandler : OperationHandler
    {
        public Response Handle(Request request)
        {
            Response response = new Response();
            AnimalSpecies animalSpecies = Controller.Instance.GetSpecificAnimalSpecies((AnimalSpecies)request.Object);
            response.Object = animalSpecies;
            return response;
        }
    }
}
