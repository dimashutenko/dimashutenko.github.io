using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            var myOS = Environment.OSVersion;
            object[] myArr = { "Строка", 120, 0.345m, 2.34f, myOS, 'Z' };
            foreach (object obj in myArr)
                Console.WriteLine("Элемент \"{0}\" его тип - {1}", obj, obj.GetType());
            Console.ReadLine();
        }
    }
}
