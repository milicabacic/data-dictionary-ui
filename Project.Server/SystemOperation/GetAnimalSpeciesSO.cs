using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetAnimalSpeciesSO : SystemOperation
    {
        public List<AnimalSpecies> Result { get; private set; }

        protected override void Execute(Entity entity)
        {
            Result = new List<AnimalSpecies>();
            foreach (AnimalSpecies species in _repository.GetAll(new AnimalSpecies()))
            {
                Result.Add(species);
            }
        }
    }
}
