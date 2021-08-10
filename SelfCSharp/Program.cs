using System;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = 0;

            while (0 <= num)
            {
                Console.WriteLine("0以上の数値を入力して下さい。");
                num = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("終了します");
        }
    }
}