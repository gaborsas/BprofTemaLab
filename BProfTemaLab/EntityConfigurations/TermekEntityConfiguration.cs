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
    public class TermekEntityConfiguration : IEntityTypeConfiguration<Termek>
    {
        private readonly ISeedService _seedService;
        public TermekEntityConfiguration(ISeedService seedService)
        => _seedService = seedService;
        public void Configure(EntityTypeBuilder<Termek> builder)
        {
            builder.HasData(_seedService.Termekek);
        }
    }
}
