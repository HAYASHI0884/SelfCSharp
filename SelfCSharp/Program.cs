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
            Random rnd = new Random();
            int result = rnd.Next(1, 1001);

            Console.WriteLine(result);

            for (int i = 1; i <= result; i++)
            {
                if (result % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}