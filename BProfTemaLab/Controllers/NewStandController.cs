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
    public class NewStandController : Controller
    {
        public ProductService ProductService;
        public StandService StandService;
        public NewStandController(ProductService productService, StandService standService)
        {
            ProductService = productService;
            StandService = standService;
        }
        public IActionResult NewStand()
        {
            List<SelectListItem> products = new List<SelectListItem>();
            products = ProductService.DbContext.Product
                .Select(p => new SelectListItem
                {
                    Text = p.Name,
                    Value = p.Id.ToString()
                }).ToList();


            ViewBag.MySkills = products;
            return View();
        }

        [HttpPost]
        public ActionResult AddStand(int productId, int purchased, int scrap, int sold)
        {
            ProductDto product = ProductService.GetProductById(productId);
            var stand = new Stand
            {
                ProductId = product.Id,
                StartingQuantity = product.Quantity,
                Purchased = purchased,
                Sold = sold,
                Scrap = scrap,
                ClosingQuantity = product.Quantity + purchased - scrap - sold,
                Loss = scrap * product.UnitPrice,
                Income = (sold - scrap) * product.UnitPrice
            };

            StandService.AddStand(stand);
            ProductService.ChangeProductQuantity(productId, product.Quantity + purchased - scrap - sold);
            return RedirectToAction("NewStand", "NewStand");
        }

        [HttpPost]
        public ActionResult DeleteStand(int standId)
        {
            StandService.DeleteStand(standId);
            return RedirectToAction("Standok", "Home");
        }

        [HttpPost]
        public ActionResult DeleteProduct(int productId)
        {
            ProductService.DeleteProduct(productId);
            return RedirectToAction("Termekek", "Home");
        }
    }
}