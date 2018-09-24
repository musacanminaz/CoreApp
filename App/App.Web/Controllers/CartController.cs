using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using App.Business.Abstract;
using App.Web.Services;
using Microsoft.AspNetCore.Mvc;

namespace App.Web.Controllers
{
    public class CartController: Controller
    {
        private ICartSessionService _cartSessionService;
        private ICartService _cartService;
        private IProductService _productService;

        public CartController(ICartSessionService cartSessionService, ICartService cartService, IProductService productService)
        {
            _cartSessionService = cartSessionService;
            _cartService = cartService;
            _productService = productService;
        }

        public IActionResult AddToCart(int productId, int quantity)
        {
            var productToBeAdded = _productService.GetById(productId);

            var cart = _cartSessionService.GetCart();

            _cartService.AddToCart(cart, productToBeAdded, quantity);

            _cartSessionService.SetCart(cart);

            TempData.Add("message", String.Format("{0} adet {1} sepete eklendi",quantity, productToBeAdded.ProductName));

            return RedirectToAction("List", "Product");
        }

        public IActionResult RemoveFromCart(int productId)
        {
            var cart = _cartSessionService.GetCart();

            _cartService.RemoveFromCart(cart, productId);

            _cartSessionService.SetCart(cart);

            return RedirectToAction("List", "Product");
        }

    }
}
