using BProfTemaLab.Dal.Dtos;
using BProfTemaLab.Dal.Entities;
using Microsoft.EntityFrameworkCore;
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

        public IEnumerable<ProductDto> GetProducts() => DbContext.Product
        .Include(p => p.Supplier)
        .ToList()
        .Select(p => new ProductDto
        {
            Id = p.Id,
            Name = p.Name,
            SupplierId = p.SupplierId,
            SupplierName = p.Supplier.Name,
            UnitPrice = p.UnitPrice,
        });
    }
}
