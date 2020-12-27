using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamWriter writer = new StreamWriter(@"C:\Dima\Programing\c#\2019\Модуль\task-2.txt"))
            {
            writer.WriteLine("!!!!!!!!!!!!!!!!!!!!!");
            }
            Console.ReadLine();
        }
    }
}
