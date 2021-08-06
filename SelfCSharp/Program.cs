using System;

namespace SelfCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("i=");
            var i = int.Parse(Console.ReadLine());
            if (30 <= i && i <= 70)
            {
                Console.WriteLine("30より大きく70以下です");
            }

            Console.WriteLine("a=");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("b=");
            int b = int.Parse(Console.ReadLine());
            if (a == b)
            {
                Console.WriteLine("aはbと等しい");
            }
            else if (a < b)
            {
                Console.WriteLine("aはbよりも小さい");
            }
            else
            {
                Console.WriteLine("aはbよりも大きい");
            }

            Console.WriteLine("num=");
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                Console.WriteLine("この数は偶数です。");
            }
            else
            {
                Console.WriteLine("この数は奇数です。");
            }

            Console.WriteLine("季節を入力(1:春 2:夏 3:秋 4:冬)");
            int season = int.Parse(Console.ReadLine());
            switch (season)
            {
                case 1:
                    Console.WriteLine("春です");
                    break;
                case 2:
                    Console.WriteLine("夏です");
                    break;
                case 3:
                    Console.WriteLine("秋です");
                    break;
                case 4:
                    Console.WriteLine("冬です");
                    break;
                default:
                    Console.WriteLine("エラーです");
                    break;

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

                    Console.WriteLine("a,bに1から10までの数値を入力してください。");
                    int a2 = int.Parse(Console.ReadLine());
                    int b2 = int.Parse(Console.ReadLine());
                    if (a2 < 0 || 10 < a2 || b2 < 0 || 10 < b2)
                    {
                        Console.WriteLine("範囲外です。");
                    }
                    else if (a2 > b2)
                    {
                        Console.WriteLine("aのほうが大きいです。");
                    }
                    else if (a2 < b2)
                    {
                        Console.WriteLine("bのほうが大きいです");
                    }
                    else
                    {
                        Console.WriteLine("等しいです。");
                    }

                    Random rnd = new System.Random();
                    int result = rnd.Next(-10, 36);
                    if (result < -10 || 35 <= result)
                    {
                        Console.WriteLine("適切な値を入力してください");
                    }
                    else if (30 <= result)
                    {
                        Console.WriteLine($"摂氏{result}度");
                        Console.WriteLine("真夏日です");
                    }
                    else if (25 <= result && result < 30)
                    {
                        Console.WriteLine($"摂氏{result}度");
                        Console.WriteLine("夏日です");
                    }
                    else if (0 <= result && result < 25)
                    {
                        Console.WriteLine($"摂氏{result}度");
                    }
                    else if (result < 0)
                    {
                        Console.WriteLine($"摂氏{result}度");
                        Console.WriteLine("真冬日です");
                    }
            }

        }
    }
}
