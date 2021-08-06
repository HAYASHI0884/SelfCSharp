using System;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new System.Random();

            int[] a = new int[7];

            for (int i = 0; i < a.Length; i++)
            {
                int result = rnd.Next(1, 11);
                a[i] = result;
                Console.WriteLine(a[i]);
            }
        }
    }
}