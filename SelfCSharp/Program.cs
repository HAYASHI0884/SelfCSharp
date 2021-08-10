using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            var list = new List<int>(5);
            var orMore = new List<int>();
            var orLess = new List<int>();

            for (int i = 0; i < list.Capacity; i++)
            {
                int result = rnd.Next(1, 11);
                list.Add(result);
                Console.Write($"{result} ");
            }

            int listAverage = (int)list.Average();

            Console.WriteLine();
            Console.WriteLine($"合計値 : {list.Sum()}");
            Console.WriteLine($"平均値 : {listAverage}");

            foreach (int num in list)
            {
                if (listAverage < num)
                {
                    orMore.Add(num);
                }
                else
                {
                    orLess.Add(num);
                }
            }

            Console.WriteLine();
            Console.Write($"平均値より大きい数 : ");
            foreach (int num2 in orMore)
            {
                Console.Write(num2 + " ");
            }

            Console.WriteLine();
            Console.Write($"平均値より小さい数 : ");
            foreach (int num3 in orLess)
            {
                Console.Write(num3 + " ");
            }
        }
    }
}