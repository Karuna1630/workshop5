using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    public class Motorcycle : Vehicle

    {
        public int EngineCapacity { get; set; }

        public Motorcycle(string brand, int speed, int engineCapacity) : base(brand, speed)
        {
            this.EngineCapacity = engineCapacity;
        }

        public void DisplayMotorcycleInfo()
        {
            DisplayInfo();
            Console.WriteLine($"Engine Capacity: {EngineCapacity} cc");
        }
    }
}

