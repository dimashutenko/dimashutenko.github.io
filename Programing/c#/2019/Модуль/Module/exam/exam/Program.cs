using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace exam
{
    class AEROFLOT
    {
        public string Nazv;
        public int Number;
        public int Type;
        public string Time;

        public AEROFLOT()
        {

        }
        public AEROFLOT( string nazv,int number,int type,string time)
        {
            Nazv = nazv;
            Number = number;
            Type = type;
            Time = time;
        }
        public void PrintInfo()
        {
            //Console.WriteLine("\nСамолет типа "+Type+" номер "+Number+" вылетает в "+Nazv+" в "+Time);
            Console.WriteLine("\nСамолет номер "+Number+" вылетает в "+Nazv+" в "+Time);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            AEROFLOT [] ROZKLAD=new AEROFLOT[2];
            for (int i = 0; i < ROZKLAD.Length; i++)
            {
                Console.Write("\nВведите название пункта назначения "+(i+1)+": ");
                string Nazv = Convert.ToString(Console.ReadLine());
                Console.Write("\nВведите номер рейса: ");
                int Number = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nВведите тип самолета: ");
                int Type = Convert.ToInt32(Console.ReadLine());
                Console.Write("\nВведите время отправки: ");
                string Time = Convert.ToString(Console.ReadLine());
                ROZKLAD[i] = new AEROFLOT(Nazv, Number, Type, Time);
            }
           Console.Write("\nУпрорядочено по возростанию типа: ");
           if (ROZKLAD[0].Type > ROZKLAD[1].Type)
           {
               ROZKLAD[0].PrintInfo();
               ROZKLAD[1].PrintInfo();
           }
           else
           {
               ROZKLAD[1].PrintInfo();
               ROZKLAD[0].PrintInfo();
           }
           Console.Write("\nВведите пункт назначения: ");
           string destination = Convert.ToString(Console.ReadLine());
            bool flag = false;
            using (StreamWriter writer = new StreamWriter(@"C:\Dima\Programing\c#\2019\Модуль\Module\exam\exam.txt"))
            {
                for (int i = 0; i < ROZKLAD.Length; i++)
                {
                    if (ROZKLAD[i].Nazv == destination)
                    {
                        ROZKLAD[i].PrintInfo();
                        writer.WriteLine("\nСамолет номер " + ROZKLAD[i].Number + " вылетает в " + ROZKLAD[i].Nazv + " в " + ROZKLAD[i].Time);
                        flag = true;
                    }
                    if (i == ROZKLAD.Length - 1 && flag == false)
                    {
                        Console.WriteLine("\nТаких рейсів немає");
                        writer.WriteLine("\nТаких рейсів немає");
                    }
                }
            }
           Console.ReadKey();
           Console.ReadKey();
        }
    }
}
