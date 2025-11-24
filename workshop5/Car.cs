using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace workshop5
{
    public class Car : Vehicle
    {
        public int Seats { get; set; }

        public Car(string brand, int speed, int seats) : base(brand, speed)
        {
            this.Seats = seats;
        }

        public void DisplayCarInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Seats: {Seats}");
        }

    }
}
