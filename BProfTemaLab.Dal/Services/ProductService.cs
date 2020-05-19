using BProfTemaLab.Dal.Dtos;
using BProfTemaLab.Dal.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
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

        public static Expression<Func<Product, ProductDto>> ProductDtoSelector { get; } = p => new ProductDto
        {
            Id = p.Id,
            Name = p.Name,
            SupplierId = p.SupplierId,
            SupplierName = p.Supplier.Name,
            UnitPrice = p.UnitPrice,
            Quantity = p.Quantity
        };

        public IEnumerable<ProductDto> GetProducts() => DbContext.Product
            .Select(ProductDtoSelector)
            .ToList();

        public ProductDto GetProductById(int productId) => DbContext.Product
            .Where(p => p.Id == productId)
            .Select(ProductDtoSelector)
            .Single();

        public void AddProduct(Product product)
        {
            DbContext.Product.Add(new Product
            {
                Name = product.Name,
                SupplierId = product.SupplierId,
                UnitPrice = product.UnitPrice,
                Quantity = product.Quantity

            });

            DbContext.SaveChanges();
        }

        public void DeleteProduct(int productId)
        {
            DbContext.Remove(new Product { Id = productId });
            DbContext.SaveChanges();
        }

    }
}
