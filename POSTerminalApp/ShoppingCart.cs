using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace POSTerminalApp
{
    public class ShoppingCart
    {
        public static List<Product> Cart = new List<Product>();
        
        public static List<String> ProductName = new List<string>();
        public static List<Decimal> ProductPrice = new List<Decimal>();

        public static void AddToCart(int UserInput)
        {
            Cart.Add(StoreItems.StoreInventory[UserInput - 1]); //adds the product selected - 1 to match the users input.
            //ProductName[UserInput-1] = StoreItems.StoreInventory[UserInput - 1].ToString();
        }

        public static Decimal GetTotal()
        {
            Decimal total = 0.00m;

            if(Cart.Count != 0)
            {
                //total = Product
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
