using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            var count = new List<string> { };

            for (int a = 1; a <= 100; a++)
            {
                for (int b = 1; b <= 100; b++)
                {
                    for (int c = 1; c <= 100; c++)
                    {
                        if (Math.Pow(a, 2) + Math.Pow(b, 2) == Math.Pow(c, 2) && a < b)
                        {
                            string p = $"a = {a}, b = {b}, c = {c}";
                            count.Add(p);
                            Console.WriteLine(p);
                        }
                    }
                }
            }

            Console.WriteLine(count.Count);
        }
    }
}