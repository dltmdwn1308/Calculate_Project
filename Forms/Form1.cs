using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Calculate_Project.simplipy;

namespace Calculate_Project
{
    public partial class Form1 : Form
    {
        double x, y, result;
        char operation;

        public Form1()
        {
            InitializeComponent();
        }

        private void AppendToInput(string value)
        {
            textBox_result.Text += value;
        }

        private void button_0_Click(object sender, EventArgs e)
        {
            AppendToInput("0");
        }

        private void button_1_Click(object sender, EventArgs e)
        {
            AppendToInput("1");
        }

        private void button_2_Click(object sender, EventArgs e)
        {
            AppendToInput("2");
        }

        private void button_3_Click(object sender, EventArgs e)
        {
            AppendToInput("3");
        }

        private void button_4_Click(object sender, EventArgs e)
        {
            AppendToInput("4");
        }

        private void button_5_Click(object sender, EventArgs e)
        {
            AppendToInput("5");
        }

        private void button_6_Click(object sender, EventArgs e)
        {
            AppendToInput("6");
        }

        private void button_7_Click(object sender, EventArgs e)
        {
            AppendToInput("7");
        }

        private void button_8_Click(object sender, EventArgs e)
        {
            AppendToInput("8");
        }

        private void button_9_Click(object sender, EventArgs e)
        {
            AppendToInput("9");
        }


        private void button_add_Click(object sender, EventArgs e)
        {
            fourbase addFile = new fourbase();
            operation = '+';
        }

        private void button_minus_Click(object sender, EventArgs e)
        {
            fourbase addFile = new fourbase();
            operation = '-';
        }

        private void button_multiply_Click(object sender, EventArgs e)
        {
            fourbase addFile = new fourbase();
            operation = 'x';
        } 

        private void button_division_Click(object sender, EventArgs e)
        {
            fourbase addFile = new fourbase();
            operation = '/';
        }

        private void button_factorial_Click(object sender, EventArgs e)
        {
            combi addFile = new combi();
            int n = int.Parse(textBox_result.Text);

            long result = combi.factorial(n);
        }

        private void button_comb_Click(object sender, EventArgs e)
        {
            combi addFile = new combi();
            int n = int.Parse(textBox_result.Text);
            int r = int.Parse(textBox_result.Text);

            long result = combi.comb(n, r);
        }

        private void button_perm_Click(object sender, EventArgs e)
        {
            combi addFile = new combi();
            int n = int.Parse(textBox_result.Text);
            int r = int.Parse(textBox_result.Text);

            long result = combi.perm(n, r);
        }

        private void button_ABS_Click(object sender, EventArgs e)
        {
            double input = double.Parse(textBox_result.Text);
            double result = ABS.getvalue(x);
        }

        private void button_round_Click(object sender, EventArgs e)
        {
            double input = double.Parse(textBox_result.Text);
            double result = Round.getvalue(x);
        }
    }
}
