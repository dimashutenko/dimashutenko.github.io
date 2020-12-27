using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lab___7_files
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (StreamWriter writer = new StreamWriter(@"C:\Dima\Programing\c#\2019\lab - 7\task-1.txt"))
            {
                for (int i = 1; i <= 523; i++)
                {
                    writer.Write(i + ", ");
                }
            }
            string[] Names = new string[] { "Кобзар", "Марія", "Заповіт", "Словник", "Інформатика" };
            using (StreamWriter writer_2 = new StreamWriter(@"C:\Dima\Programing\c#\2019\lab - 7\task-2.txt"))
            {
                foreach (string name in Names)
                    writer_2.WriteLine(name);
            }
            int[] array_of_lengths = new int[5];
            int longest_line_number = 0;
            using (StreamReader reader = new StreamReader(@"C:\Dima\Programing\c#\2019\lab - 7\task-2.txt"))
            {
                for (int i = 0; i < Names.Length; i++)
                {
                    array_of_lengths[i] = reader.ReadLine().Length;
                    if (array_of_lengths[i] > longest_line_number)
                        longest_line_number = i;
                }
            }
            Console.WriteLine("Самая длинная строка - {0} : \"{1}\"", longest_line_number + 1, Names[longest_line_number]);
            Console.ReadKey();
        }
    }
}
