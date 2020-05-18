using BProfTemaLab.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BProfTemaLab.Dal.Services
{
    public class ProductService
    {
        public ProductService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }
        public IEnumerable<Product> GetProducts() => DbContext.Product.ToList();
    }
}
