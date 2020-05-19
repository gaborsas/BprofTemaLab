using BProfTemaLab.Dal.Dtos;
using BProfTemaLab.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BProfTemaLab.Dal.Services
{
    public class SupplierService
    {
        public SupplierService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }
        //public IEnumerable<SupplierDto> GetSuppliersWithProducts() => DbContext.Supplier.ToList();

        public IEnumerable<SupplierDto> GetSuppliersWithProducts() => DbContext.Supplier
         .Include(s => s.Products)
         .ToList()
         .Select(s => new SupplierDto
         {
             Id = s.Id,
             Name = s.Name,
             PhoneNumber = s.PhoneNumber,
             Email = s.Email,
             Address = s.Address,
             Products = s.Products.Where(p => p.SupplierId == s.Id)
                           .Select(p => new ProductDto
                           {
                               Id = p.Id,
                               Name = p.Name,
                               SupplierId = p.SupplierId,
                               SupplierName = s.Name,
                               UnitPrice = p.UnitPrice,
                               Quantity = p.Quantity
                           }).ToList(),
         });
    }
}
