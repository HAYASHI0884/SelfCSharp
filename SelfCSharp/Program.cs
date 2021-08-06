using System;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("i=");
            //var i = int.Parse(Console.ReadLine());
            //if (30 <= i && i <= 70)
            //{
            //    Console.WriteLine("30より大きく70以下です");
            //}

            //Console.WriteLine("a=");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("b=");
            //int b = int.Parse(Console.ReadLine());
            //if (a == b)
            //{
            //    Console.WriteLine("aはbと等しい");
            //}
            //else if (a < b)
            //{
            //    Console.WriteLine("aはbよりも小さい");
            //}
            //else
            //{
            //    Console.WriteLine("aはbよりも大きい");
            //}

            //Console.WriteLine("num=");
            //int num = int.Parse(Console.ReadLine());
            //if (num % 2 == 0)
            //{
            //    Console.WriteLine("この数は偶数です。");
            //}
            //else
            //{
            //    Console.WriteLine("この数は奇数です。");
            //}

            //Console.WriteLine("季節を入力(1:春 2:夏 3:秋 4:冬)");
            //int season = int.Parse(Console.ReadLine());
            //switch (season)
            //{
            //    case 1:
            //        Console.WriteLine("春です");
            //        break;
            //    case 2:
            //        Console.WriteLine("夏です");
            //        break;
            //    case 3:
            //        Console.WriteLine("秋です");
            //        break;
            //    case 4:
            //        Console.WriteLine("冬です");
            //        break;
            //    default:
            //        Console.WriteLine("エラーです");
            //        break;

            Console.WriteLine("1から100までの数値を入力してください");
            int Range = int.Parse(Console.ReadLine());
            if (20 <= Range && Range < 80)
            {
                Console.WriteLine("20以上80未満です。");
            }
            else if (Range < 0 || 100 < Range)
            {
                Console.WriteLine("範囲外です。");
            }
            else
            {
                Console.WriteLine("20未満か80以上です。");
            }
        }

    }
}

