using Common;
using Domain;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetProffessorOperationHandler : OperationHandler
    {
        public Response Handle(Request request)
        {
            Response response = new Response();
            Professor professor = Controller.Instance.GetProfessor((Professor)request.Object);
            response.Object = professor;
            return response;
        }
    }
}
