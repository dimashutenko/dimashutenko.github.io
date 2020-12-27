using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_10_enum
{
    class Diet
    {
        static int Calories = 0;
        enum Food
        {
            Fries = 250,
            Meat = 400,
            Veges = 100,
            Fruits = 80,
            Tea = 50,
            Coffee = 140
        }

        public static void Choise(int number)
        {
            switch(number)
            {
                case 1:
                    Console.WriteLine("You've eaten fries (250 ccal)");
                    Calories += (int)Food.Fries;
                    Console.WriteLine("Overall consuption: " + Calories);
                    break;
                case 2:
                    Console.WriteLine("You've eaten meat (400 ccal)");
                    Calories += (int)Food.Meat;
                    Console.WriteLine("Overall consuption: " + Calories);
                    break;
                case 3:
                    Console.WriteLine("You've eaten vegetables (100 ccal)");
                    Calories += (int)Food.Veges;
                    Console.WriteLine("Overall consuption: " + Calories);
                    break;
                case 4:
                    Console.WriteLine("You've eaten fruits (80 ccal)");
                    Calories += (int)Food.Fruits;
                    Console.WriteLine("Overall consuption: " + Calories);
                    break;
                case 5:
                    Console.WriteLine("You've drunk tea (50 ccal)");
                    Calories += (int)Food.Tea;
                    Console.WriteLine("Overall consuption: " + Calories);
                    break;
                case 6:
                    Console.WriteLine("You've drunk coffee (140 ccal)");
                    Calories += (int)Food.Coffee;
                    Console.WriteLine("Overall consuption: " + Calories);
                    break;
            }
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.Write("You can eat: \n1-Fries: 250 ccal \n2-Meat: 400 ccal \n3-Vegetables: 100 ccal \n4-Fruits: 80 ccal \nYou can also drink: \n5-Tea: 50 ccal \n6-Coffee: 140 ccal \n\nWhat do you want to start with? Choice: ");
            int choice = Convert.ToInt32(Console.ReadLine());
            Diet.Choise(choice);
            while (true)
            {
                Console.Write("Do you want to eat something else? (yes/no) ");
                string answer = Convert.ToString(Console.ReadLine()).ToLower();
                if (answer == "lf" || answer == "да" || answer == "yes" || answer == "нуі" || answer == "нуы")
                {
                    Console.Write("What do you want to have next? Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());
                    Diet.Choise(choice);
                }
                else if (answer == "ytn" || answer == "нет" || answer == "no"|| answer == "тщ")
                {
                    Console.Write("Press any button to exit...");
                    Console.ReadKey();
                    break;
                }
                else
                    Console.WriteLine("We can't understand it. Try again)");
            }
        }
    }
}
