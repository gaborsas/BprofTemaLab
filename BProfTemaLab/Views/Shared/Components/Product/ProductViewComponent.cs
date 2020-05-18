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
        public IViewComponentResult Invoke(IEnumerable<BProfTemaLab.Dal.Dtos.ProductDto> products)
        {
            return View(products);
        }
    }
}
