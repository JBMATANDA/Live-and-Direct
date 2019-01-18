using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Store.Models.HelperMethods
{
    public class Cart
    {
        private static Cart cart;

        private Cart() { }

        public static Cart Instance
        {
            get
            {
                if (cart == null)
                {
                    cart = new Cart();
                }
                return cart;
            }
        }
        public void AddItemToCart()
        {

        }

    }
}