using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculate_Project
{
    internal class fourbase
    {
        double firstNum = double.Parse(textBox_first.Text);
        double secondNum = double.Parse(textBox_second.Text);
        double result = 0;
        
        switch (operation)
            {
                case ('+'):
                    result = firstNum + secondNum;
                    break;
                case ('-'):
                    result = firstNum - secondNum;
                    break;
                case ('x'):
                result = firstNum* secondNum;
                    break;
                case ('/'):
                result = firstNum / secondNum;
                    break;
            }

    textBox_result.Text = result.ToString();

    }
}
