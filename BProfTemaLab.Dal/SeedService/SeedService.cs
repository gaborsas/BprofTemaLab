using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using BProfTemaLab.Dal.Entities;

namespace BProfTemaLab.Dal.SeedService
{
    public class SeedService : ISeedService
    {
        public IList<Supplier> Suppliers { get; }
        public IList<Product> Products { get; }

        public SeedService()
        {
            Suppliers = new List<Supplier>()
            {
                 new Supplier
                 {
                    Id = 1,
                    Name = @"Coca Cola",
                    PhoneNumber = @"06-20-123-4567",
                    Email = @"coca@cola.com",
                    Address = @"1234 Bp igen u. 35",
                },

                   new Supplier
                 {
                    Id = 2,
                    Name = @"Soproni",
                    PhoneNumber = @"06-20-123-7654",
                    Email = @"soproni@sor.hu",
                    Address = @"3124 Bp talán u. 25",
                },

                     new Supplier
                 {
                    Id = 3,
                    Name = @"Sör Gyár",
                    PhoneNumber = @"06-20-123-6789",
                    Email = @"sor@gyar.hu",
                    Address = @"4321 Bp nem u. 53",
                },
            };

            Products = new List<Product>()
            {
                 new Product
                 {
                    Id = 1,
                    SupplierId = 1,
                    Name = @"Coca Cola",
                    UnitPrice = 250,
                },

                   new Product
                 {
                    Id = 2,
                    SupplierId = 2,
                    Name = @"Soproni classic",
                    UnitPrice = 350,
                },

                     new Product
                 {
                    Id = 3,
                    SupplierId = 2,
                    Name = @"Soproni Demon",
                    UnitPrice = 450,
                },
            };
        }
    }
}
