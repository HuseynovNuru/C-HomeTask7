using System;
using System.Collections.Generic;
using System.Text;

namespace DersTekrari
{
    internal class Product
    {
        public string name;
        public string type;
        public double price;

        public Product(string name, string type, double price)
        {
            this.name = name;
            this.type = type;
            this.price = price;
        }

        public string ShowInfo()
        {
            return $"Name:{name},Type:{type},Price:{price}";
        }
            
    }
}
