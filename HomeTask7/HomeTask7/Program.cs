using System;

namespace HomeTask7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Laptop notebook = new Laptop("Asus", "ROG Strix",2600);
            notebook.Price = 2600;

            Laptop[] laptops = new Laptop[2];
            for (int i = 0; i < laptops.Length; i++)
            {
                Console.WriteLine("Enter Brand:");
                string brand = Console.ReadLine();

                Console.WriteLine("Enter Model:");
                string model = Console.ReadLine();

                Console.WriteLine("Enter Price:");
                string priceStr = Console.ReadLine();
                int price = Convert.ToInt32(priceStr);

                Laptop lp = new Laptop(brand, model, price);

                laptops[i] = lp;

            }
            double sum = 0;
            for (int i = 0; i < laptops.Length; i++)
            {
                sum += laptops[i].Price;
            }
            double average = sum / laptops.Length;
            Console.WriteLine(average);
        }
    }
}
