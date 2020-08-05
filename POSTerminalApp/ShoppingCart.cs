using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace POSTerminalApp
{
    public class ShoppingCart
    {
        public static List<Product> Cart = new List<Product>();

        ShoppingCart myCart = new ShoppingCart();
        StoreItems myItems = new StoreItems();

        public static void AddToCart(int UserInput)
        {
            Cart.Add(StoreItems.StoreInventory[UserInput - 1]); //adds the product selected - 1 to match the users input.
        }

        public static Decimal GetTotal()
        {
            Decimal total = 0.00m;

            if(Cart.Count > 0)
            {
                total = Cart.Last
            }



            return total;
        }

        public static void CheckOut()
        {
            for (int i = 0; i < ShoppingCart.Cart.Count; i++)
            {
                Console.WriteLine($"{ShoppingCart.Cart[i]}");
            }

        }

    }
}
