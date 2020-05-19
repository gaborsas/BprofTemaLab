using System;
using System.Collections.Generic;
using System.Text;

namespace BProfTemaLab.Dal.Entities
{
    public class Product
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }

        public Supplier Supplier { get; set; }
    }
}
