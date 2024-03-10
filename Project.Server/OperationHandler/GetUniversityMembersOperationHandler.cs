using Common;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetUniversityMembersOperationHandler : OperationHandler
    {
        public Response Handle(Request request)
        {
            Response response = new Response();
            List<UniversityMember> members = Controller.Instance.GetUniversityMembers();
            foreach (UniversityMember member in members)
            {
                if (member.Professor != null)
                {
                    member.Type = "Professor";
                }
                if (member.Student != null)
                {
                    member.Type = "Student";
                }
                if (member.Professor != null && member.Student != null)
                {
                    member.Type = "Professor/Student";
                }
            }
            response.Object = members;
            return response;
        }
    }
}
