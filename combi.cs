using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Project
{   
    internal class combi
    {
        public double d_value;
        public int n, r;
        public double result;

        internal class factorial // 팩토리얼
        {
            static long Factorial(int n, int r)
            {
                if (n == 0 || n == 1)
                {
                    return 1;
                }
                return n * Factorial(n - 1);
            }
        }
    

         internal class comb // 조합
         {
             static long factorial(int n)
             {
                if (n >= 1)
                {
                    result = factorial(n) / factorial(n - r) / factorial(r);
                }
             }
         }
    

        internal class perm // 순열
        {
            static long factorial(int n, int r)
            {
                if (n >= 1)
                { result = factorial(n) / factorial(n - r); }
            }
        }
    }
}
