using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetAnimalsForSpeciesSO : SystemOperation
    {
        public List<Animal> Result { get; private set; }

        protected override void Execute(Entity entity)
        {
            Result = new List<Animal>();
            string query = $"SELECT a.id as id, a.name as name, a.species_id as species_id FROM Animal a LEFT JOIN AnimalSpecies s ON a.species_id=s.id WHERE s.path_str LIKE '%,{((AnimalSpecies)entity).ID}%'";
            foreach (Animal animal in _repository.ExecuteNative(new Animal(), query))
            {
                Result.Add(animal);
            }
        }
    }
}
