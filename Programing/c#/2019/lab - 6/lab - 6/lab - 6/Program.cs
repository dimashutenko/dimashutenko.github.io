using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lab___6
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[][] jagged_array = new int[4][];
            jagged_array[0] = new int[8] { 2, 3, 4, 5, 1, 7, 8, 9 };
            jagged_array[1] = new int[6] { 2, 3, 4, 6, 7, 8 };
            jagged_array[2] = new int[5] { 1, 2, 3, 4, 0 };
            jagged_array[3] = new int[3] { 1, 2, 4 };
            Console.Write("\n\tPrimary array: ");
            for (int i = 0; i < jagged_array.Length; i++)
            {
                Console.WriteLine("\n");
                foreach (int number in jagged_array[i])
                    Console.Write("   {0}", number);
                Array.Sort(jagged_array[i]);
            }
            Console.Write("\n\n\tSort()-ed array: ");
            for (int i = 0; i < jagged_array.Length; i++)
            {
                Console.WriteLine("\n");
                foreach (int number in jagged_array[i])
                    Console.Write("   {0}", number);
            }
            Console.WriteLine("\n\n\nСтуденты групы БИКС - 21, по порядку подачи документов\n");
            string[] students = new string[10] { "Савочкин - 19л", "Чопер - 18л", "Логинов - 19л", "Галич - 18л", "Лист - 19л", "Бунин - 18л", "Король - 18л", "Дубровский - 19л", "Перова - 19л", "Старкова -20л" };
            foreach (string student in students)
                Console.WriteLine(" {0}", student);
            Array.Sort(students);
            Console.WriteLine("\n\nСтуденты групы БИКС - 21, по алфавиту\n");
            foreach (string student in students)
                Console.WriteLine(" {0}", student);
            string writePath = @"C:\Dima\Programing\c#\2019\lab - 6\BIKS-group.Sort()-ed.txt";
            using (StreamWriter outputFile = new StreamWriter(writePath))
            {
                foreach (string student in students)
                    outputFile.WriteLine(" {0}", student);
            }
            Console.ReadKey();
        }
    }
}
