using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminalApp
{
    public class Product
    {
        private string Name { get; set; }
        private string Categry { get; set; }
        private string Description { get; set; }
        private Decimal Price { get; set; }

        public Product(string aName, string aCategory, string aDescription, Decimal aPrice)
        {
            Name = aName;
            Categry = aCategory;
            Description = aDescription;
            Price = aPrice;
        }
        public Product(string aName)
        {
            Name = aName;
        }
        public Product(Decimal aPrice)
        {
            Price = aPrice;
        }


        public override string ToString()
        {
            return $"Product Name:{Name}\tCategory:{Categry}\tDescription:{Description}\tPrice:{Price}";
        }

    }
}
