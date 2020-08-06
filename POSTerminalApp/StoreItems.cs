using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminalApp
{
    public class StoreItems
    {
        public static List<Product> StoreInventory = new List<Product>();


        public static void AddItem(Product aProduct)
        {
            StoreInventory.Add(aProduct);
        }
        
    }
}
