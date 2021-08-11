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
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 || (30 <= i && i < 40) || i.ToString().Contains("3") == true)
                {
                    Console.WriteLine("☆");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}