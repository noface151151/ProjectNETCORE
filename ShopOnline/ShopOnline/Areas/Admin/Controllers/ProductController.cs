using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ShopOnline.Data;
using ShopOnline.Data.Models;

namespace ShopOnline.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProductController : Controller
    {
        private UnitOfWork unitOfWork = new UnitOfWork();
        public IActionResult Index()
        {
            var productList = unitOfWork.ProductRepository.GetAll();
            return View(productList);
        }

        [HttpPost]
        public IActionResult AddProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.ProductRepository.Create(product);
                unitOfWork.Save();
                unitOfWork.Dispose();

            }
            return View("AddProduct");
        }
        [HttpGet]
        public IActionResult AddProduct()
        {
            return View("AddProduct");
        }

        [HttpPost]
        public IActionResult UpdateProduct(Product product)
        {
            if (ModelState.IsValid)
            {
                unitOfWork.ProductRepository.Update(product);
                unitOfWork.Save();
                unitOfWork.Dispose();

            }
            return View("UpdateProduct");
        }
        [HttpGet]
        public IActionResult GetById(int id)
        {
            return View(unitOfWork.ProductRepository.GetById(id));
        }
    }
}