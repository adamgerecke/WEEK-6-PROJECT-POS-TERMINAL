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
        public static List<Decimal> LineCost = new List<decimal>();

        public static void ClearLineCost()
        {
            LineCost.Clear();
        }
        public static void AddToCart(int UserInput)
        {
            Cart.Add(StoreItems.StoreInventory[UserInput - 1]); //adds the product selected - 1 to match the users input.
            ProductName.Add(StoreItems.StoreInventory[UserInput - 1].GetName);
            ProductPrice.Add(StoreItems.StoreInventory[UserInput - 1].GetPrice);
            LineCost.Add(StoreItems.StoreInventory[UserInput - 1].GetPrice);
        }

        public static Decimal LineTotal()
        {
            Decimal lineCost = 0.00m;
            for (int i=0; i<LineCost.Count; i++)
            {
                lineCost = lineCost + LineCost[i];
            }
            return lineCost;
        }

        public static Decimal SalesTax()
        {
            Decimal salesTax = 0.06m;
            return salesTax;
        }

        public static Decimal SubTotal()
        {
            Decimal total = 0.00m;

            if(Cart.Count != 0)
            {
                for (int i = 0; i< ProductPrice.Count; i++)
                {
                    total = total + ProductPrice[i];
                }
            }
            else
            {
                total = 0.00m;
            }

            return total;
        }

        public static Decimal GrandTotal(Decimal total)
        {
            Decimal grandTotal = (total * SalesTax()) + total;
            return grandTotal;
        }

        public static Decimal ChangeBack(Decimal UserPay)  //ADD SOME LOGIC TO MAKE SURE THEY GIVE YOU ENOUGH MONEY
        {
            Decimal grandTotal = Math.Round(GrandTotal(SubTotal()),2);
            Decimal userChange = UserPay - grandTotal;
            return userChange;
        }
    }
}
