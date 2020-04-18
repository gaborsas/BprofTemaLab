using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BProfTemaLab.Models
{
    public class Beszallito
    {
        public int ID { get; set; }
        public string Nev { get; set; }
        public string TelSzam { get; set; }

        public virtual ICollection<Termek> Termekek { get; set; }
    }
}
