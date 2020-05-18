using BProfTemaLab.Dal.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BProfTemaLab.Views.Shared.Components.Product
{
    public class ProductViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(BProfTemaLab.Dal.Entities.Product product)
        {
            return View(product);
        }
    }
}
