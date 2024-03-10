using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetUniversityMemberSO : SystemOperation
    {
        public UniversityMember Result { get; private set; }

        protected override void Execute(Entity entity)
        {
            Result = (UniversityMember)_repository.GetSpecific(entity);
        }
    }
}
