using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            try
            {
                int[] array = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
                Console.WriteLine("Введіть порядковий номер 1: ");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введіть порядковий номер 2: ");
                int number2 = Convert.ToInt32(Console.ReadLine());
                int sum = array[number1] + array[number2];
                Console.WriteLine("Сума елементів = " + sum);
                Console.ReadLine();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message + " Ви не ввели число, або ж введене вами число не відповідає елементу масива!");
            }
            Console.ReadLine();
        }
    }
}
