using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP_MODUL3_103022400126
{
    public partial class Form1 : Form
    {
        int firstNum = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(labelOutput.Text))
            {
                labelOutput.Text = "0";
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text == "0") labelOutput.Text = "1";
            else labelOutput.Text += "1";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text == "0") labelOutput.Text = "2";
            else labelOutput.Text += "2";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text == "0") labelOutput.Text = "3";
            else labelOutput.Text += "3";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text == "0") labelOutput.Text = "4";
            else labelOutput.Text += "4";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text == "0") labelOutput.Text = "5";
            else labelOutput.Text += "5";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text == "0") labelOutput.Text = "6";
            else labelOutput.Text += "6";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text == "0") labelOutput.Text = "7";
            else labelOutput.Text += "7";
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text == "0") labelOutput.Text = "8";
            else labelOutput.Text += "8";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text == "0") labelOutput.Text = "9";
            else labelOutput.Text += "9";
        }

        private void button11_Click(object sender, EventArgs e)
        {
            if (labelOutput.Text != "0") labelOutput.Text += "0";
        }

        private void button10_Click(object sender, EventArgs e)
        {
            firstNum = int.Parse(labelOutput.Text);
            labelOutput.Text = "0";
        }

        private void button12_Click(object sender, EventArgs e)
        {
            int secondNum = int.Parse(labelOutput.Text);

            int result = firstNum + secondNum;

            labelOutput.Text = result.ToString();
        }
    }
}