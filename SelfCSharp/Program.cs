using System;
using System.IO;
using System.Text.RegularExpressions;
using System.Collections.Generic;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hayashi");
            Console.Write("123");
            Console.Write("456");
            Console.WriteLine("789");
            Console.WriteLine("こんにちは");
            Console.WriteLine("{0} + {1} = {2}", 5, 3, 5 + 3);
            Console.WriteLine("{0} - {1} = {2}", 5, 3, 2);
            Console.WriteLine("{0} * {1} = {2}", 5, 2, 10);
            Console.WriteLine("{0} / {1} = {2}", 5, 2, 2);
            Console.WriteLine("{0} % {1} = {2}", 5, 2, 1);
            int a = 1, b = 2, c = 3, d = 4, e = 5;
            a = a + 2;
            b = b - 1;
            c = c * 3;
            d = d / 2;
            e = e % 2;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine(c);
            Console.WriteLine(d);
            Console.WriteLine(e);
            string str1 = Console.ReadLine();
            string str2 = Console.ReadLine();
            Console.WriteLine(str1 + str2);
        }
    }
}

