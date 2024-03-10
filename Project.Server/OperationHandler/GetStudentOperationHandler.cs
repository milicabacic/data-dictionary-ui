using Common;
using Domain;

namespace Server
{
    public class GetStudentOperationHandler : OperationHandler
    {
        public Response Handle(Request request)
        {
            Response response = new Response();
            Student student = Controller.Instance.GetStudent((Student) request.Object);
            response.Object = student;
            return response;
        }
    }
}
