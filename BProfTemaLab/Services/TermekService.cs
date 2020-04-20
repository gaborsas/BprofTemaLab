using BProfTemaLab.Data;
using BProfTemaLab.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BProfTemaLab.Services
{
    public class TermekService
    {
        public StandContext DbContext { get; }
        public TermekService(StandContext dbContext)
        {
            DbContext = dbContext;
        }

        public IEnumerable<TermekDto> GetTermekek() => DbContext.Termekek
            .Select(b => new TermekDto
        {
            Nev = b.Nev,
            BeszallitoID = b.BeszallitoID,
            Beszallito = b.Beszallito,
            EgysegAr = b.EgysegAr,
            ID = b.ID,
            DarabPerRekesz = b.DarabPerRekesz
        });

    }
}
