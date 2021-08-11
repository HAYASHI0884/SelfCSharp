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
            //MinMax m = new MinMax();
            //int a = 3, b = 2, c = 1;
            //Console.WriteLine("{0}と{1}と{2}のうち、最大のものは{3}", a, b, c, m.Max(a, b, c));
            //Console.WriteLine("{0}と{1}と{2}のうち、最小のものは{3}", a, b, c, m.Min(a, b, c));

            Calc c = new Calc();
            double a = 4.1, b = 2.3;
            Console.WriteLine($"{a} + {b} = {c.Add(a, b)}");
            Console.WriteLine($"{a} - {b} = {c.Sub(a, b)}");
        }
    }
}