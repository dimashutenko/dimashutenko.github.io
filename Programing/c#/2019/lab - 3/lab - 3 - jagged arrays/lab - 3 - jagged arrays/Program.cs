using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab___3___jagged_arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("a)");
            int[][] jagged_array = new int[5][];
            jagged_array[0] = new int[1] {0};
            jagged_array[1] = new int[2] {1,0};
            jagged_array[2] = new int[3] {2, 1, 0 };
            jagged_array[3] = new int[4] {3, 2, 3, 0 };
            jagged_array[4] = new int[5] {4, 2, 4, 1, 0 };
            for (int i = 0; i < jagged_array.Length; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    Console.Write("{0}   ", jagged_array[i][j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n\nb)");
            int[][] jagged_array_2 = new int[5][];
            jagged_array_2[0] = new int[5]{6,5,4,3,2};
            jagged_array_2[1] = new int[4] { 7, 4, 3, 2 };
            jagged_array_2[2] = new int[3] { 8, 3, 2};
            jagged_array_2[3] = new int[2] { 9, 2 };
            jagged_array_2[4] = new int[1] { 2 };
            for (int i = 0; i < jagged_array_2.Length; i++)
            {
                Console.WriteLine("\t");
                for (int j = 0; j < jagged_array_2[i].Length; j++)
                {
                    Console.Write("{0}\t", jagged_array_2[i][j]);
                }
                Console.WriteLine("\n\n");
            }
            Console.Write("\n\nВведите колличество массивов: ");
            int number_of_arrays = Convert.ToInt32(Console.ReadLine());
            int variable=0;
            int[] array_of_lengths= new int[number_of_arrays];
            int[][] array = new int[number_of_arrays][];
            do 
            {
                Console.Write("\nВведите размерность {0}-го массива: ", variable+1);
                array_of_lengths[variable] = Convert.ToInt32(Console.ReadLine());
                //int[] array = new int[array_of_lengths[variable]];
                array[variable] = new int[array_of_lengths[variable]];
                for (int i = 0; i < array_of_lengths[variable]; i++)
                {
                    Console.Write("Введите {0}-й елемент {1}-го массива: ", i+1, variable+1);
                    array[variable][i] = Convert.ToInt32(Console.ReadLine());
                }
                variable++;
            }
            while(variable < number_of_arrays);
            Console.WriteLine("\n\n Вот заданный массив:\n");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("\t");
                for (int j = 0; j < array[i].Length; j++)
                {
                    Console.Write("{0}\t", array[i][j]);
                }
                    Console.WriteLine("\n\n");
            }
            Console.Write("Введите колличество строк матрици M = ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите колличество столбцов матрици N = ");
            int n = Convert.ToInt32(Console.ReadLine());
            int [][] matrix = new int[m][];
            for (int q = 0; q < m; q++)
            {
                matrix[q] = new int[n];
            }
            Random My_random = new Random();
            int [] array_of_sums = new int[n];
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    matrix[i][j] = My_random.Next(0, 100);
                    Console.Write("   {0}     ", matrix[i][j]);
                    if (j % 2 != 0 && j !=0)
                    {
                        array_of_sums[j] += matrix[i][j];
                    }
                }
                Console.WriteLine("\n\n");
            }
            for (int p = 0; p < n; p++)
            {
                if (p % 2 != 0 && p != 0)
                    Console.Write(" Сумма={0} ",array_of_sums[p]);
                else
                    Console.Write("         ");
            }
            Console.ReadKey();

        }
    }
}
