using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_15_Interface
{
    interface IRemote
    {
        void On();
        void Off();
        void Pause();
    }
    class TV : IRemote
    {
        public string Model;
        public TV(string model)
        {
            Model = model;
        }
        public void On()
        {
            Console.WriteLine("You have just turned TV " + Model + " on.");
        }
        public void Off()
        {
            Console.WriteLine("You have just turned TV " + Model + " off.");
        }
        public void Pause()
        {
            Console.WriteLine("You have just paused TV " + Model + ".");
        }
    }
    class Radio : IRemote
    {
        public string Model;
        public Radio(string model)
        {
            Model = model;
        }
        public void On()
        {
            Console.WriteLine("You have just turned radio " + Model + " on.");
        }
        public void Off()
        {
            Console.WriteLine("You have just turned radio " + Model + " off.");
        }
        public void Pause()
        {
            Console.WriteLine("You have just paused radio " + Model + ".");
        }
    }
    class Phone : IRemote
    {
        public string Model;
        public Phone(string model)
        {
            Model = model;
        }
        public void On()
        {
            Console.WriteLine("You have just powered phone " + Model + " on.");
        }
        public void Off()
        {
            Console.WriteLine("You have just powered phone " + Model + " off.");
        }
        public void Pause()
        {
            Console.WriteLine("You have just turned phone " + Model + "off.");
        }
    }
    class PC : IRemote
    {
        public string Model;
        public PC(string model)
        {
            Model = model;
        }
        public void On()
        {
            Console.WriteLine("You have just turned PC " + Model + " on.");
        }
        public void Off()
        {
            Console.WriteLine("You have just turned PC " + Model + " off.");
        }
        public void Pause()
        {
            Console.WriteLine("You have just made your PC " + Model + "turn into sleeping mode.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What device do you want to work with? (1-TV, 2-Radio, 3-Phone or 4-PC) Your choice: ");
            int choice = int.Parse(Console.ReadLine());
            switch (choice)
            {
                case 1:
                    {
                        Console.Write("What is the model of your TV? ");
                        string model = Convert.ToString(Console.ReadLine());
                        TV television = new TV(model);
                        television.Model = model;
                        while (true)
                        {
                            Console.Write("Do you want to power TV " + television.Model + " on? (yes/no) ");
                            string answer = Convert.ToString(Console.ReadLine());
                            if (answer == "yes")
                            {
                                television.On();
                                while (true)
                                {
                                    Console.Write("Do you want to pause TV " + television.Model + "? (yes/no) ");
                                    string answer1 = Convert.ToString(Console.ReadLine());
                                    if (answer1 == "yes")
                                    {
                                        television.Pause();
                                        while (true)
                                        {
                                            Console.Write("Do you want to restart TV " + television.Model + "? (yes/no) ");
                                            string answer2 = Convert.ToString(Console.ReadLine());
                                            if (answer2 == "yes")
                                            {
                                                television.On();
                                                break;
                                            }
                                            else if (answer == "no")
                                            {
                                                while (true)
                                                {
                                                    Console.Write("Do you want to turn TV " + television.Model + "off? (yes/no) ");
                                                    string answer3 = Convert.ToString(Console.ReadLine());
                                                    if (answer == "yes")
                                                    {
                                                        television.Off();
                                                        break;
                                                    }
                                                    else if (answer == "no")
                                                    {
                                                        Console.WriteLine("Press any button to continue)");
                                                        break;
                                                    }
                                                    else
                                                        Console.WriteLine("Something was wrong. Try one more time)");
                                                }
                                                break;
                                            }
                                            else
                                                Console.WriteLine("Something was wrong. Try one more time)");
                                        }
                                        break;
                                    }
                                    else if (answer == "no")
                                    {
                                        Console.WriteLine("Press any button to continue)");
                                        break;
                                    }
                                    else
                                        Console.WriteLine("Something was wrong. Try one more time)");
                                }
                                break;
                            }
                            else if (answer == "no")
                            {
                                Console.WriteLine("Press any button to exit)");
                                break;
                            }
                            else
                                Console.WriteLine("Something was wrong. Try one more time)");
                        }
                        break;
                    }
                case 2:
                    {
                        Console.Write("What is the model of your Radio? ");
                        string model = Convert.ToString(Console.ReadLine());
                        Radio radio = new Radio(model);
                        radio.Model = model;

                        /* adapted for Radio
                         while (true)
                        {
                            Console.Write("Do you want to power TV " + television.Model + " on? (yes/no) ");
                            string answer = Convert.ToString(Console.ReadLine());
                            if (answer == "yes")
                            {
                                television.On();
                                while (true)
                                {
                                    Console.Write("Do you want to pause TV " + television.Model + "? (yes/no) ");
                                    string answer1 = Convert.ToString(Console.ReadLine());
                                    if (answer1 == "yes")
                                    {
                                        television.Pause();
                                        while (true)
                                        {
                                            Console.Write("Do you want to restart TV " + television.Model + "? (yes/no) ");
                                            string answer2 = Convert.ToString(Console.ReadLine());
                                            if (answer2 == "yes")
                                            {
                                                television.On();
                                                break;
                                            }
                                            else if (answer == "no")
                                            {
                                                while (true)
                                                {
                                                    Console.Write("Do you want to turn TV " + television.Model + "off? (yes/no) ");
                                                    string answer3 = Convert.ToString(Console.ReadLine());
                                                    if (answer == "yes")
                                                    {
                                                        television.Off();
                                                        break;
                                                    }
                                                    else if (answer == "no")
                                                    {
                                                        Console.WriteLine("Press any button to continue)");
                                                        break;
                                                    }
                                                    else
                                                        Console.WriteLine("Something was wrong. Try one more time)");
                                                }
                                                break;
                                            }
                                            else
                                                Console.WriteLine("Something was wrong. Try one more time)");
                                        }
                                        break;
                                    }
                                    else if (answer == "no")
                                    {
                                        Console.WriteLine("Press any button to continue)");
                                        break;
                                    }
                                    else
                                        Console.WriteLine("Something was wrong. Try one more time)");
                                }
                                break;
                            }
                            else if (answer == "no")
                            {
                                Console.WriteLine("Press any button to exit)");
                                break;
                            }
                            else
                                Console.WriteLine("Something was wrong. Try one more time)");
                        }
                         * */
                        break;
                    }
                case 3:
                    {
                        Console.Write("What is the model of your Phone? ");
                        string model = Convert.ToString(Console.ReadLine());
                        Phone phone = new Phone(model);
                        phone.Model = model;
                        /* adapted for Phone
                         while (true)
                        {
                            Console.Write("Do you want to power TV " + television.Model + " on? (yes/no) ");
                            string answer = Convert.ToString(Console.ReadLine());
                            if (answer == "yes")
                            {
                                television.On();
                                while (true)
                                {
                                    Console.Write("Do you want to pause TV " + television.Model + "? (yes/no) ");
                                    string answer1 = Convert.ToString(Console.ReadLine());
                                    if (answer1 == "yes")
                                    {
                                        television.Pause();
                                        while (true)
                                        {
                                            Console.Write("Do you want to restart TV " + television.Model + "? (yes/no) ");
                                            string answer2 = Convert.ToString(Console.ReadLine());
                                            if (answer2 == "yes")
                                            {
                                                television.On();
                                                break;
                                            }
                                            else if (answer == "no")
                                            {
                                                while (true)
                                                {
                                                    Console.Write("Do you want to turn TV " + television.Model + "off? (yes/no) ");
                                                    string answer3 = Convert.ToString(Console.ReadLine());
                                                    if (answer == "yes")
                                                    {
                                                        television.Off();
                                                        break;
                                                    }
                                                    else if (answer == "no")
                                                    {
                                                        Console.WriteLine("Press any button to continue)");
                                                        break;
                                                    }
                                                    else
                                                        Console.WriteLine("Something was wrong. Try one more time)");
                                                }
                                                break;
                                            }
                                            else
                                                Console.WriteLine("Something was wrong. Try one more time)");
                                        }
                                        break;
                                    }
                                    else if (answer == "no")
                                    {
                                        Console.WriteLine("Press any button to continue)");
                                        break;
                                    }
                                    else
                                        Console.WriteLine("Something was wrong. Try one more time)");
                                }
                                break;
                            }
                            else if (answer == "no")
                            {
                                Console.WriteLine("Press any button to exit)");
                                break;
                            }
                            else
                                Console.WriteLine("Something was wrong. Try one more time)");
                        }
                         * */
                        break;
                    }
                case 4:
                    {
                        Console.Write("What is the model of your PC? ");
                        string model = Convert.ToString(Console.ReadLine());
                        PC computer = new PC(model);
                        computer.Model = model;
                        /* adapted for PC
                         while (true)
                        {
                            Console.Write("Do you want to power TV " + television.Model + " on? (yes/no) ");
                            string answer = Convert.ToString(Console.ReadLine());
                            if (answer == "yes")
                            {
                                television.On();
                                while (true)
                                {
                                    Console.Write("Do you want to pause TV " + television.Model + "? (yes/no) ");
                                    string answer1 = Convert.ToString(Console.ReadLine());
                                    if (answer1 == "yes")
                                    {
                                        television.Pause();
                                        while (true)
                                        {
                                            Console.Write("Do you want to restart TV " + television.Model + "? (yes/no) ");
                                            string answer2 = Convert.ToString(Console.ReadLine());
                                            if (answer2 == "yes")
                                            {
                                                television.On();
                                                break;
                                            }
                                            else if (answer == "no")
                                            {
                                                while (true)
                                                {
                                                    Console.Write("Do you want to turn TV " + television.Model + "off? (yes/no) ");
                                                    string answer3 = Convert.ToString(Console.ReadLine());
                                                    if (answer == "yes")
                                                    {
                                                        television.Off();
                                                        break;
                                                    }
                                                    else if (answer == "no")
                                                    {
                                                        Console.WriteLine("Press any button to continue)");
                                                        break;
                                                    }
                                                    else
                                                        Console.WriteLine("Something was wrong. Try one more time)");
                                                }
                                                break;
                                            }
                                            else
                                                Console.WriteLine("Something was wrong. Try one more time)");
                                        }
                                        break;
                                    }
                                    else if (answer == "no")
                                    {
                                        Console.WriteLine("Press any button to continue)");
                                        break;
                                    }
                                    else
                                        Console.WriteLine("Something was wrong. Try one more time)");
                                }
                                break;
                            }
                            else if (answer == "no")
                            {
                                Console.WriteLine("Press any button to exit)");
                                break;
                            }
                            else
                                Console.WriteLine("Something was wrong. Try one more time)");
                        }
                         * */
                        break;
                    }
            }
            Console.ReadLine();
        }
    }
}
