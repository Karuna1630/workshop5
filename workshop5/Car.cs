using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace workshop5
{
    // Derived class CAR that inherits from Vehicle
    public class Car : Vehicle
    {
        //creating public property Seats 
        public int Seats { get; set; }

        // Constructor receives brand, speed, and seats
        // Calls the base (Vehicle) constructor for brand & speed
        public Car(string brand, int speed, int seats) : base(brand, speed)
        {
            Seats = seats;
        }


        // Displays car details including inherited info
        public void DisplayCarInfo()
        {
            // Call DisplayInfo() from Vehicle class
            DisplayInfo();

            // Display additional car-specific info
            Console.WriteLine($"Seats: {Seats}");
        }

    }
}
