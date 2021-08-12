using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Program
    {
        //static int Mul(int a, int b, int c)
        //{
        //    return a * b * c;
        //}

        static void Square(int a, int b)
        {
            if (a != 0 && b != 0)
            {
                for (int i = 1; i <= a; i++)
                {
                    for (int j = 1; j <= b; j++)
                    {
                        Console.Write("■ ");
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            Random r = new Random();
            int a = r.Next(1, 11);
            int b = r.Next(1, 11);
            Console.WriteLine("たて:" + a);
            Console.WriteLine("よこ:" + b);
            Square(a, b);
        }
    }
}
