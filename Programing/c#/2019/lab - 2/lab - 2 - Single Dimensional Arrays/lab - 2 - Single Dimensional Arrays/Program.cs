using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab___2___Single_Dimensional_Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[] C = new int[20];
            int sum = 0;
            long composition = 1;
            for (int i = 1; i < C.Length; i++ )
            {
                C[i] = i;
                sum += i;
                composition *= i;
            }
            Console.WriteLine("Сума: " + sum);
            Console.WriteLine("Добуток: " + composition + "\n\n");
            int[] A = new int[10];
            double output;
            for (int i = 0; i < C.Length; i++)
            {
                C[i] = i;
                output = Math.Pow((double)i, 2);
                Console.WriteLine(output);
            }
            Console.ReadKey();
        }
    }
}
