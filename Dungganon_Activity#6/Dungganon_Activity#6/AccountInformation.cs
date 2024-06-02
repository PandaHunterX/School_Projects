//Create a program that would accept values based from the form below as user input. Your application should include two sets of approaches; 1) using constructors and methods; 2) using the property accessors.



//Requirements:

//1.Create one(1) single project only for this activity, but using multiple classes.

//2.Use what you have learned in your previous programming subjects (constructors and methods).

//2. Use property accessors (get; set;).

//3.Display the information.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungganon_Activity_6
{
    internal class AccountInformation
    {
        public AccountInformation() { }

        public string UserName { get; set; }

        public string Password { get; set; }


        public void PasswordConfirmation()
        {
            while (true)
            {
                Console.WriteLine("Please Confirm your Password: ");
                string CorrectPass = Console.ReadLine();
                if (CorrectPass == Password)
                {
                    Console.WriteLine("Account has been created");
                    Console.WriteLine($"Welcome {UserName}!");
                    break;
                }
                else
                {
                    Console.WriteLine("Confirm Password is incorrect, Please try Again");
                }
            }
        }
    }
}
