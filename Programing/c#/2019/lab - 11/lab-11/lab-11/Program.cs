using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lab_11
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            using (StreamWriter writer = new StreamWriter(@"C:\Dima\Programing\c#\2019\lab - 11\lab-11.txt"))
            {
                writer.WriteLine("Група БІКС:");
                ArrayList biks = new ArrayList() { "Бурев", "Селезнева", "Шаров", "Вилкул", "Быков", "Рос", "Молоков", "Семенова", "Байрак", "Гонгадзе", "Столяров", "Русич", "Капылова", "Яшина" };
                foreach (object o in biks)
                    writer.WriteLine(o);
                writer.WriteLine();
                writer.WriteLine("Загальна кількість студентів: " + biks.Count);
                writer.WriteLine();
                writer.WriteLine("Відсортований список:");
                biks.Sort();
                foreach (object o in biks)
                    writer.WriteLine(o);
                writer.WriteLine();
                writer.Write("Останні 10 чоловік: ");
                for (int i = biks.Count - 9; i <= biks.Count; i++)
                {
                    if ( i == biks.Count)
                        writer.Write(biks[i-1]);
                    else 
                    writer.Write( biks[i-1]+", ");
                }
            }
            Console.ReadKey();
        }
    }
}
