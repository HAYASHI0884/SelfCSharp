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
            var list = new List<int>(10);

            for (int i = 0; i < list.Capacity; i++)
            {
                int result = rnd.Next(1, 11);
                list.Add(result);
                Console.Write($"{result} ");
            }

            Console.WriteLine();
            Console.WriteLine($"最大値 : {list.Max()}");
            Console.WriteLine($"最小値 : {list.Min()}");
            Console.WriteLine($"平均値 : {list.Average()}");
        }
    }
}