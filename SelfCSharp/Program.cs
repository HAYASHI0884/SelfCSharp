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
            int[,] data = new int[3, 3];
            int max = 0;
            int min = 9;

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int result = rnd.Next(1, 10);
                    data[i, j] = result;
                    Console.Write(result + " ");
                    if (max < result)
                    {
                        max = result;
                    }
                    if (result < min)
                    {
                        min = result;
                    }
                }
                Console.WriteLine();
            }

            Console.WriteLine($"最大値 : {max}");
            Console.WriteLine($"最小値 : {min}");
        }
    }
}