using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wincalculator
{
    public partial class Form1 : Form

    {
        int res = 0;
        string optration;

        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            txtresultBox.Text = txtresultBox.Text + "1";
            if (txtresultBox.Text == "0")
            {
                txtresultBox.Clear();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            txtresultBox.Text = txtresultBox.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            txtresultBox.Text = txtresultBox.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            txtresultBox.Text = txtresultBox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            txtresultBox.Text = txtresultBox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            txtresultBox.Text = txtresultBox.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            txtresultBox.Text = txtresultBox.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            txtresultBox.Text = txtresultBox.Text + "8";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            txtresultBox.Text = txtresultBox.Text + "0";
        }

        private void btnpoint_Click(object sender, EventArgs e)
        {
            txtresultBox.Text = txtresultBox.Text + ".";
        }

        private void btnequal_Click(object sender, EventArgs e)
        {
            int val2 = Convert.ToInt32(txtresultBox.Text);

            switch (optration)
            {
                case "+":
                    txtresultBox.Text = (res + val2).ToString();
                    break;

                case "-":
                    txtresultBox.Text = (res - val2).ToString();
                    break;

                case "*":
                    txtresultBox.Text = (res * val2).ToString();
                    break;

                case "/":
                    txtresultBox.Text = (res / val2).ToString();
                    break;

            }
        }

        private void btnplus_Click(object sender, EventArgs e)
        {
            res = Convert.ToInt32(txtresultBox.Text);
            txtresultBox.Text = "";
            optration = "+";

        }

        private void btn9_Click(object sender, EventArgs e)
        {
            txtresultBox.Text = txtresultBox.Text + "9";
        }

        private void btnCE_Click(object sender, EventArgs e)
        {
            
              txtresultBox.Clear();
        }

        private void btnC_Click(object sender, EventArgs e)
        {

            txtresultBox.Clear();
        }

        private void btnminus_Click(object sender, EventArgs e)
        {
            res = Convert.ToInt32(txtresultBox.Text);
            txtresultBox.Text = "";
            optration = "-";
        }

        private void btnmultiple_Click(object sender, EventArgs e)
        {
            res = Convert.ToInt32(txtresultBox.Text);
            txtresultBox.Text = "";
            optration = "*";
        }

        private void btndivide_Click_1(object sender, EventArgs e)
        {
            res = Convert.ToInt32(txtresultBox.Text);
            txtresultBox.Text = "";
            optration = "/";
        }

        private void button_click(object sender, EventArgs e)
        {
            
        }
    }
    }

