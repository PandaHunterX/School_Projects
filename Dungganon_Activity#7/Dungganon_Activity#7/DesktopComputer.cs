using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dungganon_Activity_7
{
    internal class DesktopComputer : PersonalComputer
    {
        public DesktopComputer(string brand, string model, double price, string processor, string ram, string hard_drive)
        {
            this.Brand = brand;
            this.Model = model;
            this.Price = price;
            this.Processor = processor;
            this.RAM = ram;
            this.Hard_Drive = hard_drive;
        }

        public void getDesktopComputerInfo()
        {
            Console.WriteLine("Please enter Desktop Computer Details");
            Console.Write("Enter Brand: ");
            Brand = Console.ReadLine();
            Console.Write("Enter Model: ");
            Model = Console.ReadLine();
            Console.Write("Enter Price: ");
            Price = Double.Parse(Console.ReadLine());
            Console.Write("Enter Processor: ");
            Processor = Console.ReadLine();
            Console.Write("Enter RAM: ");
            RAM = Console.ReadLine();
            Console.Write("Enter HDD: ");
            Hard_Drive = Console.ReadLine();
        }

        public void showDesktopComputerInfo()
        {
            Console.WriteLine($"Brand: {Brand}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Price: Php {Price}");
            Console.WriteLine($"Processor: {Processor}");
            Console.WriteLine($"RAM: {RAM}");
            Console.WriteLine($"HDD: {Hard_Drive}\n");
        }
    }
}
