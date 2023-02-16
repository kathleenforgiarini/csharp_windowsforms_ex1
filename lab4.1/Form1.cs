using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// CODED BY KATHLEEN FORGIARINI DA SILVA
// 2023-02-15
// LAB 4.1 - Create a simple calculator with Windows Form

namespace lab4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Welcome to my calculator!", "CalculaTOP");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void number1_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value1 = Convert.ToDouble(number1.Text);
            }
            catch (Exception)
            {
                number1.Text = "0";
            }
        }
        private void number2_TextChanged(object sender, EventArgs e)
        {
            try
            {
                double value2 = Convert.ToDouble(number2.Text);
            }
            catch (Exception)
            {
                number2.Text = "0";
            }
        }
    
        private void add_Click(object sender, EventArgs e)
        {
            double addition = Convert.ToDouble(number1.Text) + Convert.ToDouble(number2.Text);
            resAdd.Text = addition.ToString();
        }

        private void sub_Click(object sender, EventArgs e)
        {
            double subtraction = Convert.ToDouble(number1.Text) - Convert.ToDouble(number2.Text);
            resSub.Text = subtraction.ToString();
        }

        private void mul_Click(object sender, EventArgs e)
        {
            double multiplication = Convert.ToDouble(number1.Text) * Convert.ToDouble(number2.Text);
            resMul.Text = multiplication.ToString();
        }

        private void div_Click(object sender, EventArgs e)
        {
            double division = Math.Round(Convert.ToDouble(number1.Text) / Convert.ToDouble(number2.Text),5);
            resDiv.Text = division.ToString();
        }

        private void exit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to close the calculator?", "Exit", MessageBoxButtons.YesNo).ToString() == "Yes")
            {
                this.Close();
            }
        }
    }
}
