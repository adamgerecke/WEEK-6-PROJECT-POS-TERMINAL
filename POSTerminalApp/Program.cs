using System;

namespace POSTerminalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepShopping = true;

            static void ShowMenu()
            {
                for (int i = 0; i < StoreItems.StoreInventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {StoreItems.StoreInventory[i]}");
                }
                Console.WriteLine($"{StoreItems.StoreInventory.Count + 1}. Cash Out.");
                Console.WriteLine($"{StoreItems.StoreInventory.Count + 2}. Quit.");
            }

            static void CheckOut()
            {
                Decimal grandTotal = Math.Round(ShoppingCart.GrandTotal(ShoppingCart.SubTotal()),2);
                Decimal subTotal = Math.Round(ShoppingCart.SubTotal(), 2);
                Decimal salesTax = Math.Round(ShoppingCart.SalesTax() * ShoppingCart.SubTotal(), 2);

                Console.WriteLine("Thank you for shopping with us.");
                Console.WriteLine($"Your Subtotal is: {subTotal}");
                Console.WriteLine($"Sales Tax for the total purchase is: {salesTax}");
                Console.WriteLine($"Your Grandtotal is: {grandTotal}");

            }


            StoreItems.AddItem(new Product("Dirt Block", "Earth     ", "A simple common block, brown and course", 10.00m));
            StoreItems.AddItem(new Product("Stone Block", "Earth     ", "A simple common block, Gray and smooth", 12.50m));
            StoreItems.AddItem(new Product("Gravel Block", "Earth     ", "Even though this is made of many small rocks, it keeps its shape", 9.00m));
            StoreItems.AddItem(new Product("Sand Block", "Earth     ", "A common block, can be used as both a building aid, and landscaping.", 9.85m));
            StoreItems.AddItem(new Product("Iron Ore", "Mineral", "Your first step in teching up. Collect a lot of this, as you will need it.", 20.00m));
            StoreItems.AddItem(new Product("Gold Ore", "Mineral", "A simple way to flex on other players. Build a room out of this, and be the talk of the server.", 60.45m));
            StoreItems.AddItem(new Product("Diamond Ore", "Mineral", "DIAMONDS!!! Who doesn't like finding diamonds?", 100.00m));
            StoreItems.AddItem(new Product("Redstone Ore", "Mineral", "Use this to start automating simple tasks, your game will never be the same without it.", 75.50m));
            StoreItems.AddItem(new Product("Glass Block", "Decoration", "Windows? See through floor? This block is for you", 12.85m));
            StoreItems.AddItem(new Product("Prismarine", "Decoration", "Decorate your base in style, and show the rest of the server you are not afraid to dive deep in the ocean", 41.99m));
            StoreItems.AddItem(new Product("Oak  Log", "Decoration", "What base is complete, without some sort of wood? Either as an accent, or a main block. You can't go wrong.", 3.50m));
            StoreItems.AddItem(new Product("Purpur Block", "Decoration", "Who says there are no purple bricks in Minecraft?", 32.95m));

            Console.WriteLine("Welcome to MineCraft Blocks Co.\nWhere you can purchase your favorite MineCraft Block in Real Life!");
            Console.WriteLine();
            
            ShowMenu();
            Console.WriteLine();
            Console.Write("What can we get for you today? (1-12):");
            int userInput = int.Parse(Console.ReadLine());
            Console.Write("How many of that item would you like?:");
            int userAmount = int.Parse(Console.ReadLine());
            ShoppingCart.ClearLineCost();
            for(int i = 0; i < userAmount; i++)
            {
                ShoppingCart.AddToCart(userInput); 
            }
            Console.WriteLine(ShoppingCart.LineTotal());
            
            CheckOut();
            
         
            

            


        }
    }
}
