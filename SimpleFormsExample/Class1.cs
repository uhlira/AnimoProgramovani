using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFormsExample
{
    internal class Class1
    {
        private int Number;

        public Class1(int Number2) 
        {
            this.Number = Number2;
        }
        
        public override string ToString()
        {
            return "Item " + Number.ToString();
        }
    }
}
