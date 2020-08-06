using System;
using System.Collections.Generic;
using System.Text;

namespace POSTerminalApp
{
    public class Product
    {
        private string Name { get; set; }
        private string Category { get; set; }
        private string Description { get; set; }
        private Decimal Price { get; set; }

        public string GetName
        {
            get { return Name; }
            set { Name = value; }
        }

        public string GetCategry
        {
            get { return Category; }
            set { Category = value; }
        }

        public string GetDescription
        {
            get { return Description; }
            set { Description = value; }
        }

        public Decimal GetPrice
        {
            get { return Price; }
            set { Price = value; }
        }
        public Product(string aName, string aCategory, string aDescription, Decimal aPrice)
        {
            Name = aName;
            Category = aCategory;
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
            return $"Product Name:{Name}\tCategory:{Category}\tDescription:{Description}\tPrice:{Price}";
        }

    }
}
