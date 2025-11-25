using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    // Car inherits from Vehicle and implements abstract methods
    public class Car1 : Vehicle1
    {
        public override void StartEngine()
        {
            Console.WriteLine("Car engine is starting...");
        }

        public override void StopEngine()
        {
            Console.WriteLine("Car engine is stopping...");
        }
    }
}
