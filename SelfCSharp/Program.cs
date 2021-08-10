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
            MinMax m = new MinMax();
            int a = 4, b = 2;
            Console.WriteLine($"{0}と{1}のうち、最大のものは{2}", a, b, m.Max(a, b));
            Console.WriteLine($"{0}と{1}のうち、最小のものは{2}", a, b, m.Min(a, b));
        }
    }
}