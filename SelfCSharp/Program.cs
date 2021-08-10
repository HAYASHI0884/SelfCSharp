using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                for (int f = 1; f <= 9; f++)
                {
                    Console.Write(f + "*" + i + "=" + i * f + " ");
                }

                Console.WriteLine();
            }
        }
    }
}