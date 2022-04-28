using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EFC2.Models;

namespace EFC2.Controllers
{
    public class ProductController : Controller
    {
        [Route("Product/Index")]
        public IActionResult Index()
        {
            return View();
        }
        [Route("Product/Create")]

        public IActionResult Create(Product P)
        {
            if (ModelState.IsValid)
            {
                ProductDBContext dBcontext = new ProductDBContext();
                dBcontext.Add(P);
                dBcontext.SaveChanges();
                return Content("Saved");
            }
            return View("Index",P);
        }

    }
}
