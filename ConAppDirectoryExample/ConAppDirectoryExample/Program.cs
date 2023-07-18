using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConAppDirectoryExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* string fFolder = "D:\\";
             string newDir;
             Console.WriteLine("Enter directory Name");
             newDir=Console.ReadLine();
             string fPath = fFolder + newDir;
             DirectoryInfo directoryInfo = new DirectoryInfo(fPath); 
             if (directoryInfo.Exists )
             {
                 Console.WriteLine($"Directory {newDir} already exist");
             }
             else
             {
                 directoryInfo.Create();
                 Console.WriteLine($"Directory {newDir} creation on {fPath} sucess");
             }
             Console.ReadKey();*/

            string fPath;
            Console.WriteLine("enter Directory path");
            fPath = Console.ReadLine();
            DirectoryInfo directory = new DirectoryInfo(fPath);
            foreach (FileInfo fi in directory.GetFiles())
            {
                Console.WriteLine("file name \t"+fi.FullName);
                Console.WriteLine("\t file length"+fi.Length);
                Console.WriteLine("\t file creation time"+fi.CreationTime);
                Console.WriteLine("\n");
            }
            Console.ReadKey();



        }
    }
}
