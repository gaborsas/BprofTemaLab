using BProfTemaLab.EntityConfigurations;
using BProfTemaLab.Models;
using BProfTemaLab.SeedService;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BProfTemaLab.Data
{
    public class StandContext : DbContext
    {
        private readonly ISeedService _seedService;
        public StandContext(DbContextOptions options, ISeedService seedService) : base(options)
            => _seedService = seedService;
        public DbSet<Termek> Termekek { get; set; }
        public DbSet<Beszallito> Beszallitok { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new BeszallitoEntityConfiguration(_seedService));
            modelBuilder.ApplyConfiguration(new TermekEntityConfiguration(_seedService));
        }
    }
}
