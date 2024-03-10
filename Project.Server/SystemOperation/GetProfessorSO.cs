using Domain;
using System;
using System.Collections.Generic;

namespace Server
{
    public class GetProfessorSO : SystemOperation
    {   
        public Professor Result { get; private set; }

        protected override void Execute(Entity entity)
        {
            Result = (Professor) _repository.GetSpecific(entity);
        }
    }
}
