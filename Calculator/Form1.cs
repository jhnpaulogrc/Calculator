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
        float ansMS;
        bool enterVal;


        private void Form1_Load(object sender, EventArgs e)
        {
            bttnMR.Enabled = false;
            bttnMC.Enabled = false;
        }
        private void txtOutput_TextChanged(object sender, EventArgs e)
        {

        }
        private void AppendDisplay(String number)
        {
            if (txtOutput.Text=="0"||enterVal == true)
            {
                txtOutput.Text = number;
                enterVal = false;
            }
            else
            {
                txtOutput.Text += number;
            }
        }
        private void bttn0_Click(object sender, EventArgs e)
        {
            AppendDisplay("0");
        }
        private void bttn1_Click(object sender, EventArgs e)
        {
            AppendDisplay("1");
        }

        private void bttn2_Click(object sender, EventArgs e)
        {
            AppendDisplay("2");
        }

        private void bttn3_Click(object sender, EventArgs e)
        {
            AppendDisplay("3");
        }

        private void bttn4_Click(object sender, EventArgs e)
        {
            AppendDisplay("4");
        }

        private void bttn5_Click(object sender, EventArgs e)
        {
            AppendDisplay("5");
        }

        private void bttn6_Click(object sender, EventArgs e)
        {
            AppendDisplay("6");
        }

        private void bttn7_Click(object sender, EventArgs e)
        {
            AppendDisplay("7");
        }

        private void bttn8_Click(object sender, EventArgs e)
        {
            AppendDisplay("8");
        }
        private void bttn9_Click(object sender, EventArgs e)
        {
            AppendDisplay("9");
        }

        private void bttnPoint_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.Contains(".") == false)
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
            try
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
            catch (Exception)
            {

            }
           
        }
        private void bttnEqual_Click(object sender, EventArgs e)
        {
         enterVal = true;
         compute(count);   
        }

        private void bttnClear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
            float numInput = 0;
            float ans = 0;
        }
        private void bttnClearEntry_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
        }
        private void bttnDelete_Click(object sender, EventArgs e)
        {
            if (txtOutput.TextLength > 0)
            {
                txtOutput.Text = txtOutput.Text.Remove(txtOutput.TextLength - 1, 1);
            }
        }

        private void bttnNegative_Click(object sender, EventArgs e)
        {
            if (txtOutput.Text.StartsWith("-"))
            {
                txtOutput.Text = txtOutput.Text.Substring(1);
            }
            else if (txtOutput.Text != "0")
            {
                txtOutput.Text = "-" + txtOutput.Text;
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
                
            }
        }
        private void bttnSqrt_Click(object sender, EventArgs e)
        {
            txtOutput.Text = Math.Sqrt(float.Parse(txtOutput.Text)).ToString();
        }

        private void bttnFraction_Click(object sender, EventArgs e)
        {
            txtOutput.Text = (1/(float.Parse(txtOutput.Text))).ToString();
        }

        private void bttnSquared_Click(object sender, EventArgs e)
        {
            txtOutput.Text = Math.Pow(float.Parse(txtOutput.Text), 2).ToString();
        }

        private void bttnMS_Click(object sender, EventArgs e)
        {
            bttnMR.Enabled = true;
            bttnMC.Enabled = true;
            ansMS = float.Parse(txtOutput.Text);
            enterVal = true;
        }

        private void bttnMR_Click(object sender, EventArgs e)
        {
            txtOutput.Text = ansMS.ToString();
        }

        private void bttnMC_Click(object sender, EventArgs e)
        {
            bttnMR.Enabled = false;
            bttnMC.Enabled = false;
            ansMS = 0;
            enterVal = true;
        }
    }
}
