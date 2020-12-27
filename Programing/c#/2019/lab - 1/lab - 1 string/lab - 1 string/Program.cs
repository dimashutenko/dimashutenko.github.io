using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab___1_string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string row1 = "Нiчого не буває просто так,";
            string row2 = "Нiчого не буває випадково:";
            string row3 = "Нi зустрiч, нi подiя, анi слово...";
            string row4 = "До того йшло, або ж це Долi Знак";
            Console.WriteLine(row1 + "\n" +  row2 + "\n" + row3 + "\n" + row4 + "\n");
            Console.WriteLine(row1.Replace("Нiчого не", "Все") + "\n" + row2.Replace("Нiчого не", "Все") + "\n" + row3.Replace("Нiчого не", "Все") + "\n" + row4.Replace("Нiчого не", "Все") + "\n");
            if (row1.Length > row2.Length && row1.Length > row3.Length && row1.Length > row4.Length)
                Console.WriteLine("Перший рядок - найдовший" + "\n\n");
            else if (row2.Length > row1.Length && row2.Length > row3.Length && row2.Length > row4.Length)
                Console.WriteLine("Другий рядок - найдовший" + "\n\n");
            else if (row3.Length > row2.Length && row3.Length > row1.Length && row3.Length > row4.Length)
                Console.WriteLine("Третiй рядок - найдовший" + "\n\n");
            else if (row4.Length > row1.Length && row4.Length > row2.Length && row4.Length > row3.Length)
                Console.WriteLine("Четвертий рядок - найдовший" + "\n\n");
            else
                Console.WriteLine("Не маємо найдовшого рядка" + "\n\n");
            Console.WriteLine(row1.Remove(16) + "\n\n");
            string row = "Я хочу, щоб у морi слiз,\nУ СВІТІ, ДЕ ПАНУЄ ЛИХО,\nПОЕЗІЇ РОСТОЧОК РІС:\nВтiшав, нагадував i кликав.";
            Console.WriteLine(row + "\n");
            Console.WriteLine(row.ToLower() + "\n\n");
            string str = "Login1,LOgin2,login3,loGin4";
            Console.WriteLine(str + "\n");
            string[] logins = str.Split(',');
            foreach(string login in logins)
                Console.WriteLine(login);
            Console.ReadKey();
        }
    }
}
