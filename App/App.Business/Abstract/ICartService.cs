using System;
using System.Collections.Generic;
using System.Text;
using App.Entities.Concrete;

namespace App.Business.Abstract
{
    public interface ICartService
    {
        void AddToCart(Cart cart, Product product, int quantity);
        void RemoveFromCart(Cart cart, int productId);
        List<CartLine> List(Cart cart);
    }
}
