using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_15_Interfaces_ex._2
{
    public interface ICount
    {
        void AverageAge(int[] ages);
    }
    class Groups : ICount
    {
        private int Sum = 0;
        private double average_age = 0;
        public void AverageAge(int[] ages)
        {
            foreach (var a in ages)
                Sum += a;
            average_age = (double)Sum / (double)ages.Length;
            Console.WriteLine("\nAverage age = " + average_age);
        }
    }
    class BIKS : Groups { }
    class UIB : Groups { }
    class Program
    {
        static void Main(string[] args)
        {
            BIKS BIKS_group = new BIKS();
            Console.WriteLine("Input BIKS students ages one after one pressing Enter between them\n");
            int[] BIKS_ages = new int[5];
            for (int i = 1; i < 6; i++)
            {
                Console.Write(i + " student age is ");
                int age = int.Parse(Console.ReadLine());
                BIKS_ages[i-1] = age;
            }
            BIKS_group.AverageAge(BIKS_ages);
            UIB UIB_group = new UIB();
            Console.WriteLine("\n\nInput UIB students ages one after one pressing Enter between them\n");
            int[] UIB_ages = new int[5];
            for (int i = 1; i < 6; i++)
            {
                Console.Write(i + " student age is ");
                int age = int.Parse(Console.ReadLine());
                UIB_ages[i - 1] = age;
            }
            UIB_group.AverageAge(UIB_ages);
            Console.ReadLine();
        }
    }
}
