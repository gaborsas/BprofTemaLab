using BProfTemaLab.Dal.Entities;
using BProfTemaLab.Dal.SeedService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace BProfTemaLab.Dal.EntityConfigurations
{
    class SupplierEntityConfiguration : IEntityTypeConfiguration<Supplier>
    {
        private readonly ISeedService _seedService;
        public SupplierEntityConfiguration(ISeedService seedService)
        => _seedService = seedService;
        public void Configure(EntityTypeBuilder<Supplier> builder)
        => builder.HasData(_seedService.Suppliers);

    }
}
