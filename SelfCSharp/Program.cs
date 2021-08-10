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
            int result = rnd.Next(1, 11);

            Console.WriteLine(result);

            if (5 <= result)
            {
                for (int i = 1; i <= result; i++)
                {
                    Console.Write("★ ");
                }
            }
            else
            {
                for (int i = 1; i <= result; i++)
                {
                    Console.Write("☆ ");
                }
            }
        }
    }
}