using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppStructEx
{
    public struct Student
    {
        int id;
        string name;
        public Student (int _id, string _name)
        {
            /*this.id = id;
            this.name = name;*/
            id = _id;
            name = _name;

        }
        public void Display()
        {
            Console.WriteLine($"Student ID {id}\n student Name {name}");
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student(12,"raj");
            s.Display();
            Student s1 = new Student(13, "ravi");
            s.Display();
            Console.ReadKey();

        }
    }
}
