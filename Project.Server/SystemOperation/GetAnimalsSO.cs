using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetAnimalsSO : SystemOperation
    {
        public List<Animal> Result { get; private set; }

        protected override void Execute(Entity entity)
        {
            Result = new List<Animal>();
            foreach (Animal animal in _repository.GetAll(new Animal()))
            {
                Result.Add(animal);

            }
        }
    }
}