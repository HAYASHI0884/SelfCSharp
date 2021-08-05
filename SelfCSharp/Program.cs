using System;
using System.IO;
using System.Text.RegularExpressions;

namespace SelfCSharp
{
    class Program
    {
        static void Main()
        {
            var str = "となりのきゃくはよくきゃくくうきゃくだ";
            //var rgx = new Regex("きゃく");
            //var result = rgx.Matches(str);

            Console.WriteLine(str.LastIndexOf("きゃく"));

            //foreach (Match m in result)
            //{
            //    Console.WriteLine(m.Index);
            //}

            //var str2 = "□△の気温は□△℃です。";
            //var array = new[] { "弘前", "15.156" };
            //foreach (var ary in array)
            //{
            //    Console.WriteLine(str2.Replace("□△", ary[0]));
            //}

            var loc = "弘前";
            var temp = 15.156;
            Console.WriteLine(String.Format("{0}の気温は{1:F1}", loc, temp));
        }
    }
}

