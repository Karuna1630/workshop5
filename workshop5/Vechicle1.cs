using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{ 
    // Abstract class
    public abstract class Vehicle1
    {   // Abstract methods: MUST be implemented by derived classes
        public abstract void StartEngine();
        public abstract void StopEngine();

        // Concrete method
        public void Display()
        {
            Console.WriteLine("It is a vehicle");
        }
    }
}
