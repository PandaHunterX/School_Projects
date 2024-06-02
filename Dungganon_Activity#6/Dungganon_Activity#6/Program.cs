using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungganon_Activity_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ID, LastName, FirstName;

            Console.WriteLine("Enter ID number: ");
            ID = Console.ReadLine();

            Console.WriteLine("Enter Last Name: ");
            LastName = Console.ReadLine();

            Console.WriteLine("Enter First Name: ");
            FirstName = Console.ReadLine();

            PersonalInformation personalInformation = new PersonalInformation(ID, LastName, FirstName);
            personalInformation.setRole();

            Console.WriteLine($"Your ID number is {personalInformation.getID()}");
            Console.WriteLine($"Your Last Name is {personalInformation.getLastName()}");
            Console.WriteLine($"Your First Name is {personalInformation.getFirstName()}");
            Console.WriteLine($"Your Role is {personalInformation.getRole()}");

            Console.WriteLine("Enter Username: ");
            string UserName = Console.ReadLine();
            Console.WriteLine("Enter Password: ");
            string Password = Console.ReadLine();

            AccountInformation accountInformation = new AccountInformation();
            accountInformation.UserName = UserName;
            accountInformation.Password = Password;
            accountInformation.PasswordConfirmation();
            Console.ReadLine();
        }
    }
}