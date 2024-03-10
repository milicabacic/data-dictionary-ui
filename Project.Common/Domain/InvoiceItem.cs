using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class InvoiceItem
    {
        public int ID { get; set; }
        public Product Product { get; set; }    
        public int Quantity { get; set; }

        public InvoiceItem() { }

        public override string ToString()
        {
            return $"ID: {ID}, Product: {Product}, Quantity: {Quantity}";
        }
    }
}
