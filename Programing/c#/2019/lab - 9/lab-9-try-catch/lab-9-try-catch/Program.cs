using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace lab_9_try_catch
{
    class Program
    {
        public static int Sum(int[] array, int number_1_index, int number_2_index)
        {
            return array[number_1_index] + array[number_2_index];
        }

        static void Main()
        {
            Console.OutputEncoding = Encoding.UTF8;
            int Number_1_index = 0, Number_2_index = 0;
            using (StreamWriter writer = new StreamWriter(@"C:\Dima\Programing\c#\2019\lab - 9\lab-9.txt"))
            {
                while (true)
                {
                    try
                    {
                        Console.Clear();
                        int[] Array = { 10, 20, 30, 40, 50, 60, 70, 80, 90, 100 };
                        Console.WriteLine("Дан массив");
                        writer.WriteLine("Дан массив");
                        foreach (int n in Array)
                        {
                            Console.Write(n + ", ");
                            writer.Write(n + ", ");
                        }
                        Console.WriteLine("\n\nВведите порядковые номера элементов массива, которые необходимо суммировать");
                        writer.WriteLine("Введите порядковые номера элементов массива, которые необходимо суммировать");
                        if (Number_1_index > 0 && Number_1_index <= 10)
                        {
                            Console.WriteLine("Первый порядковый номер: " + Number_1_index);
                            writer.WriteLine("Первый порядковый номер: " + Number_1_index);
                        }
                        else
                        {
                            Console.Write("Первый порядковый номер: ");
                            writer.Write("Первый порядковый номер: ");
                            Number_1_index = Convert.ToInt32(Console.ReadLine());
                            writer.Write(Number_1_index + "  ");
                        }
                        if (Number_2_index > 0 && Number_2_index <= 10)
                        {
                            Console.WriteLine("Второй порядковый номер: " + Number_2_index);
                            writer.WriteLine("Второй порядковый номер: " + Number_2_index);
                        }
                        else
                        {
                            Console.Write("Второй порядковый номер: ");
                            writer.Write("Второй порядковый номер: ");
                            Number_2_index = Convert.ToInt32(Console.ReadLine());
                            writer.Write(Number_2_index + "  ");
                        }
                        Console.Write("Сумма елементов: " + Sum(Array, Number_1_index - 1, Number_2_index - 1));
                        writer.Write("Сумма елементов: " + Sum(Array, Number_1_index - 1, Number_2_index - 1));
                        break;
                    }
                    catch (Exception ex)
                    {
                        Console.Write(ex.Message + " Попробуйте еще раз)");
                        Console.ReadKey();
                    }
                }
            }
            Console.ReadKey();
        }
    }
}

