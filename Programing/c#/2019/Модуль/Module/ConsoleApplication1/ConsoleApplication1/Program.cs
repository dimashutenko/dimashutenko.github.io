using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Detal
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Console.WriteLine("Скількі деталей ви хочете ввести?");
            int n = Convert.ToInt32(Console.ReadLine());
            DETAL[] detal = new DETAL[n];


            for (int i = 0; i < detal.Length; i++)
            {
                Console.Write("\nНазва {0}-ого деталі: ", i + 1);
                string name = Console.ReadLine();
                Console.Write("Ціна закупки {0}-ого деталі: ", i + 1);
                double price = double.Parse(Console.ReadLine());
                Console.Write("Сорт {0}-ого деталі: ", i + 1);
                string sort = Console.ReadLine();
                Console.Write("Кількість {0}-ого деталі: ", i + 1);
                int quantity = int.Parse(Console.ReadLine());
                Console.Write("Дата виготовлення {0}-ого деталі В ФОРМАТІ MM/DD/YYYY: ", i + 1);
                DateTime date = DateTime.Parse(Console.ReadLine());




                detal[i] = new DETAL(name, quantity, sort, price, date);
                detal[i].PrintInfo();






            }








            Console.ReadLine();

        }
    }

    struct DETAL
    {
        public string Name;
        public int Quantity;
        public string Sort;
        public double Price;
        public DateTime Date;



        public DETAL(string Name, int Quantity, string Sort, double Price, DateTime Date)
        {
            this.Name = Name;
            this.Sort = Sort;
            this.Quantity = Quantity;
            this.Date = Date;
            this.Price = Price;

        }
        public void PrintInfo()
        {
            //Console.WriteLine("\nСамолет типа "+Type+" номер "+Number+" вылетает в "+Nazv+" в "+Time);
            Console.WriteLine("Деталь називається: " + Name + " у кількості " + Quantity + " сорту: " + Sort + " за ціною " + Price + " виготовлена " + Date);
        }







    }
}