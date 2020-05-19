using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BProfTemaLab.Dal.Services;
using Microsoft.AspNetCore.Mvc;

namespace BProfTemaLab.Controllers
{
    public class NewSupplierController : Controller
    {
        public ProductService productService;
        public NewSupplierController(ProductService productService)
        {

        }
        public IActionResult Index(int id)
        {
            var product = productService.GetProductById(id);
            return View();
        }
    }
}