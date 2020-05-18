using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BProfTemaLab.Views.Shared.Components.Supplier
{
    public class SupplierViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(BProfTemaLab.Dal.Dtos.SupplierDto supplier)
        {
            return View(supplier);
        }
    }
}
