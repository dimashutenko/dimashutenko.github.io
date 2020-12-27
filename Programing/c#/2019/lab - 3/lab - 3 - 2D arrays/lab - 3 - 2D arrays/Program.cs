using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab___3___2D_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            int[,] Array = new int [6,6];
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write("Введите {0} елемент {1} рядка: ", j + 1, i + 1);
                    Array[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            Console.WriteLine();
            double sum = 0;
            for (int i = 0; i < Array.GetLength(0); i++)
            {
                for (int j = 0; j < Array.GetLength(1); j++)
                {
                    Console.Write("\t" + Array[i, j]);
                    sum += Array[i, j];
                }
                Console.WriteLine();
                Console.WriteLine();
            }
            Console.WriteLine("\n\n Сумма елементов массива кратная 3 = " + sum / 3 + "\n\n");
            int[,] Array2 = { { 1, 2, 3, 4 }, { 5, 6, 7, 8 } };
            for (int i = 0; i < Array2.GetLength(0); i++)
            {
                for (int j = 0; j < Array2.GetLength(1); j++)
                {
                    Console.Write("   " + Array2[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            int sum_4_column = 0 , sum_2_column = 0;
            for (int j = 0; j < Array2.GetLength(1); j++)
            {
                if (j == 1 || j == 3)
                {
                    for (int i = 0; i < Array2.GetLength(0); i++)
                    {
                        if(j == 1)
                            sum_2_column += Array2[i, j];
                        if (j == 3)
                            sum_4_column += Array2[i, j];
                    }
                }
            }
            Console.WriteLine("Сумма елементов 2 столбца: " + sum_2_column + "\nСумма елементов 4 столбца: " + sum_4_column + "\n\n");
            int [] array = new int[9];
            int composition = 1;
            for(int i=0; i<array.GetLength(0);i++)
            {
                array[i] = i+1;
                if (i == array.GetLength(0) - 1)
                {
                    Console.Write("{0}", array[i]);
                    break;
                }
                Console.Write("{0}, ", array[i]);
                composition *= array[i];
            }
            Console.WriteLine("\n\nПроизведение положительных значений - " + composition);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
