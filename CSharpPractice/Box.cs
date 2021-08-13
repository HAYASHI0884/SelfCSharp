using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    //  四角形クラス
    class Box : PlaneFigure
    {
        //  コンストラクタ（引数なし）
        public Box()
        {
        }
        //  コンストラクタ（引数あり）
        public Box(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        //  面積の取得
        public override double Area
        {
            get { return width * height; }
        }
    }
}