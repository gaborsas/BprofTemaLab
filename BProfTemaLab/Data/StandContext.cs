using BProfTemaLab.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BProfTemaLab.Data
{
    public class StandContext : DbContext
    {
        public StandContext(DbContextOptions options) : base(options) { }
        public DbSet<Termek> Termekek { get; set; }
        public DbSet<Beszallito> Beszallitok { get; set; }
    }
}
