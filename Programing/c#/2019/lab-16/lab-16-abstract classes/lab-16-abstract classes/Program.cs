using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_16_abstract_classes
{
    abstract class Cafe_Network
    {
        public string Name {get; set;}
        public abstract void Thanks_Dish(); 
    }

    class Ukrainian_cafe : Cafe_Network
    {
        public Ukrainian_cafe(string name)
        {
            Name = name;
        }
        public override void Thanks_Dish()
        {
            Console.WriteLine("Let " + Name + " show our gratitude presenting you Borsh\n");
        }
    }
    class American_cafe : Cafe_Network
    {
        public American_cafe(string name)
        {
            Name = name;
        }
        public override void Thanks_Dish()
        {
            Console.WriteLine("Let " + Name + " show our gratitude presenting you Cheesecake\n");
        }
    }
    class European_cafe : Cafe_Network
    {
        public European_cafe(string name)
        {
            Name = name;
        }
        public override void Thanks_Dish()
        {
            Console.WriteLine("Let " + Name + " show our gratitude presenting you Pizza\n");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Ukrainian_cafe Ukrainian_cafe_1 = new Ukrainian_cafe("Panych");
            Ukrainian_cafe_1.Thanks_Dish();
            American_cafe American_cafe_1 = new American_cafe("Mc'Kinley");
            American_cafe_1.Thanks_Dish();
            European_cafe European_cafe_1 = new European_cafe("Piazza Duomo");
            European_cafe_1.Thanks_Dish();
            Console.ReadLine();
        }
    }
}
