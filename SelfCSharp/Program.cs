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
                if (num != i)
                {
                    Console.Write("■ ");
                }
                else
                {
                    Console.WriteLine("■ ");
                }
            }

            Console.WriteLine("数値を入力して下さい。");
            var num2 = int.Parse(Console.ReadLine());
            int i2 = 1;

            while (i2 <= num2)
            {
                if (num2 != i2)
                {
                    Console.Write("■ ");
                }
                else
                {
                    Console.WriteLine("■ ");
                }

                i2++;

            }

            Console.WriteLine("数値を入力して下さい。");
            var num3 = int.Parse(Console.ReadLine());
            int i3 = 1;

            do
            {
                if (num3 != i3)
                {
                    Console.Write("■ ");
                }
                else
                {
                    Console.WriteLine("■ ");
                }

                i3++;

            } while (i3 <= num3);
        }
    }
}