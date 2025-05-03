using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Project.CalMath
{
    public class CalMath
    {
        public double Square(double x)
        {
            return x * x;
        }

        public double Power(double x, double y)
        {
            return Math.Pow(x, y);
        }

        public double SquareRoot(double x)
        {
            return Math.Sqrt(x);
        }

        public double Log(double x)
        {
            return Math.Log10(x);
        }

        public double NaturalLog(double x)
        {
            return Math.Log(x);
        }

        public double Exp(double x)
        {
            return Math.Exp(x);
        }
    }
}
