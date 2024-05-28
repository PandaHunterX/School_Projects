//Scenario:

//After completing the previous task given by your team manager, you are now expected to improve that application wherein users would have more control in terms of usage and based on preference. You are given instructions below on how to improve the application:

//Part1:

//1.Accept complete name of the user.

//2. Accept  two (2) numbers as user input.

//3. Present the four mathematical operations (addition, subtraction, multiplication, division) to the user as options of using the application.

//4.Allow the user to select mathematical operation of choice.

//3. Compute the result of the two user input numbers depending on the selected operation of the user and display it afterwards.

 

//Part 2

//1. Display the user's complete name.

//2. Display the result for each mathematical operation.

//3. Compare each result and display which of the four results is the lowest and which is the highest one.

 

//Test Data:

//Input user complete name: John Doe
//Input the first number: 25
//Input the second number: 5
//Please select a mathematical operation to display the result (+ - * /):  +
//The sum of 25 and 5 is 30.

//John Doe
//25 + 5 = 30
//25 - 5 = 20
//25 x 5 = 125
//25 / 5 = 5
//The lowest result is 5, and the highest result is 125.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungganon_Activity3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char opr;
            int num1;
            int num2;
            int result = 0;
            string operation = "";
            string name;
            int lowest = 0;
            int highest = 0;

            Console.WriteLine("Input user complete name: ");
            name = Console.ReadLine();

            Console.WriteLine("Input the first number: ");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number ");
            num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Please select a mathematical operation to display the result (+ - * /): ");
            opr = char.Parse(Console.ReadLine());

            switch (opr)
            {
                case '+':
                    result = num1 + num2;
                    operation = "Sum";
                    break;
                case '-':
                    result = num1 - num2;
                    operation = "Difference";
                    break;
                case '*':
                    result = num1 * num2;
                    operation = "Product";
                    break;
                case '/':
                    result = num1 / num2;
                    operation = "Quotient";
                    break;
                default:
                    Console.WriteLine("Please enter the correct operation");
                    break;
            }

            Console.WriteLine($"The {operation} of {num1} and {num2} is {result}");
            Console.WriteLine("");
            Console.WriteLine(name);

            opr = '+';
            int result1 = num1 + num2;
            Console.WriteLine($"{num1} {opr} {num2} = {result1}");

            opr = '-';
            int result2 = num1 - num2;
            Console.WriteLine($"{num1} {opr} {num2} = {result2}");

            opr = '*';
            int result3 = num1 * num2;
            Console.WriteLine($"{num1} {opr} {num2} = {result3}");

            opr = '/';
            int result4 = num1 / num2;
            Console.WriteLine($"{num1} {opr} {num2} = {result4}");

            if (result1 > result2 && result1 > result3 && result1 > result4)
            {
                highest = result1;
            }
            else if (result2 > result3 && result2 > result4)
            {
                highest = result2;
            }
            else if (result3 > result4)
            {
                highest = result3;
            }
            else
            {
                highest = result4;
            }

            if (result1 < result2 && result1 < result3 && result1 < result4)
            {
                lowest = result1;
            }
            else if (result2 < result3 && result2 < result4)
            {
                lowest = result2;
            }
            else if (result3 < result4)
            {
                lowest = result3;
            }
            else
            {
                lowest = result4;
            }
            Console.WriteLine("");
            Console.WriteLine($"The lowest result is {lowest}, and the highest result is {highest}");
            Console.ReadLine();
        }
    }
}
