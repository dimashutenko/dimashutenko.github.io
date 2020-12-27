using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_12
{
    class Program
    {
        static void random( double num, out int integer, out string evenORodd, out double fraction)
        {
            integer = (int)num;
            fraction = num - (int)num;
            if (integer % 2 == 0)
            {
                evenORodd = "Even";
            }
            else
            {
                evenORodd = "Odd";
            }
        }
        static void Main(string[] args)
        {
            Random r = new Random();
            int Integer;
            string EVENorODD;
            double  Fraction;
            for (int i = 1; i < 5; i++)
            {
                double Number = 100 * r.NextDouble();
                random(Number, out Integer, out EVENorODD, out Fraction);
                Console.WriteLine("\n Number " + i +" = " + Number);
                Console.WriteLine("Integer = " + Integer + "\t" + EVENorODD + "\tFraction = " + Fraction);
            }
            Console.ReadLine();
        }
    }
}