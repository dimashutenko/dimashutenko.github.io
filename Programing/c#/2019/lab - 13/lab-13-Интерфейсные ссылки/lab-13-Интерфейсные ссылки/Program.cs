using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_13_Интерфейсные_ссылки
{
    public interface IClient
    {
       void Info();
    }
    class Client 
    {
        public string Name;
        public Client(string name)
        {
            Name = name;
        }
    }
    class Saver : Client, IClient
    {
        public Saver(string name) : base(name) { }
        public void Info()
        {
            Console.WriteLine("Info about Saver " + base.Name + ": has a deposit.");
        }
    }
    class Borrower : Client, IClient
    {
        public Borrower(string name) : base(name) { }
        public void Info()
        {
            Console.WriteLine("Info about Borrower "  + base.Name + ": has a loan.");
        }
    }
    class Program
    {
        static void Main()
        {
            List<Client> Clients = new List<Client>();
            while (true)
            {
                Console.Write("\nDo you want to enter a client (yes/no)? ");
                string go = Convert.ToString(Console.ReadLine());
                if (go == "yes")
                {
                    Console.Write("\nEnter type of client: 1 - Saver, 2 - Borrower. Your choice: ");
                    int answer = int.Parse(Console.ReadLine());
                    if (answer == 1)
                    {
                        Console.Write("What is the saver's name? ");
                        string name = Convert.ToString(Console.ReadLine());
                        Clients.Add(new Saver(name));
                    }
                    else if (answer == 2)
                    {
                        Console.Write("What is the borrower's name? ");
                        string name = Convert.ToString(Console.ReadLine());
                        Clients.Add(new Borrower(name));
                    }
                    else
                        Console.WriteLine("Invalid input. Try again)");
                }
                else if (go == "no")
                {
                    Console.Write("Press any button to continue");
                    Console.ReadKey();
                    break;
                }
                else
                    Console.WriteLine("Invalid input. Try again)");
            }
            Console.WriteLine("\n\n\nHere are all the savers");
            foreach (Client client in Clients)
                {
                    if (client is Saver)
                        ((Saver)client).Info();
                }
            Console.WriteLine("\n\nHere are all the borrowers");
            foreach (Client client in Clients)
                {
                    if(client is Borrower)
                        ((Borrower)client).Info();
                }
            Console.ReadLine();
        }
    }
}
