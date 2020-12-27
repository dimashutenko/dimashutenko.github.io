using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab___2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;
            string str1 = "Начальнику служби охорони";
            string str2 = "Петрову С.Г.";
            string str3 = "Службова записка";
            string str4 = "Прошу дати наказ охороні університету видавати ключі від кімнати студентської ради (к.345) тільки голові студентської ради.";
            string str5 = "Декан інформаційних технологій";
            string str6_0 = "   	       	";
            string str7 = "Сергієв К.Г.";
            Console.WriteLine(str1 + "\n" + str2 + "\n" + str3 + "\n" + str4 + "\n" + str5 + str6_0 + str7 + "\n\n\n\n_________________________________________________________________\n\n");
            Console.WriteLine(str2.Replace("Петрову С.Г.", "\t\t\t\t\t Петрову С.Г.\n"));
            Console.WriteLine(str3.Replace("Службова записка", "\t\t\t    Службова записка\n"));
            Console.WriteLine(str4.Remove(109, 8).Replace("студ ", "студ. ").Replace("Прошу", "        Прошу").Replace("кімнати", "  кімнати ").Replace("студентської", "студентської ").Replace("ради.", "ради. ").Replace("тільки", "тільки ").Replace("голові", "голові ").Replace("345", "201").Replace("и.", "и   Теневичу П. С."));
            Console.WriteLine("\n" + str5.Replace("Декан інформаційних технологій", "  Проректор \n  з впровадження інформаційних технологій  \t  Іванов К.Г.\n\n\n\n"));
            Console.WriteLine("    1 курс      2 курс      3 курс      4 курс      5 курс   \n");
            int[][] groups = new int[5][];
            groups[0] = new int[] { 10, 13, 15, 17, 19, 12, 20, 14 };
            groups[1] = new int[] { 12, 11, 13, 14, 22, 15, 10, 13 };
            groups[2] = new int[] { 11, 19, 14, 11, 15, 11, 21, 19 };
            groups[3] = new int[] { 13, 17, 13, 23, 17, 17, 19, 11 };
            groups[4] = new int[] { 15, 22, 19, 11, 19, 18, 10, 13 };
            for (int j = 0; j < 8; j++)
                {
                    for (int i = 0; i < groups.Length; i++)
                        {
                            Console.Write("      {0}    ", groups[i][j]);
                        }
                    Console.WriteLine();
                }
            int counter=0;
            for( int p=0; p<groups[3].Length; p++)
            {
                counter += groups[3][p];
            }
            Console.Write("\nСреднее колличество студентов в группе на 3 курсе: {0}", counter / groups[3].Length);
            string string_1 = "Життя – це посмішка уранці,";
            string string_2 = "Це фотографія у рамці,";
            string string_3 = "Життя – це посмішка крізь сльози,";
            string string_4 = "Життя – це сонце і морози!";
            string string_5 = "Життя – це квіти навесні,";
            string string_6 = "Життя – це жарти і пісні.";
            string string_7 = "Життя – це кайф, як не крути,";
            string string_8 = "Його нам варто перейти!";
            Console.WriteLine("\n\n" + string_1 + "\n" + string_2 + "\n" + string_3 + "\n" + string_4 + "\n" + string_5 + "\n" + string_6 + "\n" + string_7 + "\n" + string_8);
            char[] chararray_1 = string_1.ToCharArray();
            char[] chararray_2 = string_2.ToCharArray();
            char[] chararray_3 = string_3.ToCharArray();
            char[] chararray_4 = string_4.ToCharArray();
            char[] chararray_5 = string_5.ToCharArray();
            char[] chararray_6 = string_6.ToCharArray();
            char[] chararray_7 = string_7.ToCharArray();
            char[] chararray_8 = string_8.ToCharArray();
            Array.Reverse(chararray_1);
            Array.Reverse(chararray_2);
            Array.Reverse(chararray_3);
            Array.Reverse(chararray_4);
            Array.Reverse(chararray_5);
            Array.Reverse(chararray_6);
            Array.Reverse(chararray_7);
            Array.Reverse(chararray_8);
            Console.WriteLine("\n" + new string(chararray_1) + "\n" + new string(chararray_2) + "\n" + new string(chararray_3) + "\n" + new string(chararray_4) + "\n" + new string(chararray_5) + "\n" + new string(chararray_6) + "\n" + new string(chararray_7) + "\n" + new string(chararray_8) + "\n");
            string[] array_of_strings = {string_1, string_2, string_3, string_4, string_5, string_6, string_7, string_8};
            foreach(string array in array_of_strings)
            {
                if (array.ToLower().Contains("життя"))
                Console.WriteLine("Слово 'життя' повторюється в рядку \n{0}\n ", array);
            }
            Console.WriteLine();
            for (int i = 15; i <= 75; i++)
            {
                if (i == 75)
                    Console.WriteLine("БІКС");
                else if (i % 5 == 0)
                    Console.Write("БІКС,");
                else
                    Console.Write(" {0}, ", i);
            }
            int[,] TwoDimentional_Array = new int[,] { { 1, 2 }, { 3, 4 }, { 5, 6 }, { 7, 8 } };
            double sum = 0;
            int sum_of_squared_elements = 0;
            Console.WriteLine("\n\nДан двумерный массив\n");
            for (int i = 0; i < TwoDimentional_Array.GetLength(0); i++)
            {
                for (int j = 0; j < TwoDimentional_Array.GetLength(1); j++)
                {
                    Console.Write(TwoDimentional_Array[i, j] + " ");
                    sum += TwoDimentional_Array[i,j];
                    sum_of_squared_elements += (int)Math.Pow(TwoDimentional_Array[i, j], 2);
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nСумма массива: "+ sum);
            Console.WriteLine("\nCуммa квадратов всех элементов массива: " +sum_of_squared_elements);
            Console.WriteLine("\nСреднее арифметическое всех элементов массива: {0}", sum / TwoDimentional_Array.Length);
            Console.ReadKey();
        }
    }
}
