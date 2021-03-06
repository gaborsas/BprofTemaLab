﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using BProfTemaLab.Models;
using BProfTemaLab.Dal.Services;

namespace BProfTemaLab.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Beszallitok([FromServices] SupplierService supplierService)
        {
            var suppliers = supplierService.GetSuppliersWithProducts();
            return View(suppliers);
        }

        public IActionResult Termekek([FromServices] ProductService productService)
        {
            var products = productService.GetProducts();
            return View(products);
        }

        public IActionResult UjBeszallito()
        {
            return View();
        }


        public IActionResult Admin([FromServices] UserService userService)
        {
            var users = userService.GetUsers();
            return View(users);
        }

        public IActionResult Stand()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
