using System;
using System.Text;

namespace SelfCSharp
{
    class Program
    {
        static void Main()
        {
            for (int i = 0; i < 6; Console.WriteLine($"{i}番目のループです。"), i++) ;
            for (int i = 1, j = 1; i < 6; i++, j++)
            {
                Console.WriteLine(i * j);
            }
        }
    }
}
