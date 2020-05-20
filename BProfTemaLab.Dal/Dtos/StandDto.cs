using BProfTemaLab.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BProfTemaLab.Dal.Dtos
{
    public class StandDto
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Purchased { get; set; }
        public int ClosingQuantity { get; set; }
        public int Scrap { get; set; }
        public int Sold { get; set; }
        public int Loss { get; set; }
        public int Income { get; set; }
        public string ProductName { get; set; }
        public int StartingQuantity { get; set; }
        public int UnitPrice { get; set; }
    }
}
