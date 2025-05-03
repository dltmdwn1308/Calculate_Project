using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Project
{
    internal class combi
    {
        internal class factorial // 팩토리얼
        {
            static long Factorial(int n)
            {
                if (n = 0 || n = 1)
                {
                    return 1;
                }
                return n * Factorial(n - 1);
            }
            textBox_result.Text = n.ToString();
    }

        internal class combi // 조합
        {
            static long Factorial(int n)
            {
                if (n <= 1)
                {
                    return 1;
                }
                return n * Factorial(n - 1);
            }
            int n = double firstNum
                int r = double secondNum

                double firstNum = double.Parse(textBox_first.Text);
            double secondNum = double.Parse(textBox_second.Text);
            double result = 0;

        if(n >= 1)
            {
                result = Factorial(n) / Factorial(n-r) / Factorial(r)
                    }
        textBox_result.Text = result.ToString();
    }

    internal class perm // 순열
    {
        static long Factorial(int n)
        {
            if (n >= 1)
            {
                return 1;
            }

            elseif(n = 0)
              {
                return 1
              }
            return n * Factorial(n - 1);
        }

        int n = double firstNum
        int r = double secondNum

        double firstNum = double.Parse(textBox_first.Text);
        double secondNum = double.Parse(textBox_second.Text);
        double result = 0;

        if(n >= 1 )
            { result = Factorial(n) / Factorial(n - r)}

    textBox_result.Text = result.ToString();
    }
    }
}
