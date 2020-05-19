using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BProfTemaLab.Dal.Dtos;
using BProfTemaLab.Dal.Entities;
using BProfTemaLab.Dal.Services;
using Microsoft.AspNetCore.Mvc;

namespace BProfTemaLab.Controllers
{
    public class NewProductController : Controller
    {
        public ProductService ProductService;
        public NewProductController(ProductService productService)
        {
            ProductService = productService;
        }
        public IActionResult NewProduct()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(string name, int unitPrice, int quantity) 
        {
            var product = new Product
            {
                Name = name,
                SupplierId = 1,
                UnitPrice = unitPrice,
                Quantity = quantity
            };
            ProductService.AddProduct(product);
            return RedirectToAction("NewProduct", "NewProduct");
        }

        [HttpPost]
        public ActionResult DeleteProduct(int productId)
        {
            ProductService.DeleteProduct(productId);
            return RedirectToAction("Termekek", "Home");
        }
    }
}