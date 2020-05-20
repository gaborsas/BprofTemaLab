using System;
using System.Collections.Generic;
using System.Text;

namespace BProfTemaLab.Dal.Entities
{
    public class Stand
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Purchased { get; set; }
        public int ClosingQuantity { get; set; }
        public int Scrap { get; set; }
        public int Sold { get; set; }
        public int Loss { get; set; }
        public int Income { get; set; }
    }
}
