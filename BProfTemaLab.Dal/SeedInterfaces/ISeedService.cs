using BProfTemaLab.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace BProfTemaLab.Dal.SeedService
{
    public interface ISeedService
    {
        IList<Supplier> Suppliers { get; }
        IList<Product> Products { get; }
    }
}
