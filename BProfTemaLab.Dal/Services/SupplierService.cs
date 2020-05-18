using BProfTemaLab.Dal.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BProfTemaLab.Dal.Services
{
    public class SupplierService
    {
        public SupplierService(ApplicationDbContext dbContext)
        {
            DbContext = dbContext;
        }
        public ApplicationDbContext DbContext { get; }
        public IEnumerable<Supplier> GetSuppliers() => DbContext.Supplier.ToList();
    }
}
