using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace SimpleCalculator
{
    public partial class Form1 : Form
    {
        double operand1, operand2, Result;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtOperand1.Text);
            operand2 = Convert.ToDouble(txtOperand2.Text);
            Result = operand1 + operand2;
            txtResult.Text = Result.ToString();
        }

        private void btnSubstract_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtOperand1.Text);
            operand2 = Convert.ToDouble(txtOperand2.Text);
            Result = operand1 - operand2;
            txtResult.Text = Result.ToString();
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            operand1 = Convert.ToDouble(txtOperand1.Text);
            operand2 = Convert.ToDouble(txtOperand2.Text);
            Result = operand1 * operand2;
            txtResult.Text = Result.ToString("#0.00");//Formate  to 2 decimal number
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            //prevent zero division
            if (Convert.ToDouble(txtOperand2.Text) != 0)
            {
                operand1 = Convert.ToDouble(txtOperand1.Text);
                operand2 = Convert.ToDouble(txtOperand2.Text);
                Result = operand1 / operand2;
                txtResult.Text = Result.ToString();
            }
            else
            {

            }
        }

        //Prevent user from entering non-digit number
        private void txtOperand1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand1.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtOperand2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && (e.KeyChar == '.' ? txtOperand2.Text.Contains('.') == true : true))
                e.Handled = true;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            txtOperand1.Text = String.Empty;
            txtOperand2.Text = "";
            txtResult.Text = "";
        }

    }
}
