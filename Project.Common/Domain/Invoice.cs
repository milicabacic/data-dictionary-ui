﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain
{
    public class Invoice
    {
        public int ID { get; set; } 
        public List<InvoiceItem> Items { get; set; }    

        public Invoice() { }
    }
}
