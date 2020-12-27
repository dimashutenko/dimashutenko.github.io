using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_13
{
    class Product
    {
        private string name;
        private int price;
        private int production;
        private int quantity;
        public string Name 
        {
            get
            {
                return name;
            }
        }
        public int Price
        {
            set 
            {
                if (value <= 10)
                    price = 10;
                else if (value >= 250)
                    price = 250;
                else
                    price = value;
            }
            get
            {
                return price;
            }
        }
        public int Production
        {
            get
            {
                return production;
            }
        }
        public int Quantity
        {
            set
            {
                if (value < 0)
                    quantity = 0;
                else if (value > 100)
                    quantity = 100;
                else
                    quantity = value;
            }
            get
            {
                return quantity;
            }
        }
        public Product(string name, int price, int production, int quantity)
        {
            this.name = name;
            this.price = price;
            this.production = production;
            this.quantity = quantity;
        }
        public static Product TheMostExpensiveProduct(Product[] products)
        {
            Product pricy = products[0];
            for (int i = 1; i < 5; i++)
            {
                if (products[i].Price > pricy.Price)
                    pricy = products[i];
            }
            return pricy;
        }
        public static Product TheBiggestQuantity(Product[] products)
        {
            Product high_number = products[0];
            for (int i = 1; i < 5; i++)
            {
                if (products[i].Quantity > high_number.Quantity)
                    high_number = products[i];
            }
            return high_number;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Our goods:");
            Product [] Products = new Product[5];
            Products[0] = new Product("Ball", 200, 2018, 50);
            Products[1] = new Product("Hat", 150, 2017, 30);
            Products[2] = new Product("Cup", 80, 2017, 60);
            Products[3] = new Product("Bat", 250, 2018, 10);
            Products[4] = new Product("Sneakers", 240, 2019, 90);
            
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("\n"+ (i+1) + " product is " + Products[i].Name + ".\nThe price is " + Products[i].Price + ".\nThe product was produced in " + Products[i].Production + ".\n" + Products[i].Quantity + " items aveilable. ");
            }

            Console.WriteLine("\n\nThe most expensive product is " + Product.TheMostExpensiveProduct(Products).Name);
            Console.WriteLine("\n\nThe biggest number of product: " + Product.TheBiggestQuantity(Products).Name + ".\n" + Product.TheBiggestQuantity(Products).Quantity + " products of this kind are aveilable.\nWith 10% discount product costs " + Product.TheBiggestQuantity(Products).Price*0.9);
            Console.ReadLine();
        }
    }
}
