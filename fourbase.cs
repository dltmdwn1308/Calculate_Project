using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Project
{

    internal class fourbase
    {
        public double d_value;
        public double x, y, result;
        public char operation;
        
        switch (operation)
            {
                case ('+'):
                    result = x + y;
                    break;
                case ('-'):
                    result = x - y;
                    break;
                case ('x'):
                    result = x * y;
                    break;
                case ('/'):
                    if (y == 0)
                    {
                        MessageBox.Show("0으로 나눌 수 없습니다");
                        return;
                    }
                    result = x / y;
                    break;
            }
    }
}
