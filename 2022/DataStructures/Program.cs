using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructures
{
    class Program
    {
        static void Main(string[] args)
        {

        }

        struct Car
        {
            string SPZ;
            DateTime Arrival;
            MotorType MotorType;
        }

        enum MotorType 
        {
            Diesel, 
            Benzin, 
            Electro
        }
    }
}
