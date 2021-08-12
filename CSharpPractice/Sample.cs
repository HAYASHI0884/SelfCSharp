using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    internal class Sample
    {
        public Sample()
        {
            Console.WriteLine("スタート");
        }

        public void func()
        {
            Console.WriteLine("func");
        }

        ~Sample()
        {
            Console.WriteLine("エンド");
        }
    }
}