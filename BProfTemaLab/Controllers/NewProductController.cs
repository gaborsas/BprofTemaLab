using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BProfTemaLab.Dal.Dtos;
using BProfTemaLab.Dal.Entities;
using BProfTemaLab.Dal.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace BProfTemaLab.Controllers
{
    public class NewProductController : Controller
    {
        public ProductService ProductService;
        public SupplierService SupplierService;
        public NewProductController(ProductService productService, SupplierService supplierService)
        {
            ProductService = productService;
            SupplierService = supplierService;
        }
        public IActionResult NewProduct()
        {
            List<SelectListItem> suppliers = new List<SelectListItem>();
            suppliers = SupplierService.DbContext.Supplier
                .Select(s => new SelectListItem {
                    Text = s.Name,
                    Value = s.Id.ToString()
                }).ToList();

 
            ViewBag.MySkills = suppliers;  
            return View();
        }

        [HttpPost]
        public ActionResult AddProduct(int supplierId, string name, int unitPrice, int quantity) 
        {
            var product = new Product
            {
                Name = name,
                SupplierId = supplierId,
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