using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime date1 = new DateTime(2015, 7, 21); // 20.07.2015 
            DateTime date2 = new DateTime(2015, 7, 20); // 20.07.2015 
            Console.WriteLine(date1.Subtract(date2)); // 
            Console.ReadKey();
        }
    }
}
