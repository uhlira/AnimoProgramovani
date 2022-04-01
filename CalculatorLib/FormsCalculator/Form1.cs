using NCalc;
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
    public partial class CalculatorForm : Form
    {

        private string stringChain;

        public string StringChain
        {
            get { return stringChain; }
            set
            {
                if (!EnteringEnded)
                {
                    /*
                    stringChain = value;
                    lbl_History.Text = stringChain;

                    if (stringChain == "0")
                    {
                        stringChain = String.Empty;
                    }
                    */
                    stringChain = value;

                    if (stringChain.EndsWith("+") || stringChain.EndsWith("-"))
                    {
                        //MessageBox.Show(stringChain);
                        Result += Convert.ToInt32(stringChain.Substring(0, stringChain.Length-1));
                        stringChain = stringChain.Substring(stringChain.Length - 1, 1);
                    }

                    lbl_Result.Text = Result.ToString();
                    lbl_History.Text = StringChain.ToString();
                }

                if (stringChain.Contains("="))
                {
                    EnteringEnded = true;
                    lbl_Result.Text = ((double)new Expression(stringChain.Substring(0, stringChain.Length - 1) + " + 0.0").Evaluate()).ToString();
                    //lbl_Result.Text = ((double) new Expression(stringChain.Substring(0, stringChain.Length-1) + " + 0.0").Evaluate()).ToString();
                }
            }
        }

        //public Parentheses Result { get; set; }
        public int Result { get; set; }

        private bool EnteringEnded { get; set; } = false;

        public CalculatorForm()
        {
            InitializeComponent();
            //Result = new Parentheses();
            Result = 0;          
            StringChain = string.Empty;
            //StringChain = Result.Compute().ToString();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            StringChain += 1;
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            StringChain += 2;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            StringChain += 3;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            StringChain += 4;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            StringChain += 5;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            StringChain += 6;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            StringChain += 7;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            StringChain += 8;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            StringChain += 9;
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            StringChain += 0;
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            StringChain += "-";
            //Result.NumericOperation.Add(OperationType.MINUS, Convert.ToDecimal(StringChain));
            //StringChain = String.Empty;
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            StringChain += "+";
            //Result.NumericOperation.Add(OperationType.PLUS, Convert.ToDecimal(StringChain));
            //StringChain = String.Empty;
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            StringChain += "=";
            //StringChain = Result.Compute().ToString();
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            EnteringEnded = false;
            StringChain = string.Empty;
            lbl_Result.Text = string.Empty;
        }
    }

    public enum OperationType 
    {
        PLUS, 
        MINUS
    }

    public class NumericOperation 
    {
        public decimal Result { get; set; } = 0;

        public void Add(OperationType operation, decimal number) 
        {
            switch (operation) 
            {
                case OperationType.PLUS: Result += number;
                    break;

                case OperationType.MINUS: Result -= number;
                    break;
            }
        }
    }

    public class Parentheses 
    {
        public NumericOperation NumericOperation { get; set; }
        public Parentheses DescendantParentheses { get; set; }

        public Parentheses()
        {
            NumericOperation = new NumericOperation();
        }

        public decimal Compute() 
        {
            if (DescendantParentheses != null)
                return NumericOperation.Result + DescendantParentheses.Compute();
            else return NumericOperation.Result;
        }
    }
}
