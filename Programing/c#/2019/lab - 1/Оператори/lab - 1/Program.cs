using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab___1
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
                int lab = Convert.ToInt32(Console.ReadLine());
                switch (lab)
                {
                    case 1:
                        {
                            Console.Clear();
                            Console.Write("Колличество забитых голов хозяевам : ");
                            int host_missed = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Колличество забитых голов гостям : ");
                            int challenger_missed = Convert.ToInt32(Console.ReadLine());
                            if (host_missed > challenger_missed)
                                Console.WriteLine("Выиграли гости");
                            else if (host_missed < challenger_missed)
                                Console.WriteLine("Выиграли хозяева");
                            else
                                Console.WriteLine("Ничья");
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
                            Console.WriteLine("Поиск чисел кратных 3-м и 7-ми. ");
                            Console.Write("Введите число : ");
                            int number = Convert.ToInt32(Console.ReadLine());
                            if (number % 3 == 0 && number % 7 == 0)
                                Console.Write("Число {0} кратное 3-м и 7-ми.", number);
                            else
                                Console.Write("Число {0} не кратное 3-м и 7-ми.", number);
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
                            Console.WriteLine("Ошибка. Попробуйте снова!");
                            stop = false;
                            continue;
                        }
                }
            } while (stop == false);
            Console.ReadKey();
        }
    }
}
