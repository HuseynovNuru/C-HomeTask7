using System;

namespace DersTekrari
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Car mashin = new Car("Land Rover", "Range Rover", 4.4, 2007, 30000);
            
            Console.WriteLine(mashin.ShowInfo());


            Product pro = new Product("Nescafe", "Kofe", 0.80);

            Console.WriteLine(pro.ShowInfo());
        }
    }
}
