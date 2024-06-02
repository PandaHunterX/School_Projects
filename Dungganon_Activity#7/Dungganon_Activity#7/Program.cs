//Write a program that would serve as a Management Information System (MIS) of a computer shop. It should accept product details of a computer shop as user input, and eventually display them afterwards. The program should accept details for the following products:

//-Laptop

//- Desktop Computer

//Following items should be declared in the base class:

//-Brand

//-Model

//-Price

//-Processor

//-RAM

//-Hard Drive

//The program should make use of inheritance to properly display the needed information.Each product should have two different sets of information.

//Sample Output:

//LAPTOP

//Brand: Dell
//Model: Dell - ABC123
//Processor: Intel i7
//RAM: 8GB
//HDD: 1TB

//Brand: ACER
//Model: ACER - DEF123
//Processor: Intel i3
//RAM: 4GB
//HDD: 500GB



//DESKTOP COMPUTER

//Brand: HP
//Model: HP123456789
//Processor: Intel i7
//RAM: 32GB
//HDD: 2TB

//Brand: ACER
//Model: ACER1111333
//Processor: Intel i5
//RAM: 16GB
//HDD: 1TB

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Dungganon_Activity_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Get Pc Information
            Laptop laptop = new Laptop("","",0,"","","");
            laptop.getLaptopInfo();
            Laptop laptop2 = new Laptop("", "", 0, "", "", "");
            laptop2.getLaptopInfo();

            DesktopComputer desktopComputer = new DesktopComputer("", "", 0, "", "", "");
            desktopComputer.getDesktopComputerInfo();
            DesktopComputer desktopComputer2 = new DesktopComputer("", "", 0, "", "", "");
            desktopComputer2.getDesktopComputerInfo();

            //Output PC information
            Console.WriteLine("\nLAPTOP\n");
            laptop.showLaptopInfo();
            laptop2.showLaptopInfo();

            Console.WriteLine("\nDESKTOP COMPUTER\n");
            desktopComputer.showDesktopComputerInfo();
            desktopComputer2.showDesktopComputerInfo();

            Console.ReadLine();
        }
    }
}
