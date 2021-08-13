using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpPractice
{
    abstract class PlaneFigure
    {
        //  面積
        protected double area = 0;
        //  幅
        protected double width = 0;
        //  高さ
        protected double height = 0;
        //  コンストラクタ（引数なし）
        public PlaneFigure()
        {
        }
        //  コンストラクタ（引数あり）
        public PlaneFigure(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        //  幅のプロパティ
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        //  高さのプロパティ
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        //  面積の取得
        public abstract double Area
        {
            get;
        }
    }
}