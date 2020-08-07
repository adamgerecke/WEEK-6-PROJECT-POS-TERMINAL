using System;

namespace POSTerminalApp
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepShopping = true;
            Decimal userTender = 0.00m;

            static void ShowMenu()
            {
                for (int i = 0; i < StoreItems.StoreInventory.Count; i++)
                {
                    Console.WriteLine($"{i + 1+".",-4} {StoreItems.StoreInventory[i]}");
                }
                Console.WriteLine($"{StoreItems.StoreInventory.Count + 1+".",-4} Cash Out.");
                //Console.WriteLine($"{StoreItems.StoreInventory.Count + 2+".",-4} Quit Order.");
            }

            static void CheckOut()
            {
                Decimal grandTotal = Math.Round(ShoppingCart.GrandTotal(ShoppingCart.SubTotal()),2);
                Decimal subTotal = Math.Round(ShoppingCart.SubTotal(), 2);
                Decimal salesTax = Math.Round(ShoppingCart.SalesTax() * ShoppingCart.SubTotal(), 2);

                Console.WriteLine();
                Console.WriteLine("Thank you for shopping with us.");
                Console.WriteLine($"Your Subtotal is: {subTotal}");
                Console.WriteLine($"Sales Tax for the total purchase is: {salesTax}");
                Console.WriteLine($"Your Grandtotal is: {grandTotal}");
            }

            static void PrintReceipt(Decimal userTender)
            {
                Decimal grandTotal = Math.Round(ShoppingCart.GrandTotal(ShoppingCart.SubTotal()), 2);
                Decimal subTotal = Math.Round(ShoppingCart.SubTotal(), 2);
                Decimal salesTax = Math.Round(ShoppingCart.SalesTax() * ShoppingCart.SubTotal(), 2);

                Console.WriteLine($"Items\t\tPrice");
                Console.WriteLine("----------------------");
                for(int i = 0; i<ShoppingCart.Cart.Count; i++)
                {
                    Console.Write($"*{ShoppingCart.ProductName[i]}\t{ShoppingCart.ProductPrice[i]}*\n");
                }
                Console.WriteLine("----------------------");
                Console.WriteLine($"Subtotal:{subTotal}");
                Console.WriteLine($"Sales Tax:{salesTax}");
                Console.WriteLine($"Grand Total:{grandTotal}");
                Console.WriteLine($"Amount Tendered:{userTender}");
                Console.WriteLine($"Change:{ShoppingCart.ChangeBack(userTender)}");
                Console.WriteLine();
                Console.WriteLine("Press Enter to return to main Menu, and start a new order.");
                ShoppingCart.Cart.Clear();
                ShoppingCart.ProductName.Clear();
                ShoppingCart.ProductPrice.Clear();
                Console.ReadLine();

            }

            StoreItems.AddItem(new Product("Dirt Block", "Earth", "A simple common block, brown and course", 10.00m));
            StoreItems.AddItem(new Product("Stone Block", "Earth", "A simple common block, Gray and smooth", 12.50m));
            StoreItems.AddItem(new Product("Gravel Block", "Earth", "Even though this is made of many small rocks, it keeps its shape", 9.00m));
            StoreItems.AddItem(new Product("Sand Block", "Earth", "A common block, can be used as both a building aid, and landscaping.", 9.85m));
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
            while (keepShopping)
            {
                ShoppingCart.ClearLineCost();
                ShowMenu();
                Console.WriteLine();
                Console.Write("What can we get for you today? (1-13):");
                bool isNumber = int.TryParse(Console.ReadLine(), out int userInput);
                //int userInput = int.Parse(Console.ReadLine());
                while (!isNumber || !(userInput > 0 && userInput <= 13))
                {
                    Console.Write("Enter a valid number.");
                    isNumber = int.TryParse(Console.ReadLine(), out userInput);
                }
                if (userInput > 0 && userInput <= 12)
                {
                    Console.Write("How many of that item would you like?:");
                    int userAmount = int.Parse(Console.ReadLine());
                    for (int i = 0; i < userAmount; i++)
                    {
                        ShoppingCart.AddToCart(userInput);
                    }
                    Console.WriteLine($"You ordered {userAmount} of {StoreItems.StoreInventory[userInput - 1].GetName} for a total of {ShoppingCart.LineTotal()}.");
                }
                else if (userInput == 13)
                {
                    if (ShoppingCart.Cart.Count > 0)
                    {
                        CheckOut();
                        PrintReceipt(0);
                    }
                    else
                    {
                        
                    }
                }

                Console.Write("Would you like to order something else? (y/n):");
                string keepGoing = Console.ReadLine().ToUpper();
                if (keepGoing == "Y" || keepGoing == "YES")
                {
                    continue;
                }
                else if (keepGoing == "N" || keepGoing == "NO")
                {
                    CheckOut();
                    Console.WriteLine();
                    Console.Write("MineCraft Blocks Co. accepts Cash only. How much will cash would you like to tender?:");
                    bool isMoney = Decimal.TryParse(Console.ReadLine(), out userTender);
                    while (!isMoney && userInput < Math.Round(ShoppingCart.GrandTotal(ShoppingCart.SubTotal()), 2))
                    {
                        Console.Write("That is not a valid input for amount owed to the store.");
                        isMoney = Decimal.TryParse(Console.ReadLine(), out userTender);
                    }
                    if (userTender >= Math.Round(ShoppingCart.GrandTotal(ShoppingCart.SubTotal()), 2))
                    {
                        //Console.WriteLine($"Your change is {ShoppingCart.ChangeBack(userTender)}");
                        Console.WriteLine();
                        PrintReceipt(userTender);
                    }
                    else
                    {
                        Console.WriteLine("That is not enough Money. You have to supply exact change or more than your total");

                    }

                }
                else
                {
                    Console.WriteLine("That is not a valid input. Please try again.");
                    continue;
                }

            }

        }
    }
}
