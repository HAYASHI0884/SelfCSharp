using System;
using System.Text;

namespace SelfCSharp
{
    class Program
    {
        static void Main()
        {
            object obj = "こんにちは";
            switch (obj)
            {
                case int i:
                    Console.WriteLine(Math.Abs(i));
                    break;
                case string str:
                    Console.WriteLine(str[0]);
                    break;
                default:
                    Console.WriteLine("意図しない型です");
                    break;
            }
        }
    }
}
