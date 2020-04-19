using BProfTemaLab.Models;
using BProfTemaLab.SeedService;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BProfTemaLab.EntityConfigurations
{
    public class BeszallitoEntityConfiguration : IEntityTypeConfiguration<Beszallito>
    {
        private readonly ISeedService _seedService;
        public BeszallitoEntityConfiguration(ISeedService seedService)
        => _seedService = seedService;
        public void Configure(EntityTypeBuilder<Beszallito> builder)
        {
            builder.HasData(_seedService.Beszallitok.Values);
        }
    }
}
