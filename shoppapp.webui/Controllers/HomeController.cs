using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using shoppapp.webui.Data;
using shoppapp.webui.Models;

namespace shoppapp.webui.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var productViewModel = new ProductViewModel()
            {
                Products = ProductRepository.Products
            };
            return View(productViewModel);
        }
        public ActionResult About()
        {
            return View();
        }
        public ActionResult Contact()
        {
            return View("MyView");
        }
    }
}