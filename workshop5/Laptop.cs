using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    public class Laptop : ElectronicDevice
    {
        // Constructor passes values to base class constructor
        public Laptop(string brand, double price) : base(brand, price)
        {
        }

        // Extra method for Laptop
        public void TurnOnBattery()
        {
            Console.WriteLine("Laptop battery is now ON.");
        }

        // Override abstract method
        public override void ShowInfo()
        {
            Console.WriteLine("----- Laptop Information -----");
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Price: Rs {Price}");
        }
    }
}
