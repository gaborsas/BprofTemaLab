using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BProfTemaLab.Dal.Entities;
using BProfTemaLab.Dal.Services;
using Microsoft.AspNetCore.Mvc;

namespace BProfTemaLab.Controllers
{
    public class NewSupplierController : Controller
    {
        public SupplierService SupplierService;
        public NewSupplierController(SupplierService supplierService)
        {
            SupplierService = supplierService;
        }
        public IActionResult NewSupplier()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddSupplier(string name, string phoneNumber, string email, string address)
        {
            var supplier = new Supplier
            {
                Name = name,
                PhoneNumber = phoneNumber,
                Email = email,
                Address = address
            };
            SupplierService.AddSupplier(supplier);
            return RedirectToAction("NewSupplier", "NewSupplier");
        }

        [HttpPost]
        public ActionResult DeleteSupplier(int supplierId)
        {
            SupplierService.DeleteSupplier(supplierId);
            return RedirectToAction("Beszallitok", "Home");
        }
    }
}