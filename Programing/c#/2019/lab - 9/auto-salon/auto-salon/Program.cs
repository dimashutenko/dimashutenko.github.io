using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace auto_salon
{
    class Program
    {
        class Car
        {
            public string Model;
            public int Price;
            public int Year;
            public string Color;
            public string Type;

            public Car()
            {

            }

            public Car(string model, int price,int year, string color, string type )
            {
                Model = model;
                Price = price;
                Year = year;
                Color = color;
                Type = type;
            }

            public void CarInfo()
            {
                Console.WriteLine("\nАвтомобиль {0} за {1} грн: {2} годa выпуска, {3} цвет, тип кузова: {4}", Model, Price, Year, Color, Type);
            }

       }

        /*
         * public static void CarsInfo(Car []cars)
        {
            foreach( Car car in cars)
                Console.WriteLine("\nАвтомобиль {0} за {1} грн: {2} годa выпуска, {3} цвет, тип кузова: {4}", car.Model, car.Price, car.Year, car.Color, car.Type);
        }
        */
        /*
        public static void BiggestPrice(int price , Car [] cars)
        {
            foreach (Car car in cars)
            {
                if (car.Price > price)
                    price = car.Price;

            }
            Console.WriteLine("Самый дорогой автомобиль:" + price);

        }
        */
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            Car[] Cars = new Car[5];
            int  Price = 0;
            int Year = 0;
            int BiggestPrice = 0;
            string Color, Type, answer;
            while (true)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.Write("\nВведите модель автомобиля: ");
                    string Model = Convert.ToString(Console.ReadLine());
                    while (true)
                    {
                        Console.Write("Введите цену автомобиля " + Model + ": ");
                        try
                        {
                            Price = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message + "Попробуйте еще раз");
                        }
                    }
                    while (true)
                    {
                        Console.Write("Введите год выпуска автомобиля " + Model + ": ");
                        try
                        {
                            Year = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                        catch (Exception ex)
                        {
                            Console.WriteLine(ex.Message + "Попробуйте еще раз");
                        }
                    }
                    Console.Write("Введите цвет автомобиля " + Model + ": ");
                    Color = Convert.ToString(Console.ReadLine());
                    Console.Write("Введите тип автомобиля " + Model + ": ");
                    Type = Convert.ToString(Console.ReadLine());
                    Cars[i] = new Car(Model, Price, Year, Color, Type);
                    Cars[i].CarInfo();
                    Console.Write("\nЕсли вы хотите ввести еще один автомобиль, нажмите Enter. Или напишите нет ");
                     answer = Convert.ToString(Console.ReadLine()).ToLower();
                    if (answer == "ytn" || answer == "нет")
                        break;                    
                } 
                break;
            }
            Console.Write("\n\nПредлагаем Вам вывести все автомобили изготовлены после определенного года. Введите год: ");
            Year = Convert.ToInt32(Console.ReadLine());
            try
            {
                foreach (Car car in Cars)
                {
                    if (car.Year >= Year)
                        car.CarInfo();
                }
            }
            catch (NullReferenceException)
            {

            }
            finally
            {
                Console.WriteLine("\nБольше автомобилей по вашему запросу нет");
            }
            while (true)
            {
                Console.WriteLine("\n\nХотите вывести Ваш автопарк? (да/нет) ");
                answer = Convert.ToString(Console.ReadLine()).ToLower();
                if (answer == "lf" || answer == "да")
                {
                    try
                    {
                        foreach (Car car in Cars)
                            car.CarInfo();
                    }
                    catch (NullReferenceException)
                    {

                    }
                    break;
                }
                else if (answer == "ytn" || answer == "нет")
                {
                    Console.Write("Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                }
                else
                    Console.WriteLine("Мы Вас не поняли, попробуйте еще раз");
            }
            while (true)
            {
                Console.WriteLine("\n\nХотите вывести все машины зеленого цвета? (да/нет) ");
                answer = Convert.ToString(Console.ReadLine()).ToLower();
                if (answer == "lf" || answer == "да")
                {
                    try
                    {
                        foreach (Car car in Cars)
                        {
                            if (car.Color == "зеленый" || car.Color == "ptktysq" || car.Color == "green" || car.Color == "зеленій")
                                car.CarInfo();
                        }
                            
                    }
                    catch (NullReferenceException)
                    {

                    }
                    break;
                }
                else if (answer == "ytn" || answer == "нет")
                {
                    Console.Write("Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                }
                else
                    Console.WriteLine("Мы Вас не поняли, попробуйте еще раз");
            }
            while(true)
            {
            Console.Write("Хотите вывести самый дорогой автомобиль? (да/нет) ");
            answer = Convert.ToString(Console.ReadLine());
            if (answer == "lf" || answer == "да")
                {
                    Car TheMostExpensiveCar = new Car();
                    foreach (Car car in Cars)
                    {
                        try
                        {
                            if (car.Price >= BiggestPrice)
                            {
                                BiggestPrice = car.Price;
                                TheMostExpensiveCar = car;
                            }
                        }
                        catch (NullReferenceException)
                        {

                        }
                    }
                    Console.WriteLine("Самый дорогой автомобиль: ");
                    TheMostExpensiveCar.CarInfo();
                    break;
                }
                else if (answer == "ytn" || answer == "нет")
                {
                    Console.Write("Нажмите любую клавишу...");
                    Console.ReadKey();
                    break;
                }
                else
                    Console.WriteLine("Мы Вас не поняли, попробуйте еще раз");
            } 
            
            
            Console.ReadKey();
        }
    }
}
