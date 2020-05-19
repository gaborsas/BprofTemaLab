using System;
using System.Collections.Generic;
using System.Text;

namespace BProfTemaLab.Dal.Dtos
{
    public class ProductDto
    {
        public int Id { get; set; }
        public int SupplierId { get; set; }
        public string SupplierName { get; set; }
        public string Name { get; set; }
        public int UnitPrice { get; set; }
        public int Quantity { get; set; }
    }
}
