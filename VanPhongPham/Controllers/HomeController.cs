﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VanPhongPham.Models;

namespace VanPhongPham.Controllers
{
    public class HomeController : Controller
    {
        private readonly ProductRepository _productRepository;
        public HomeController()
        {
            _productRepository = new ProductRepository();
        }
        // GET: Home
        public ActionResult Index(string productID)
        {
            var products = _productRepository.GetMainImageByProductId(productID);
            return View(products);
        }

    }
}