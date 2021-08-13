using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    //  三角形クラス
    class Triangle : PlaneFigure
    {
        //  コンストラクタ（引数なし）
        public Triangle()
        {
        }
        //  コンストラクタ（引数あり）
        public Triangle(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        //  面積の取得
        public override double Area
        {
            get { return width * height / 2.0; }
        }
    }
}