//Scenario:

//Imagine you are now a junior software developer in a BPO company. You are tasked by your team manager to create a simple program for the company with the following instruction and requirements:

//1.Accept complete name of the user.

//2. Accept  two (2) numbers as user input.

//3. Compute for the sum, difference, product, and quotient of the two numbers.

//4. Display the user complete name and result of each operation.

//Test Data:
//Input user complete name: John Doe
//Input the first number: 25
//Input the second number: 4
//Expected Output:
//25 + 4 = 29
//25 - 4 = 21
//25 x 4 = 100 
//25 / 4 = 6
//25 mod 4 = 1

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Dungganon_Activity_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declare the variables
            double num1, num2, sum, difference, product, quotient, modulo;

            //Ask for User Input
            Console.WriteLine("Input user complete name:");
            Console.ReadLine();

            //Ask for Two Numbers
            Console.WriteLine("Input the first number: ");
            num1 = double.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number: ");
            num2 = double.Parse(Console.ReadLine());

            //Calculate the Two Numbers
            sum = num1 + num2;
            difference = num1 - num2;
            product = num1 * num2;
            quotient = num1 / num2;
            modulo = num1 % num2;

            //Display the Results
            Console.WriteLine($"{num1} + {num2} = {sum}");
            Console.WriteLine($"{num1} - {num2} = {difference}");
            Console.WriteLine($"{num1} * {num2} = {product}");
            Console.WriteLine($"{num1} / {num2} = {quotient}");
            Console.WriteLine($"{num1} mod {num2} = {modulo}");
            Console.ReadLine();

        }
    }
}
