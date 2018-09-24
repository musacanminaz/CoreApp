using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using App.Business.Abstract;
using App.Entities.Concrete;

namespace App.Business.Concrete
{
    public class CartManager : ICartService
    {
        public void AddToCart(Cart cart, Product product, int quantity)
        {
            CartLine cartLine = cart.CartLines.FirstOrDefault(p => p.Product.ProductId == product.ProductId);

            if (cartLine != null)
            {
                cartLine.Quantity += quantity;
                return;
            }
            cart.CartLines.Add(new CartLine { Product = product, Quantity = quantity });
        }

        public void RemoveFromCart(Cart cart, int productId)
        {
            cart.CartLines.Remove(cart.CartLines.FirstOrDefault(c => c.Product.ProductId == productId));
        }

        public List<CartLine> List(Cart cart)
        {
            return cart.CartLines;
        }
    }
}
