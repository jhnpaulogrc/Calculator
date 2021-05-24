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
            txtOutput.Text = txtOutput.Text + ".";
        }
    }
}
