using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        float numInput;
        float ans;
        int count;

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
        private void bttn0_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "0";
        }
        private void bttn1_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "1";
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "2";
        }

        private void bttn3_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "3";
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "4";
        }

        private void bttn5_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "5";
        }

        private void bttn6_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "6";
        }

        private void bttn7_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "7";
        }

        private void bttn8_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "8";
        }
        private void bttn9_Click(object sender, EventArgs e)
        {
            txtOutput.Text = txtOutput.Text + "9";
        }

        private void bttnPoint_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Contains(".")==false)
            {
                txtOutput.Text = txtOutput.Text + ".";
            }
            else
            {
                return;
            }
        }

        private void generateInput()
        {
            numInput = float.Parse(txtOutput.Text);
            txtOutput.Clear();
        }

        private void bttnAdd_Click(object sender, EventArgs e)
        {
            generateInput();
            count = 1;
        }
       
        private void bttnSubtract_Click(object sender, EventArgs e)
        {
            generateInput();
            count = 2;
        }

        private void bttnMultiply_Click(object sender, EventArgs e)
        {
            generateInput();
            count = 3;
        }

        private void bttnDivide_Click(object sender, EventArgs e)
        {
            generateInput();
            count = 4;
        }
    
        private void compute(int count)
        {
            switch (count)
            {
                case 1:
                    ans = numInput + float.Parse(txtOutput.Text);
                    txtOutput.Text = ans.ToString();
                    break;
                case 2:
                    ans = numInput - float.Parse(txtOutput.Text);
                    txtOutput.Text = ans.ToString();
                    break;
                case 3:
                    ans = numInput * float.Parse(txtOutput.Text);
                    txtOutput.Text = ans.ToString();
                    break;
                case 4:
                    ans = numInput / float.Parse(txtOutput.Text);
                    txtOutput.Text = ans.ToString();
                    break;
                    default:
                    break;
            }
        }
        private void bttnEqual_Click(object sender, EventArgs e)
        {
         compute(count);   
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
          txtOutput.Clear();
        }

        private void bttnNegative_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Contains("-") == false)
            {
                txtOutput.Text = "-" + txtOutput.Text ;
                numInput = float.Parse(txtOutput.Text);
            }
            else
            {
                txtOutput.Text = txtOutput.Text;
                numInput = float.Parse(txtOutput.Text);
            }
        }
        private void bttnPercent_Click(object sender, EventArgs e)
        {
            try
            {
                numInput = float.Parse(txtOutput.Text);
                ans = numInput / 100;
                txtOutput.Text = ans.ToString();
            }
            catch (Exception)
            {
                throw;
            }
        }

    }
}
