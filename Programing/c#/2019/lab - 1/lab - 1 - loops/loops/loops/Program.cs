using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace loops
{
    class Program
    {
        static void Main(string[] args)
        {
            bool stop = true;
            do
            {
                Console.Clear();
                Console.Write("Номер задания : ");
                int task = Convert.ToInt32(Console.ReadLine());
                switch (task)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Последовательность из 20 чисел в которой каждое последующее больше предыдущего на 3 : ");
                            for (int i = 0; i < 20; i++)
                            {
                                Console.Write("{0}, ", 1+i*3);
                            }
                            Console.Write("и все");
                            Console.WriteLine();
                            Console.WriteLine("Желаете продолжить? (да/нет)");
                            string Continue = Convert.ToString(Console.ReadLine());
                            if (Continue.ToLower() == "да")
                                stop = false;
                            else
                            {
                                Console.WriteLine("Нажмите любую клавишу для выхода");
                                stop = true;
                            }
                            break;
                        }
                    case 2:
                        {
                            Console.Clear();
                            string password = "0";
                            while (password != "biks")
                            {
                                Console.Clear();
                                Console.Write("Введите пароль : ");
                                password = Convert.ToString(Console.ReadLine());
                            }
                            Console.WriteLine();
                            Console.WriteLine("Желаете продолжить? (да/нет)");
                            string Continue = Convert.ToString(Console.ReadLine());
                            if (Continue.ToLower() == "да")
                                stop = false;
                            else
                            {
                                Console.WriteLine("Нажмите любую клавишу для выхода");
                                stop = true;
                            }
                            break;
                        }
                    case 3:
                        {
                            Console.Clear();
                            Console.WriteLine("Найдем произведение целых чисел от 2 до 16.");
                            long output = 0;
                            for (int i = 2; i <= 16; i++)
                            {
                                output += i;
                                Console.WriteLine("{0} * {1} = {2}", output, i + 1, output * (i + 1));
                                output = output * (i + 1) - (i+1);
                            }
                            Console.Write("Произведение целых чисел от 2 до 16 равняется {0}", output);
                            Console.WriteLine();
                            Console.WriteLine("Желаете продолжить? (да/нет)");
                            string Continue = Convert.ToString(Console.ReadLine());
                            if (Continue.ToLower() == "да")
                                stop = false;
                            else
                            {
                                Console.WriteLine("Нажмите любую клавишу для выхода");
                                stop = true;
                            }
                            break;
                        }
                    case 4:
                        {
                            Console.Clear();
                            Console.WriteLine("В первый день робочий изготовил Х детелай, в последущие дни он увеличивал норму предыдущего дня в 2 раза, работая Y дней. ");
                            Console.Write("Найдем колличество деталей, которые он изготовлял каждый день при введенных значениях \nХ = ");
                            int x = Convert.ToInt32(Console.ReadLine());
                            Console.Write("и Y = ");
                            int y = Convert.ToInt32(Console.ReadLine());
                            for (int i = 1; i <= y; i++)
                            {
                                Console.WriteLine("{0} * {1} = {2}", i, x * Math.Pow(2, (i - 1)), i * x * Math.Pow(2, (i - 1)));
                            }
                            Console.WriteLine();
                            Console.WriteLine("Желаете продолжить? (да/нет)");
                            string Continue = Convert.ToString(Console.ReadLine());
                            if (Continue.ToLower() == "да")
                                stop = false;
                            else
                            {
                                Console.WriteLine("Нажмите любую клавишу для выхода");
                                stop = true;
                            }
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Ошибка. Попробуйте еще раз!");
                            Console.WriteLine("Нажмите любую клавишу чтобы попробовать снова");
                            Console.ReadKey();
                            stop = false;
                            continue;
                        }
                }
            } while (stop == false);
            Console.ReadKey();
        }
    }
}
