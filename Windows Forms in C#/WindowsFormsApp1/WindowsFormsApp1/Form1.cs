﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                double result = num1 + num2;
                Result.Text = "Addition of Two numbers are: " + result.ToString();
                Result.Visible = true;
                //MessageBox.Show("Addition of Two numbers are: " + result.ToString());

            }

            else
            {
                MessageBox.Show("Please Fill Both Fields.");
            }

        }

        private void SubtractButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                double result = num1 - num2;
                Result.Text = "Subtraction of Two numbers are: " + result.ToString();
                Result.Visible = true;
                //MessageBox.Show("Addition of Two numbers are: " + result.ToString());

            }

            else
            {
                MessageBox.Show("Please Fill Both Fields.");
            }
        }

        private void MultiplicationButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                double result = num1 * num2;
                Result.Text = "Multiply of Two numbers are: " + result.ToString();
                Result.Visible = true;
                //MessageBox.Show("Addition of Two numbers are: " + result.ToString());

            }

            else
            {
                MessageBox.Show("Please Fill Both Fields.");
            }
        }

        private void DivisionButton_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "")
            {
                double num1 = double.Parse(textBox1.Text);
                double num2 = double.Parse(textBox2.Text);

                double result = num1 / num2;
                Result.Text = "Division of Two numbers are: " + result.ToString();
                Result.Visible = true;
                //MessageBox.Show("Addition of Two numbers are: " + result.ToString());

            }

            else
            {
                MessageBox.Show("Please Fill Both Fields.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox1.Text != "" && textBox2.Text != "")
            {
                textBox1.Clear();
                textBox2.Clear();

                Result.Text = "No Result";
                Result.Visible = true;
            }
            
            
        }
        private void Result_Click(object sender, EventArgs e)
        {
          
        }
    }
}
