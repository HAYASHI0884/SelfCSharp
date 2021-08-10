using System;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int[,] data = new int[3, 3];

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int result = rnd.Next(1, 10);
                    data[i, j] = result;
                    Console.Write(result + " ");
                }
                Console.WriteLine();
            }
        }
    }
}