using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Car
{
    public class Car
    {
        public string Vendor { get; set; } = "Škoda";
        public string LicensePlate { get; set; } = "5AC1234";
        public int DoorsCount { get; set; } = 5;
        public int PassangersCount { get; set; } = 5;
        public Color Color { get; set; } = Color.Teal;
        public EngineType Engine { get; set; } = EngineType.Benzin;
        public bool IsInitialized() => Vendor != String.Empty;

        public override string ToString()
        {
            return $"{Vendor} {LicensePlate} {Color} {Engine}";
        }
    }

    public enum EngineType
    {
        Diesel = 5,
        Benzin = 15,
        Electro = 25
    }
}
