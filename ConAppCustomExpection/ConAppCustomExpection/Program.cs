using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppCustomExpection
{
    public class CustomException:Exception
    {
        public CustomException(string message): base(message)  
        {
            
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            try 
            {
                int userAge;
                Console.WriteLine("enter the age");
                userAge = int.Parse(Console.ReadLine());
                if(userAge<=0)
                {
                    throw new CustomException("Age must not be - number");
                }
                else if (userAge>=18)
                {
                    Console.WriteLine("you are  eligible for voting");
                }
                else { Console.WriteLine("you are not eligible"); }
            }
            catch (CustomException ce) { Console.WriteLine("Custom Error"+ce.Message); }
            catch (Exception ex) { Console.WriteLine("error"+ex.Message); }
            finally { Console.WriteLine("***bye**"); 
            Console.ReadKey();
            }
        }
    }
}
