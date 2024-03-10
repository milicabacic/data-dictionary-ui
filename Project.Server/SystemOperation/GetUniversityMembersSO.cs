using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    internal class GetUniversityMembersSO : SystemOperation
    {
        public List<UniversityMember> Result { get; private set; }

        protected override void Execute(Entity entity)
        {
            Result = new List<UniversityMember>();
            foreach (UniversityMember universityMember in _repository.GetAll(new UniversityMember()))
            {
                Result.Add(universityMember);
            }
        }
    }
}
