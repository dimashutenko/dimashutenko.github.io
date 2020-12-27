using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Module
{
    class Program
    {
        class ABONENT
        {
            public string Name;
            public string Init;
            public string Nomer;
            public string Adress;
            public ABONENT() { }
            public ABONENT(string name, string init, string nomer, string adress)
            {
                Name = name;
                Init = init;
                Nomer = nomer;
                Adress = adress;
            }
            public void Print()
            {
                Console.WriteLine("\nSubscriber " + Name +" " + Init + " has an adress: " + Adress);
            }
        }
        static void Main(string[] args)
        {
            ABONENT[] TELEFON = new ABONENT[3];
            for (int i = 0; i < TELEFON.Length; i++)
            {
                Console.Write("\nEnter " + (i + 1) + " subscriber's surname: ");
                string name = Convert.ToString(Console.ReadLine());
                Console.Write("Enter " + (i + 1) + " subscriber's initials: ");
                string initials = Convert.ToString(Console.ReadLine());
                Console.Write("Enter " + (i + 1) + " subscriber's number: ");
                string number = Convert.ToString(Console.ReadLine());
                Console.Write("Enter " + (i + 1) + " subscriber's adress: ");
                string adress = Convert.ToString(Console.ReadLine());
                TELEFON[i] = new ABONENT(name, initials, number, adress);
            }
            while (true)
            {
                Console.Write("\nEnter subscriber's surname that you want to find: ");
                string surname = Convert.ToString(Console.ReadLine());
                string flag ="no";
                for (int i = 0; i < TELEFON.Length; i++ )
                {
                    if (TELEFON[i].Name.ToLower()== surname.ToLower())
                    {
                        TELEFON[i].Print();
                        flag = "yes";
                    }
                }
                if (flag == "no")
                    Console.Write("We don't have this subscriber! Try again)");
                if (flag == "yes")
                    break;
            }
            
            Console.ReadLine();
        }
    }
}
