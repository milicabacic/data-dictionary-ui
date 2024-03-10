using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetUniversityMemberOperationHandler : OperationHandler
    {
        public Response Handle(Request request)
        {
            Response response = new Response();
            UniversityMember member = Controller.Instance.GetUniversityMember((UniversityMember)request.Object);
            response.Object = member;
            return response;
        }
    }
}
