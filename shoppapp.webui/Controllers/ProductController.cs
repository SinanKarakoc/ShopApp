using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using shoppapp.webui.Data;
using shoppapp.webui.Models;


namespace shoppapp.webui.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            //View'e veri aktarım yöntemleri
            //ViewBag,Models,ViewData 
            var product = new ProductEntity { Name = "monster", Price = 4300, Description = "Gaming Pc" };           
            ViewBag.Category = "Laptoplar";
            ViewBag.Product = product;


            return View();
        }

        public IActionResult ProductList(int? id, string q)
        {
            var products = ProductRepository.Products;

            if (id != null)
            {
                products = products.Where(p => p.CategoryId == id).ToList();
            }

            if (!string.IsNullOrEmpty(q))
            {
                products = products.Where(a => a.Name.ToLower().Contains(q.ToLower()) || a.Description.ToLower().Contains(q.ToLower())).ToList();
            }

            var productViewModel = new ProductViewModel()
            {
                Products = products
            };

            return View(productViewModel);
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(new ProductEntity());//null almamak için
        }
        [HttpPost]
        public IActionResult Create(ProductEntity p)
        {
            if (ModelState.IsValid)
            {
                ProductRepository.AddProduct(p);
                return RedirectToAction("ProductList");
            }
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(p);
        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            ViewBag.Categories = new SelectList(CategoryRepository.Categories, "CategoryId", "Name");
            return View(ProductRepository.GetProductById(id));
        }
        [HttpPost]
        public IActionResult Edit(ProductEntity p)
        {
            ProductRepository.EditProduct(p);
            return RedirectToAction("ProductList");
        }
        public IActionResult Detail(int id)
        {
            return View(ProductRepository.GetProductById(id));
        }

        [HttpPost]
        public IActionResult Delete(int ProductId)
        {
            ProductRepository.DeleteProduct(ProductId);
            return RedirectToAction("ProductList");
        }
    }
}