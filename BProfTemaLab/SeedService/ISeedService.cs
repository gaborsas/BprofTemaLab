using System;
using System.Collections.Generic;
using System.Text;
using BProfTemaLab.Models;
using System.Linq;

namespace BProfTemaLab.SeedService
{
    public interface ISeedService
    {
        IDictionary<string, Beszallito> Beszallitok { get; }
        IList<Termek> Termekek { get; }
    }
}
