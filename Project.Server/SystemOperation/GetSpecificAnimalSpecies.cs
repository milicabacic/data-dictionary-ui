using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetSpecificAnimalSpecies : SystemOperation
    {
        public AnimalSpecies Result { get; private set; }

        protected override void Execute(Entity entity)
        {
            Result = (AnimalSpecies)_repository.GetSpecific(entity);
        }
    }
}
