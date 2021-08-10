using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new System.Random();

            int[] a = new int[5];
            var even = new List<int>();
            var odd = new List<int>();

            for (int i = 0; i < a.Length; i++)
            {
                int result = rnd.Next(1, 101);
                a[i] = result;
                Console.WriteLine(a[i]);

                if (result % 2 == 0)
                {
                    even.Add(result);
                }
                else
                {
                    odd.Add(result);
                }
            }

            int intMax = a.Max();
            int intMin = a.Min();

            Console.WriteLine($"最大値:{intMax}");
            Console.WriteLine($"最小値:{intMin}");
            Console.WriteLine($"偶数の数{even.Count}");
            Console.WriteLine($"奇数の数{odd.Count}");
        }
    }
}