using BProfTemaLab.Dal.Entities;
using BProfTemaLab.Dal.SeedService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BProfTemaLab.Dal.EntityConfigurations
{
    class ProductEntityConfiguration : IEntityTypeConfiguration<Product>
    {
        private readonly ISeedService _seedService;
        public ProductEntityConfiguration(ISeedService seedService)
        => _seedService = seedService;
        public void Configure(EntityTypeBuilder<Product> builder)
        => builder.HasData(_seedService.Products);
    }
}
