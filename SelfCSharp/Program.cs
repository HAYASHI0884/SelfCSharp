using System;

namespace SelfCSharp
{
    class Program
    {
        static void Main()
        {
            var date = "2018/02/15 13:17:23";
            var dt = DateTime.Parse(date);
            Console.WriteLine(dt.Year);
            Console.WriteLine(dt.Hour);

            var atdt = DateTime.Now;
            Console.WriteLine(atdt.AddDays(15));
        }
    }
}
