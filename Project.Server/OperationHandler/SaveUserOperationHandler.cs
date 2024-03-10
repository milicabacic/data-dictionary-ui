using Common;
using Common.Exceptions;
using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class SaveUserOperationHandler : OperationHandler
    {
        public Response Handle(Request request)
        {
            Response response = new Response();
            try
            {
                Controller.Instance.SaveUser((User)request.Object);
            }
            catch (EntityDuplicateException e)
            {
                response.Message = e.Message;
                response.ErrorCode = 23505;
                return response;
            }
            catch (Exception e)
            {
                response.Message = "Error: Saving user failed!";
                response.Success = false;
                return response;
            }

            return response;
        }
    }
}
