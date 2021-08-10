using System;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new System.Random();
            int result = 1;

            while (result % 10 != 0)
            {
                result = rnd.Next(1, 101);
                Console.WriteLine(result);
            }

            Console.WriteLine("終了します");
        }
    }
}