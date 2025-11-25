using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    public class Smartphone : ElectronicDevice
    {
        // Constructor
        public Smartphone(string brand, double price) : base(brand, price)
        {
        }

        // Extra method for Smartphone
        public void EnableCamera()
        {
            Console.WriteLine("Smartphone camera is now enabled.");
        }

        // Override abstract method
        public override void ShowInfo()
        {
            Console.WriteLine("----- Smartphone Information -----");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Price: Rs {Price}");
        }
    }
}

