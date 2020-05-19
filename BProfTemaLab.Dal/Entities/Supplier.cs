﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BProfTemaLab.Dal.Entities
{
    public class Supplier
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
