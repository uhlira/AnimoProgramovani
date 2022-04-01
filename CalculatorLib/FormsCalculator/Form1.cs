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
                stringChain = value;
                //OnPropertyChanged("StringChain");
                lbl_Result.Text = stringChain;
            }
        }

        public Parentheses Result { get; set; }

        protected virtual void OnPropertyChanged(string property)
        {           
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(property));    
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public CalculatorForm()
        {
            InitializeComponent();
            if (Result == null) Result = new Parentheses();
            StringChain = Result.Compute().ToString();
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            StringChain = StringChain + 1;
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
            Result.NumericOperation.Add(OperationType.MINUS, Convert.ToDecimal(StringChain));
            StringChain = String.Empty;
        }

        private void btn_Plus_Click(object sender, EventArgs e)
        {
            Result.NumericOperation.Add(OperationType.PLUS, Convert.ToDecimal(StringChain));
            StringChain = String.Empty;
        }

        private void btn_Calculate_Click(object sender, EventArgs e)
        {
            StringChain = Result.Compute().ToString();
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
