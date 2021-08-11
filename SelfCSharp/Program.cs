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
            int molecule = rnd.Next(1, 10);
            int molecule2 = rnd.Next(1, 10);
            int denominator = rnd.Next(2, 10);
            int denominator2 = rnd.Next(2, 10);

            double mol = molecule * denominator2 + molecule2 * denominator;
            double den = denominator * denominator2;

            Console.WriteLine($"{molecule}/{denominator} + {molecule2}/{denominator2}");
            Console.WriteLine($"{mol}/{den}");

            if (mol == den)
            {
                Console.WriteLine(1);
            }
            else if (mol > den)
            {
                if (mol % denominator == 0)
                {
                    mol /= denominator;
                    den /= denominator;
                }
                else if (mol % denominator2 == 0)
                {
                    mol /= denominator2;
                    den /= denominator2;
                }
                else if (mol % 3 == 0 && den % 3 == 0)
                {
                    mol /= 3;
                    den /= 3;
                }
                else if (mol % 2 == 0 && den % 2 == 0)
                {
                    mol /= 2;
                    den /= 2;
                }
                Console.WriteLine($"{mol}/{den}");
                mol /= den;
                Console.WriteLine($"{mol}/{den}");
            }
            else
            {
                if (mol % denominator == 0)
                {
                    mol /= denominator;
                    den /= denominator;
                }
                else if (mol % denominator2 == 0)
                {
                    mol /= denominator2;
                    den /= denominator2;
                }
                else if (mol % 3 == 0 && den % 3 == 0)
                {
                    mol /= 3;
                    den /= 3;
                }
                else if (mol % 2 == 0 && den % 2 == 0)
                {
                    mol /= 2;
                    den /= 2;
                }
                Console.WriteLine($"{mol}/{den}");
            }
        }
    }
}