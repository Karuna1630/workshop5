using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    // A simple Printer class demonstrating METHOD OVERLOADING
    internal class Printer
    {
        // Method 1: Prints a string message
        public void Print(string message) 
        {
            Console.WriteLine($"Message:{ message}");
        }


        // Method 2: Prints an integer number
        // This has a different parameter type → example of method overloading
        public void Print(int number)
        {
            Console.WriteLine($"Number:{number}");

        }

        // Method 3: Prints the same message multiple times
        // Overloaded because it has different number of parameters
        public void Print(string message, int count)
        {
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"{i + 1}: {message}");
            }
        }
    }
}
