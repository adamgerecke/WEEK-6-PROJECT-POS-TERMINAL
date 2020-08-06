using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using POSTerminalApp;

namespace POSTerminalTests
{
    public class ProductTests
    {
        public List<Product> StoreInventory = new List<Product>();

        public ProductTests()
        {
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
        }


        [Fact]
        public void Test1() // Test to make sure all 12 items are being added to the correct list.
        {
            Assert.Equal(12, StoreItems.StoreInventory.Count);
        }

        [Fact]
        public void Test2() // Test to make sure all 12 items are being added to the correct list.
        {
            Assert.Equal("Purpur Block", StoreItems.StoreInventory[11].GetName);
        }

    }
}

