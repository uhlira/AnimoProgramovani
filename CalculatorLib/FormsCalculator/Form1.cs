using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormsCalculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            CalculateAdd();
        }

        private void num_Number1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void num_Number1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return)) CalculateAdd();
        }

        private void num_Number2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.Equals(Keys.Return)) CalculateAdd();
        }

        private void CalculateAdd() 
        {
            decimal number1 = num_Number1.Value;
            decimal number2 = num_Number2.Value;

            Calculator.Calculator calc = new Calculator.Calculator();
            double result = calc.Add(Convert.ToDouble(number1), Convert.ToDouble(number2));

            lbl_Result.Text = result.ToString();
        }
    }
}
