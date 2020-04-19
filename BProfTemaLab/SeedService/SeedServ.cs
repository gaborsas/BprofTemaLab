using System;
using System.Collections.Generic;
using System.Text;
using BProfTemaLab.Data;
using System.Linq;
using BProfTemaLab.Models;

namespace BProfTemaLab.SeedService
{
    public class SeedServ : ISeedService
    {
        public IDictionary<string, Beszallito> Beszallitok { get; } = new[]
        {
             new Beszallito() { ID = 1, Nev = "Lam Kam Chuen Mester", TelSzam = "1"},
             new Beszallito() { ID = 2, Nev = "Susanne Schumacher", TelSzam = "2"}
        }.ToDictionary(a => a.Nev);


        public IList<Termek> Termekek { get; }

        public SeedServ()
        {
            Termekek = new List<Termek>()
            {
                 new Termek
                 {
                    ID = 1,
                    Nev = @"Személyes feng shui tanácsadó",
                    BeszallitoID = Beszallitok[@"Lam Kam Chuen Mester"].ID,
                    EgysegAr = 20,
                    DarabPerRekesz = 30
                    },
                new Termek
                {
                    ID = 2,
                    Nev = @"Az én feng shui-kertem",
                    BeszallitoID = Beszallitok[@"Susanne Schumacher"].ID,
                    EgysegAr = 30,
                    DarabPerRekesz = 40
                    }
            };
        }
    }
}
