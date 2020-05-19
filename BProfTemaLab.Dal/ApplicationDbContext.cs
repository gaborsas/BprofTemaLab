using System;
using System.Collections.Generic;
using System.Text;

using BProfTemaLab.Dal.Entities;
using BProfTemaLab.Dal.EntityConfigurations;
using BProfTemaLab.Dal.SeedService;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BProfTemaLab.Dal
{
    public class ApplicationDbContext : IdentityDbContext<User,IdentityRole<int>, int>
    {
        private readonly ISeedService _seedService;
        public DbSet<Supplier> Supplier { get; set; }
        public DbSet<Product> Product { get; set; }
        public ApplicationDbContext(DbContextOptions options, ISeedService seedService) : base(options)
       => _seedService = seedService;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new SupplierEntityConfiguration(_seedService));
            modelBuilder.ApplyConfiguration(new ProductEntityConfiguration(_seedService));
            modelBuilder.Entity<User>().ToTable("Users");
        }
    }
}
