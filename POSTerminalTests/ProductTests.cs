using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using POSTerminalApp;

namespace POSTerminalTests
{
    public class ProductTests
    {
        public static List<Product> StoreInventory = new List<Product>();


        [Fact]
        public void Test1() // Test to make sure all 12 items are being added to the correct list.
        {

            Assert.Equal(12, StoreItems.StoreInventory.Count);
        }
    }
}

