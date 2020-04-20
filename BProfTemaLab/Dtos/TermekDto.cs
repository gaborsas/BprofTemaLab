using BProfTemaLab.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BProfTemaLab.Dtos
{
    public class TermekDto
    {
        public int ID { get; set; }
        public string Nev { get; set; }
        public int EgysegAr { get; set; }
        public int BeszallitoID { get; set; }
        public virtual Beszallito Beszallito { get; set; }
        public int DarabPerRekesz { get; set; }
    }
}
