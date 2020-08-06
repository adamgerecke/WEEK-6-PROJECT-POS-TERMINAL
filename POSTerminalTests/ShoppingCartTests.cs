using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using POSTerminalApp;

namespace POSTerminalTests
{
    public class ShoppingCartTests
    {
        [Fact]
        public void Test1()
        {
            Assert.Equal(0.00m,ShoppingCart.SubTotal()); // verifies that the total starts at 0.00 dollars.
        }

        [Fact]
        public void Test2()
        {
            Assert.Equal(0.06m, ShoppingCart.SalesTax()); //verifies SalesTax is 6 Cents on the dollar.
        }

        [Fact]
        public void Test3()
        {
            Assert.Equal(10.60m, ShoppingCart.GrandTotal(10.00m));
        }

    }
}
