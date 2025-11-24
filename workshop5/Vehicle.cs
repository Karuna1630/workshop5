using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    public class Vehicle
    {
        public string Brand { get; set; }
        public int speed {  get; set; }

        public Vehicle(string brand, int speed)
        {
            this.Brand = brand;
            this.speed = speed;
        }


        public void Start()
        {
            Console.WriteLine($"{Brand} is starting.");
        }

        public void Stop()
        {
            Console.WriteLine($"{Brand} is stopping.");
        }

        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {speed} km/h");
        }


    }
}

