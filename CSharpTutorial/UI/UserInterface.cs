using CSharpTutorial.Core;
using CSharpTutorial.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpTutorial.UI
{
    public class UserInterface
    {
        private static int count = 0;
        public static void Run()
        {
            Console.WriteLine("Welcome to our first console interactive application");
            Console.WriteLine("");
            Console.WriteLine("Please fill in your credentials below");
            Console.Write("First Name: ");
            var firstName = Console.ReadLine();

            Console.Write("Last Name: ");
            var lastName = Console.ReadLine();

            Console.Write("Email: ");
            var email = Console.ReadLine();

            if(!string.IsNullOrWhiteSpace(firstName) 
                && !string.IsNullOrWhiteSpace(lastName) 
                && !string.IsNullOrWhiteSpace(email))
            {
                var user = new User(firstName, lastName, email, count);
                count++;

                var userService = new UserService();

                try
                {
                   var response = userService.Register(user);
                    Console.WriteLine(response);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
