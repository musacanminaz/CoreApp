using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Business.Abstract;
using App.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class ProductController : Controller
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        public IActionResult Index(int page, int category=0)
        {
            int pageSize = 10;

            var products = _productService.GetByCategory(category);
            ProductListViewModel model = new ProductListViewModel
            {
                Product = products.Skip((page -1)*pageSize).Take(pageSize).ToList(),
                PageCount = (int)Math.Ceiling(products.Count/(double)pageSize),
                PageSize = pageSize,
                CurrentCategory = category,
                CurrentPage = page,
            };
            return View(model);
        }
    }
}