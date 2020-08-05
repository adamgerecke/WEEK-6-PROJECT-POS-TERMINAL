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

        public static void ShowMenu()
        {
            for (int i = 0; i < StoreItems.StoreInventory.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {StoreItems.StoreInventory[i]}");
            }
            Console.WriteLine($"{StoreItems.StoreInventory.Count + 1}. Cash Out.");
            Console.WriteLine($"{StoreItems.StoreInventory.Count + 2}. Quit.");

        }


    }
}
