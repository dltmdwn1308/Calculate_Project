using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Calculate_Project.CalMath;

namespace Calculate_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void AppendToInput(int a)
        {
            textBox_result.Text += a.ToString();
        }

        private void button_0_Click_1(object sender, EventArgs e)
        {
            AppendToInput(0);
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            AppendToInput(1);
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            AppendToInput(2);
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            AppendToInput(3);
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            AppendToInput(4);
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            AppendToInput(5);
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            AppendToInput(6);
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            AppendToInput(7);
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            AppendToInput(8);
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            AppendToInput(9);
        }

        private void button_sin_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                TrigFunctions tri = new TrigFunctions();
                double result = tri.CalculateSin(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_cos_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                TrigFunctions tri = new TrigFunctions();
                double result = tri.CalculateCos(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_tan_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                TrigFunctions tri = new TrigFunctions();
                double result = tri.CalculateTan(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_asin_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                TrigFunctions tri = new TrigFunctions();
                double result = tri.CalculateArcSin(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_acos_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                TrigFunctions tri = new TrigFunctions();
                double result = tri.CalculateArcCos(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }

        }

        private void button_atan_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                TrigFunctions tri = new TrigFunctions();
                double result = tri.CalculateArcTan(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_square_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                ScientificFunctions sci = new ScientificFunctions();
                double result = sci.Square(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }

        }

        private void button_exp_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                ScientificFunctions sci = new ScientificFunctions();
                double result = sci.Exp(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_pow_Click(object sender, EventArgs e)
        {
            string input = textBox_result.Text;

            if (input.Contains("^"))
            {
                string[] parts = input.Split('^');

                if (parts.Length == 2 && double.TryParse(parts[0], out double basenum) && double.TryParse(parts[1], out double exponent))
                {
                    ScientificFunctions sci = new ScientificFunctions();
                    double result = sci.Pow(basenum, exponent);
                    textBox_result.Text = result.ToString("F4");
                }
                else
                {
                    textBox_result.Text = "입력 형식을 확인하세요";
                }
            }
        }

        private void button_sqrt_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                if (input < 0)
                {
                    textBox_result.Text = "음수는 불가";
                    return;
                }

                ScientificFunctions sci = new ScientificFunctions();
                double result = sci.Sqrt(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_log10_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                if (input <= 0)
                {
                    textBox_result.Text = "log는 0 이하 불가";
                    return;
                }

                ScientificFunctions sci = new ScientificFunctions();
                double result = sci.Log10(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_ln_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                if (input <= 0)
                {
                    textBox_result.Text = "log는 0 이하 불가";
                    return;
                }

                ScientificFunctions sci = new ScientificFunctions();
                double result = sci.Ln(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            textBox_result.Clear();
        }

        private void button_backspace_Click(object sender, EventArgs e)
        {
            if(textBox_result.Text.Length > 0)
            {
                textBox_result.Text = textBox_result.Text.Substring(0, textBox_result.Text.Length - 1);
            }
        }

        private void button_lbTog_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                UnitConverter converter = new UnitConverter();
                double result = converter.LbToG(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_gTolb_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                UnitConverter converter = new UnitConverter();
                double result = converter.GToLb(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_ozTog_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                UnitConverter converter = new UnitConverter();
                double result = converter.OzToG(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_gTooz_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                UnitConverter converter = new UnitConverter();
                double result = converter.GToLb(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_inchTom_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                UnitConverter converter = new UnitConverter();
                double result = converter.InchToM(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_mToinch_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                UnitConverter converter = new UnitConverter();
                double result = converter.MToInch(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_ftTom_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                UnitConverter converter = new UnitConverter();
                double result = converter.FtToM(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }

        private void button_mToft_Click(object sender, EventArgs e)
        {
            double input;
            if (double.TryParse(textBox_result.Text, out input))
            {
                UnitConverter converter = new UnitConverter();
                double result = converter.MToFt(input);
                textBox_result.Text = result.ToString("F4");
            }
            else
            {
                textBox_result.Text = "숫자를 입력해주세요.";
            }
        }
    }
}
