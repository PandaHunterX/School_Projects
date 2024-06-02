using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dungganon_Activity_6
{
    internal class PersonalInformation
    {
        private string ID;
        private string LastName;
        private string FirstName;
        private string Role;

        public PersonalInformation(string ID, string LastName, string FirstName)
        {
            this.ID = ID;
            this.LastName = LastName;
            this.FirstName = FirstName;
        }

        public string getID()
        {
            return ID;
        }
        public string getLastName()
        {
            return LastName;
        }

        public string getFirstName()
        {
            return FirstName;
        }

        public void setRole()
        {
            Console.WriteLine("Please Choose the following Roles: ");
            Console.WriteLine("1. Dean");
            Console.WriteLine("2. Faculty");
            Console.WriteLine("3. Staff");
            Console.WriteLine("4. Technician");
            Console.WriteLine("5. Assistant");

            string selectedRole = Console.ReadLine();

            switch (selectedRole)
            {
                case "1":
                    Role = "Dean";
                    break;
                case "2":
                    Role = "Faculty";
                    break;
                case "3":
                    Role = "Staff";
                    break;
                case "4":
                    Role = "Technician";
                    break;
                case "5":
                    Role = "Assistant";
                    break;
                default:
                    Console.WriteLine("Invalid Input. Please select a valid role.");
                    setRole(); 
                    return; 
            }
        }

        public string getRole()
        {
            return Role;
        }
    }
}
