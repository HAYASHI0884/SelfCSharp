using System;
using System.Text;
using System.Text.RegularExpressions;

namespace SelfCSharp
{
    class Program
    {
        static void Main()
        {
            var str = "住所は〒184-9000 鎌ヶ谷市梶野町0-0-0です。\nあなたの住所は〒273-0000 嬬恋市大野町0-9-9ですね";
            var rgx = new Regex(@"\d{3}-\d{4}", RegexOptions.Multiline);
            var match = rgx.Matches(str);
            foreach (var m in match)
            {
                Console.WriteLine(m);
            };

            var str2 = "お問い合わせはhoge@example.comまで";
            var rgx2 = new Regex(@"[a-z0-9.!#$%&'*+/=?^_{-}~-]+@[a-z0-9-]+(?:¥.[a-z0-9-]+)*", RegexOptions.IgnoreCase);
            Console.WriteLine(rgx2.Replace(str2, "<a href='mailto:$0'>$0</a>"));
        }
    }
}
