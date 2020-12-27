using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication3
{
    class Program
    {
        void printError(string s) // наш метод виводу повідомлення помилки           
        {
            Console.Write("Error! " + s + " Press Key...");
            Console.ReadKey();
        }
        char shifr(char x, int shifr) // наш метод для шифрування\\дешифрування           
        {
            x = (char)(x ^ shifr);
            return x;
        }
        bool ravenstvo(char[] c1, char[] c2) // наш метод для визначення рівності           
        {
            if (c1.Length == c2.Length)
            {
                for (int k = 0; k < c1.Length; k++)
                {
                    if (c1[k] != c2[k]) return false;
                }
            }
            return true;
        }

        static void Main(string[] args)
        {
            Program p = new Program(); // оголошуємо змінну типу класу Program,    
            // щоб викликати методи, які в класі. Тобто на пряму викликати не можна...               
            char[] chr = { 'a', 'l', 'e', 'x', 'a', 'n', 'd', 'e', 'r' };
            Console.Write("chr: ");
            Console.WriteLine(chr);                // original   
            char[] chr2 = new char[chr.Length]; // копія змінної chr             
            for (int i = 0; i < chr.Length; i++)
            {
                chr2[i] = p.shifr(chr[i], i); // виклик методу шифрування               
            }
            Console.Write("chr-shifr: ");
            Console.WriteLine(chr2);
            for (int i = 0; i < chr.Length; i++)
            {
                chr2[i] = p.shifr(chr2[i], i); // виклик методу дешифрування                
            }
            Console.Write("chr-deshifr: ");
            Console.WriteLine(chr2);
            if (!p.ravenstvo(chr, chr2))
            {
                p.printError("Shifra! "); // виклик методу помилки шифру                
            }
            Console.ReadKey();
        }
    }
}

