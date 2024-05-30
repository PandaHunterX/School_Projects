//Problem:

//Create a program that would simply display the results of two (2) numbers used in mathematical operations and determine if the result is an even or odd number. Please refer from the list of requirements below to complete this activity:

 

//Requirements:

//1.Use class or classes.

//2.Should include methods as mathematical operations (addition, subtraction, multiplication, division) 

//3. Should use property accessors to efficiently manage the data.

//4. The program should accept 2 numbers as user input .

//5. Display the results based from the mathematical operation and indicate if it is an even or odd number.

 

//Sample Output:

//Please enter first number: 10

//Please enter second number: 5

//The sum of 10 and 5 is 15 and it is an odd number.

//The difference of 10 and 5 is 5 and it is an odd number.

//The product of 10 and 5 is 50 and it is an even number.

//The quotient of 10 and 5 is 2 and it is an even number;.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungganon_Activity_5
{
    internal class Calculator
    {
        private double num1;
        private double num2;

        public Calculator(double num1, double num2) 
        {
            this.num1 = num1;
            this.num2 = num2;
        }

        private string OddEven(double value)
        {
            if (value % 2 == 0)
            {
                return "Even";
            }
            else
            {
                return "Odd";
            }
        }

        public void getSum()
        {
            double sum = this.num1 + this.num2;
            Console.WriteLine($"The Sum of {this.num1} and {this.num2} is {sum} and it is an {OddEven(sum)} number.");
        }

        public void getDifference()
        {
            double difference = this.num1 - this.num2;
            Console.WriteLine($"The Difference of {this.num1} and {this.num2} is {difference} and it is an {OddEven(difference)} number.");
        }

        public void getProduct()
        {
            double product = this.num1 * this.num2;
            Console.WriteLine($"The Product of {this.num1} and {this.num2} is {product} and it is an {OddEven(product)} number.");
        }
         
        public void getQuotient()
        {
            double quotient = this.num1 / this.num2;
            Console.WriteLine($"The Quotient of {this.num1} and {this.num2} is {quotient} and it is an {OddEven(quotient)} number.");
        }

    }
}
