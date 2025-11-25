using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    public class Vehicle
    {
        //creating public properties
        public string Brand { get; set; }
        public int speed {  get; set; }

        // Constructor to initialize brand and speed
        public Vehicle(string brand, int speed)
        {
           Brand = brand;
           speed = speed;
        }

        // Method to simulate starting the vehicle
        public void Start()
        {
            Console.WriteLine($"{Brand} is starting.");
        }


        // Method to simulate stopping the vehicle
        public void Stop()
        {
            Console.WriteLine($"{Brand} is stopping.");
        }

        // Method to display general vehicle information
        public void DisplayInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Speed: {speed} km/h");
        }


    }
}

