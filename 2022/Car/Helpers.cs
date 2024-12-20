using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public static class Helpers
    {
        public static string Serialize(object obj) 
        {
            return "";
        }

        public static Car Deserialize(string json)
        {
            return new Car();
        }

        public static bool Save(Car car) { return false; }
        public static Car Load() { return new Car(); }
    }
}
