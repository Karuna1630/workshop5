using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace workshop5
{
    public class ElectronicsStore
    {
        // List to store ElectronicDevice objects
        private List<ElectronicDevice> devices = new List<ElectronicDevice>();

        // Add a device to the store
        public void AddDevice(ElectronicDevice device)
        {
            devices.Add(device);
            Console.WriteLine($"{device.Brand} added to the store.");
        }

        // Remove a device from the store
        public void RemoveDevice(ElectronicDevice device)
        {
            if (devices.Remove(device))
            {
                Console.WriteLine($"{device.Brand} removed from the store.");
            }
            else
            {
                Console.WriteLine("Device not found in the store.");
            }
        }

        // Display information of all devices
        public void ShowAllDeviceDetails()
        {
            Console.WriteLine("\n===== All Devices in Store =====");

            foreach (var device in devices)
            {
                // Call overridden ShowInfo() (polymorphism)
                device.ShowInfo();

                // DOWNCASTING - Call child-specific methods
                if (device is Laptop laptop)
                {
                    laptop.TurnOnBattery();
                }
                else if (device is Smartphone smartphone)
                {
                    smartphone.EnableCamera();
                }

                Console.WriteLine(); // Extra line between devices
            }
        }
    }
}
