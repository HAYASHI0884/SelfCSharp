using System;
using System.Text;

namespace SelfCSharp
{
    class Program
    {
        static void Main()
        {
            int sum = 0;

            for (int i = 100; i <= 200; i++)
            {
                if (i % 2 == 0)
                {
                    continue;
                }

                sum += i;
            }

            Console.WriteLine($"合計額は{sum}です。");
        }
    }
}
