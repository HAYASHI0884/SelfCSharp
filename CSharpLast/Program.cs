using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLast
{
    class Program
    {
        static void Main(string[] args)
        {
            Random r = new Random();
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            //int result = r.Next(0, 11);
            //Console.WriteLine(result);

            for (int i = 1; i != 0; i++)
            {
                int result = r.Next(0, 11);
                if (result == 0)
                {
                    Console.WriteLine($"0~10の値を出力:{result}");
                    break;
                }
                else if (result % 2 == 0)
                {
                    Console.WriteLine($"0~10の値を出力:{result}");
                    even.Add(result);
                }
                else
                {
                    Console.WriteLine($"0~10の値を出力:{result}");
                    odd.Add(result);
                }
            }

            Console.Write("偶数:");

            foreach (int e in even)
            {
                Console.Write($"{e} ");
            }

            Console.WriteLine();
            Console.Write("奇数:");

            foreach (int o in odd)
            {
                Console.Write($"{o} ");
            }

        }
    }
}