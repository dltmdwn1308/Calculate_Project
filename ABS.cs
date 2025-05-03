using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace Calculate_Project
{
    internal class ABS
    {
        internal class ABS // 절대값
        {
            double result;
            double firstNum;

        if(double.TryParse(textBox_cal.Text, out result) // 오류 방지
            {
                double textBox_result.Text = double.Parse(textBox_cal.Text);

                double result = Math.Abs(firstNum);
                textBox_result.Text = result.ToString();
            }
        }

        internal class round // 반올림
        {
            double result;
            double firstNum;

            if (double.TryParse(textBox_input.Text, out input))
            {
                double textBox_result.Text = double.Parse(textBox_cal.Text);

            double result = Math.Round(firstNum)
                    textBox_result.Text = result.ToString();
            }
    }
}
}
