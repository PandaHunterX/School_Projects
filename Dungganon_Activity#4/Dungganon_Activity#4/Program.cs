//Problem:

//Create a program that would simply display the elements of an array. Please refer from the list of requirements below to complete this activity:

 

//Requirements:

//1.The program should accept two (2) numbers (positive or negative) as user input.

//2. The first number should serve as the start of the range, and the second number should serve as the end of the range.

//3.  After acquiring the range from the user, the program will then store all numbers into an array as its elements.

//4. Lastly, the program will then display the array and its elements following the array syntax format when declaring arrays in a program.

 

//Sample Output:

//min: -1

//max: 5

//Array element = -1

//Array element = 0

//Array element = 1

//Array element = 2

//Array element = 3

//Array element = 4

//Array element = 5

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungganon_Activity_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start;
            int end;

            Console.WriteLine("min: ");
            start = int.Parse(Console.ReadLine());

            Console.WriteLine("max: ");
            end = int.Parse(Console.ReadLine());

            int[] array = new int[end - start + 1];

            for (int i = start, j = 0; i <= end; i++, j++) 
            {
                array[j] = i;
                Console.WriteLine($"Array element = {array[j]}");
            }
            Console.ReadLine();
        }
    }
}
