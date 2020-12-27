using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] Numbers = new int[100];
            Random random = new Random();
            using (StreamWriter writer = new StreamWriter(@"C:\Dima\Programing\c#\2019\Модуль\task-2.txt"))
            {
                for (int i = 0; i < Numbers.Length; i++)
                {
                    Numbers[i] = random.Next(0,100);
                    writer.Write(Numbers[i] + ", ");
                }
            }
            using (StreamReader reader = new StreamReader(@"C:\Dima\Programing\c#\2019\Модуль\task-2.txt"))
            {
                string line;
                do
                {
                    line = reader.ReadLine();
                    Console.Write(line);
                }
                while (line != null);
            }
            Console.ReadLine();
        }
    }
}
