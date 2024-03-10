using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetStudentSO : SystemOperation
    {
        public Student Result { get; private set; }

        protected override void Execute(Entity entity)
        {
            Result = (Student) _repository.GetSpecific(entity);
        }
    }
}
