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
        public void TestSubTotal()
        {
            Assert.Equal(0.00m,ShoppingCart.SubTotal()); // verifies that the total starts at 0.00 dollars.
        }

        [Fact]
        public void TestSalesTax()
        {
            Assert.Equal(0.06m, ShoppingCart.SalesTax()); //verifies SalesTax is 6 Cents on the dollar.
        }

        [Fact]
        public void TestGrandTotal()
        {
            Assert.Equal(10.60m, ShoppingCart.GrandTotal(10.00m));
        }

        [Fact]
        public void TestUserChange()
        {
            ShoppingCart.AddToCart(6); //Adds Gold Ore Block

            Assert.Equal(Math.Round(35.92m,2), ShoppingCart.ChangeBack(100.00m)); //User gives 100, gets 35.92 back since a Gold Ore Block costs 60.45 + Tax
        }

        [Fact]
        public void TestLineTotale()
        {
               Assert.Equal(Math.Round(0.00m, 2), ShoppingCart.LineTotal()); //checks if the line total is the price of the line, if 1 of the item is ordered as it was on line 32 of the test.
        }

    }
}
