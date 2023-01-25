using System;
using System.Collections.Generic;
using System.Text;

namespace HomeTask7
{
    internal class Laptop
    {

        public string Brand;
        public string Model;
        public int Price;
        
        
        public Laptop(string brand, string model, int price = 0)
        {
            Price = price;
            Brand = brand;
            Model = model;
        }


        public string ShowInfo()
        {
            return $"Brand {Brand}, Model {Model}, Price {Price} ";
        }
    }
   
}
