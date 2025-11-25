using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    // Bike inherits from Vehicle and implements abstract methods
    public class Bike1:Vehicle1
    {
        public override void StartEngine()
        {
            Console.WriteLine("Bike engine is starting...");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Bike engine is stopping...");
        }
    }
}
