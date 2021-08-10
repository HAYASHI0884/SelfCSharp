using System;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数値を入力して下さい。");
            var num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.Write("■ ");
            }

            Console.WriteLine("数値を入力して下さい。");
            var num2 = int.Parse(Console.ReadLine());
            int i2 = 1;

            while (i2 <= num2)
            {
                i2++;
                Console.Write("■ ");
            }
        }
    }
}