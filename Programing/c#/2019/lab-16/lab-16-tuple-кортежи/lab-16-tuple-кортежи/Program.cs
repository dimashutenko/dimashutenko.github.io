using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab_16_tuple_кортежи
{
    class Program
    {
        static int SumArraySegments(ArraySegment<int>[] value)
        {
            int sum = 0;
            foreach (var s in value)
                for (int i = s.Offset; i < s.Offset + s.Count; i++)
                {
                    if(s.Array[i]>=0)
                        sum += s.Array[i];
                }
            return sum;
        }

        static void Main(string[] args)
        {
            int[] f = { -1, 4, 3, 4, 8, 6 };
            int[] r = { -3, 8, 2, -4 };
            int[] fi = { -1, 5, -3, 4, 1, 6 };
            int[] rt = { -5, 6, 9, -1 };
            var mySegmentsArray = new ArraySegment<int>[4]
            {
                // Инициализируем сегменты массивов
                new ArraySegment<int>(f,2,4),
                new ArraySegment<int>(r,0,4),
                new ArraySegment<int>(fi,0,2),
                new ArraySegment<int>(rt,1,3)
            };
            Console.WriteLine("Sum of required items: " + SumArraySegments(mySegmentsArray));
            Console.ReadLine();
        }

    }

}
