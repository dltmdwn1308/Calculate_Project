using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculate_Project
{
    public partial class Form1 : Form
    {
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





    }
}
