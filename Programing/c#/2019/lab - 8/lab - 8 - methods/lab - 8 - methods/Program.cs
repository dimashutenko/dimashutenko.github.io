using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab___8___methods
{
    class Program
    {
        public static void ReplaceNumber(int[] numbers, int number, int newNumber)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] == number)
                    numbers[i] = newNumber;
            }
        }

        public static int GetMinMumber(int[] numbers)
        {
            int MinNumber = numbers[0];
            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < MinNumber)
                    MinNumber = numbers[i];
            }
            return MinNumber;
        }

        public static int ReturnElement(int[] array, int element_index)
        {
            int element = array[element_index];
            return element;
        }

        static void Main(string[] args)
        {
            int[] numbers = {1, 2, 3, 4, 5, 6, 7};
            foreach (int n in numbers)
                Console.Write(n +", ");
            Console.Write("\nКакое число (1-7) вы хотите заменить на противоположное по значению? ");
            int NEWnumber = Convert.ToInt32(Console.ReadLine());
            ReplaceNumber(numbers, NEWnumber, -NEWnumber);
            foreach (int n in numbers)
                Console.Write(n + ", ");
            Console.Write("\n\nНайменше чило: " + GetMinMumber(numbers) + "\n\nРяд Фибоначчи: ");
            int[] fibonacci_array = new int[22];
            fibonacci_array[0] = 0;
            fibonacci_array[1] = 1;
            for (int i = 1; i < 21; i++)
            {
                fibonacci_array[i+1] = fibonacci_array[i-1] + fibonacci_array[i];
                Console.Write(fibonacci_array[i]+", ");
                if (i == 20)
                {
                    Console.Write("...");
                }
            }
            Console.Write("\nПредлагаю Вам вернуть елемент под номером 1 - 20. Введите номер: ");
            int Element_index = Convert.ToInt32(Console.ReadLine());
            Console.Write("Елемент под номером " + Element_index + ": " + ReturnElement(fibonacci_array,Element_index));
            Console.ReadKey();
        }
    }
}


