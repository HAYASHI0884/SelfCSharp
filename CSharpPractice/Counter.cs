using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    class Counter
    {
        //  カウント
        private int count = 0;
        //  カウントの合計
        private static int totalCount = 0;
        //  コンストラクタ
        public void Reset()
        {
            count = 0;
        }
        //  カウントのインクリメント
        public void Increment()
        {
            count++;
        }
        //  回数のプロパティ
        public int Count
        {
            get
            {
                return count;
            }
        }

        public static int AddTotalCount(int num)
        {
            return totalCount += num;
        }
        //　カウントの合計のプロパティ
        public static int TotalCount
        {
            get
            {
                return totalCount;
            }
        }
    }
}