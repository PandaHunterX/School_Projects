using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungganon_Activity_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter first number: ");
            double num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Please enter second number: ");
            double num2 = double.Parse(Console.ReadLine());

            Calculator calculator = new Calculator(num1, num2);

            calculator.getSum();
            calculator.getDifference();
            calculator.getProduct();
            calculator.getQuotient();

            Console.ReadLine();
        }
    }
}
