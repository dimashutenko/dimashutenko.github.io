using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_14_struct
{
    struct Radius
    {
        public double Sum;
        public double GetAverage(double [] radiuses)
        {
            for (int i = 0; i < radiuses.Length; i++)
            {
                Sum += radiuses[i];
            }
            return Sum / radiuses.Length;
        }
    }

    class Program
    {
        static void Main()
        {
            Console.Write("Given radiuses: ");
            double []Radiuses = new double[]{11,12,13,14,15,19};
            for (int i = 0; i < Radiuses.Length; i++)
            {
                Console.Write(Radiuses[i]+", ");
            }
            Radius radius = new Radius();
            Console.WriteLine("\nAverage radius: " + radius.GetAverage( Radiuses));
            Console.ReadLine();
        }
    }
}
