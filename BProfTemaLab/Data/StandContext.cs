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

        /*protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Termek>().HasData(

                new Termek
                {
                    ID = 164,
                    Nev = @"Assassin's Creed: Reneszánsz",
                    BeszallitoID = 1,
                    EgysegAr = 20,
                    DarabPerRekesz = 480
                }
            );
        }*/
    }
}
