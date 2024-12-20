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
                    
                    stringChain = value;
                    lbl_History.Text = stringChain;

                    if (stringChain == "0")
                    {
                        stringChain = String.Empty;
                    }
                    
                    /*
                    stringChain = value;

                    if (stringChain.EndsWith("+") || stringChain.EndsWith("-"))
                    {
                        //MessageBox.Show(stringChain);
                        Result += Convert.ToInt32(stringChain.Substring(0, stringChain.Length-1));
                        stringChain = stringChain.Substring(stringChain.Length - 1, 1);
                    }
                    */
                    //lbl_Result.Text = Result.ToString();
                    lbl_History.Text = StringChain.ToString();
                }

                if (stringChain.Contains("="))
                {
                    EnteringEnded = true;
                    //lbl_Result.Text = ((double)new Expression(stringChain.Substring(0, stringChain.Length - 1) + " + 0.0").Evaluate()).ToString();
                    //lbl_Result.Text = ((double) new Expression(stringChain.Substring(0, stringChain.Length-1) + " + 0.0").Evaluate()).ToString();
                }
            }
        }

        public string StringValue { get; set; }

        public Parentheses Result { get; set; }
        //public int Result { get; set; }

        private bool EnteringEnded { get; set; } = false;

        public CalculatorForm()
        {
            InitializeComponent();
            Result = new Parentheses();         
            StringChain = string.Empty;
            //StringChain.Replace;
            //StringChain = Result.Compute().ToString();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += 1;
                StringValue += 1;
            }
        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += 2;
                StringValue += 2;
            }
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += 3;
                StringValue += 3;
            }
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += 4;
                StringValue += 4;
            }
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += 5;
                StringValue += 5;
            }
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += 6;
                StringValue += 6;
            }
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += 7;
                StringValue += 7;
            }
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += 8;
                StringValue += 8;
            }
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += 9;
                StringValue += 9;
            }
        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += 0;
                StringValue += 0;
            }
        }

        private void btn_Minus_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded) 
            {
                StringChain += "-";
                Result.NumericOperation.Add(Convert.ToDecimal(StringValue));
                Result.NumericOperation.Set(OperationType.MINUS);
                lbl_Result.Text = Result.Compute().ToString();
                StringValue = "0";
            }
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += "+";
                Result.NumericOperation.Add(Convert.ToDecimal(StringValue));
                Result.NumericOperation.Set(OperationType.PLUS);
                lbl_Result.Text = Result.Compute().ToString();
                StringValue = "0";
            }
        }
        private void btn_Multiple_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += "/";

                Result = Result.DescendantParentheses = new Parentheses();

                Result.NumericOperation.Add(Convert.ToDecimal(StringValue));
                Result.NumericOperation.Set(OperationType.PLUS);

                lbl_Result.Text = Result.Compute().ToString();
                StringValue = "0";
            }
        }

        private void btn_Divide_Click(object sender, EventArgs e)
        {

        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            if (!EnteringEnded)
            {
                StringChain += "=";

                Result.NumericOperation.Add(Convert.ToDecimal(StringValue));
                lbl_Result.Text = Result.Compute().ToString();
            }
        }
        private void btn_Cancel_Click(object sender, EventArgs e)
        {
            EnteringEnded = false;
            StringChain = string.Empty;
            StringValue = "0";
            lbl_Result.Text = "0";
            Result = new Parentheses();
        }

        
    }

    public enum OperationType 
    {
        PLUS, 
        MINUS, 
        MULTIPLE, 
        DIVIDE
    }

    public class NumericOperation 
    {
        public decimal Result { get; set; } = 0;
        public OperationType OperationType { get; set; } = OperationType.PLUS;

        public void Set(OperationType operation) 
        {
            OperationType = operation;
        }

        public void Add(decimal number) 
        {
            switch (OperationType) 
            {
                case OperationType.PLUS: Result += number;
                    break;

                case OperationType.MINUS: Result -= number;
                    break;

                case OperationType.MULTIPLE: Result *= number;
                    break;

                case OperationType.DIVIDE: Result /= number;
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
        public override string ToString()
        {
            return Compute().ToString();
        }
    }
}
