using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace lab_16_Regex
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter your login: ");
                string password = Convert.ToString(Console.ReadLine());
                // 2-10 символов, только буквы и цифры, цифра не может быть 1 и последней.
                //   
                Regex myReg = new Regex(@"^[a-zA-Z]{1}[0-9a-zA-Z]{8}[a-zA-Z]{1}$");
                if (myReg.IsMatch(password))
                {
                    Console.WriteLine("\nValid login");
                    break;
                }
                else
                {
                    Console.Write("\nInvalid login. Press any button to try again.");
                    Console.ReadKey(); Console.ReadKey();
                    Console.Clear();
                }
            }
            Console.ReadLine();
        }
    }
}
