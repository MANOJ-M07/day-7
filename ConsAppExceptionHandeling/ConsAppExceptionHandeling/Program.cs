using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsAppExceptionHandeling
{
    public class Calculation
    {
        public static byte Add(byte a, byte b)
        {
            var result = a + b;
            return (byte)result;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            byte fNum, sNum;
            try
            {
                Console.WriteLine("enter first number");
                fNum = byte.Parse(Console.ReadLine());
                Console.WriteLine("enter second number");
                sNum = byte.Parse(Console.ReadLine());
                Console.WriteLine("Result: \t" + Calculation.Add(fNum, sNum));
            }
            catch (FormatException fe)
            {
                Console.WriteLine("Format Error"+fe.Message);
            }
            catch (OverflowException fe)
            {

                Console.WriteLine("overflow error"+fe.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("error"+ex.Message);
            }
            finally 
            {
                Console.WriteLine("end program");
                Console.ReadKey();
            }















           /* int num1, num2, result;
            try
            {
                Console.WriteLine("enter the first number");
                num1 = int.Parse(Console.ReadLine());
                Console.WriteLine("enter the second number");
                num2 = int.Parse(Console.ReadLine());
                result = num1 + num2;
                Console.WriteLine("Result after adding {0} and {1}=\t{2}",num1,num2,result);
            }
            catch(Exception e) 
            {
                Console.WriteLine("error"+e.Message);

            }
            finally 
            {
                Console.WriteLine("end of program");
                Console.ReadKey();
            }*/
        }
    }
}
