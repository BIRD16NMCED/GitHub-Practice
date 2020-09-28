using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitHub_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            int age;


            age = DisplayGetUserAge();

        }

        static int DisplayGetUserAge()
        {
            int age;
            string userResponse;
            bool validResponse; 

            //age = Convert.ToInt32(userResponse); for unicorn users, just another way to convert age to int, remember to add validation too for userError checking 


            do
            {
                validResponse = true;

                Console.Write("Please enter age:");
                userResponse = Console.ReadLine();

                if (!int.TryParse(userResponse, out age)) //tryparse reverts to int value, checks the value of the number for an integer 
                {
                    Console.WriteLine("Please enter a proper integer for your age.");
                    validResponse = false;
                }


            } while (!validResponse);

            return age; 
        }
    }
}
