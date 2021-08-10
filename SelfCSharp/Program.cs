using System;
using System.Collections.Generic;
using System.Linq;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 10; i++)
            {
                for (int f = 1; f <= 10; f++)
                {
                    if (f <= i)
                    {
                        Console.Write("■ ");
                    }
                    else
                    {
                        Console.Write("□ ");
                    }
                }

                Console.WriteLine();
            }

            Console.WriteLine();

            for (int i = 1; i <= 10; i++)
            {
                for (int f = 1; f <= 10; f++)
                {
                    if (f != i)
                    {
                        Console.Write("■ ");
                    }
                    else
                    {
                        Console.Write("□ ");
                    }
                }

                Console.WriteLine();
            }
        }
    }
}