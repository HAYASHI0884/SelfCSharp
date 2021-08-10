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
            var orMore = new List<int>();
            var orLess = new List<int>();

            for (int i = 0; i < list.Capacity; i++)
            {
                int result = rnd.Next(1, 101);
                list.Add(result);
                Console.Write($"{result} ");

                if (50 <= result)
                {
                    orMore.Add(result);
                }
                else
                {
                    orLess.Add(result);
                }
            }

            Console.WriteLine();
            Console.Write($"50以上の数 : ");
            foreach (int num in orMore)
            {
                Console.Write(num + " ");
            }

            Console.WriteLine();
            Console.Write($"50未満の数 : ");
            foreach (int num2 in orLess)
            {
                Console.Write(num2 + " ");
            }

        }
    }
}