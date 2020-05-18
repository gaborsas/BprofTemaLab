using BProfTemaLab.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BProfTemaLab.Dal.Dtos
{
    public class SupplierDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public List<ProductDto> Products { get; set; }
    }
}
