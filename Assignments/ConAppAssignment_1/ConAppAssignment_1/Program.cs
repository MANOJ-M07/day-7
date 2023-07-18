using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ConAppAssignment_1
{
    class ValidationException : Exception
    {
        public ValidationException(string message) : base(message)
        {
        }

        static void ValidateUserInput(string name, string email, string password)
        {

            if (string.IsNullOrEmpty(name) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                throw new ValidationException("All fields are required.");
            }

            
            else if (name.Length < 6 )
            {
                throw new ValidationException("Name must have at least 6 characters.");
            }

            
            else if (password.Length < 8)
            {
                throw new ValidationException("Password must have at least 8 characters.");
            }

        }


        internal class Program
        {
            static void Main(string[] args)
            {
                try
                {
                    Console.WriteLine("User Registration System");
                    Console.WriteLine("------------------------");
                    Console.Write("Enter your name: ");
                    string name = Console.ReadLine();
                    Console.Write("Enter your email: ");
                    string email = Console.ReadLine();
                    Console.Write("Enter your password: ");
                    string password = Console.ReadLine();
                    Console.WriteLine("\n");


                    ValidateUserInput(name, email, password);
                    Console.WriteLine("************************************************");
                    Console.WriteLine("User registration success.");
                    Console.WriteLine("Name: " + name);
                    Console.WriteLine("Email: " + email);
                    Console.WriteLine("Password: " + password);
                }
                catch (ValidationException ex)
                {
                    Console.WriteLine("Validation Error: " + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
                finally { Console.WriteLine("\n end of the validation"); }
                Console.ReadKey();
            }

        }

    }
}