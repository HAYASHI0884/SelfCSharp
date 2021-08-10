using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SelfCSharp
{
    internal class MinMax
    {
        public MinMax()
        {
            public int Max(int n1, int n2)
            {
                if (n1 > n2)
                {
                    return n1;
                }
            }

            public int Min(int n1, int n2)
            {
                if (n1 < n2)
                {
                    return n2;
                }
            }
        }
    }
}