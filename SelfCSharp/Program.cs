using System;
using System.Text;

namespace SelfCSharp
{
    class Program
    {
        static void Main()
        {
            Console.Write("整数値を入力：");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("a=" + a);
            if (a > 0)
            {
                Console.WriteLine("aは正の数です。");
            }
        }
    }
}
