using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppEnum
{
    internal class Program
    {
        public enum DayofWeek
        {
            Monday,Tuesday,Wednesday,Thursday,Friday,Saturday
        }
        static void Main(string[] args)
        {
            DayofWeek today = DayofWeek.Tuesday;
            Console.WriteLine("day"+today);
            Console.WriteLine("Day number"+(int)today);
            Console.ReadKey();
        }
    }
}
