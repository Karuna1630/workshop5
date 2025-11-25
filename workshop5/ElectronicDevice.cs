using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
   //Abstract class cannot be instantiated
    public abstract class ElectronicDevice
    {
        // Private fields (encapsulation)
        private string brand;
        private double price;

        // Public properties to access private fields
        public string Brand
        {
            get { return brand; }
            set { brand = value; }
        }

        public double Price
        {
            get { return price; }
            set
            {
                if (value > 0)
                    price = value;
                else
                    throw new ArgumentException("Price must be greater than 0.");
            }
        }

        // Constructor to initialize fields
        public ElectronicDevice(string brand, double price)
        {
            Brand = brand;   // using property
            Price = price;   // using property
        }

        // Abstract method - must be implemented in derived classes
        public abstract void ShowInfo();
    }
}
