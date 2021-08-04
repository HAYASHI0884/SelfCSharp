using System;
using System.Text;

namespace SelfCSharp
{
    class Program
    {
        static void Main()
        {
            var str = "プログラミング言語";
            var strings = "鈴木\t太郎\t男\t50歳\t広島県";
            var result = strings.Split("\t");

            Console.WriteLine(str.Substring(4, 3));
            Console.WriteLine(string.Join(",", result));
        }
    }
}
