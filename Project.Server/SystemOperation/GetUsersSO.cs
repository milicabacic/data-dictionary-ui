using Domain;
using Server;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetUsersSO : SystemOperation
    {
        public List<User> Result { get; private set; }

        protected override void Execute(Entity entity)
        {
            Result = new List<User>();
            foreach (User user in _repository.GetAll(new User()))
            {
                Result.Add(user);
            }
        }
    }
}
