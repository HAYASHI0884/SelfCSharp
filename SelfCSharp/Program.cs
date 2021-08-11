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
            Console.WriteLine("数値を入力してください");
            int n = int.Parse(Console.ReadLine());
            int num = n;
            int ans = num;

            for (int i = 1; i < n; i++)
            {
                ans *= num - i;
            }

            Console.WriteLine(ans);
        }
    }
}