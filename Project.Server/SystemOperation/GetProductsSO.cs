using Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server
{
    public class GetProductsSO : SystemOperation
    {
        public List<Product> Result { get; private set; }

        protected override void Execute(Entity entity)
        {
            Result = new List<Product>();
            foreach (Product product in _repository.GetAll(new Product()))
            {
                Result.Add(product);
            }
        }
    }
}
