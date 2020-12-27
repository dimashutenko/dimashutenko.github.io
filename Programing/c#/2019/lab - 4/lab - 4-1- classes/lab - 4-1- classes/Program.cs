using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab___4_1__classes
{
    class Building
    {
        public int number_of_people;
        public double space;
        public int number_of_floors;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Building house_1 = new Building();
            Console.Write("Введите количество людей, проживающих в доме: ");
            house_1.number_of_people = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите общий метраж дома: ");
            house_1.space = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("\n\nКоличество метров на одного человека: " + house_1.space/house_1.number_of_people);
            Console.ReadKey();
            Console.ReadKey();
        }
    }
}
