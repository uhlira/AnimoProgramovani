using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexExample1
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();

            List<Car> Cars = new List<Car>()
            {
                car, 

                new Car(){ Color = Color.AliceBlue,
                    DoorsCount = 5,
                    LicensePlate = "4E22381",
                    PassangersCount = 5,
                    Vendor = "Škoda" , 
                    Engine = EngineType.Electro },

                new Car(){ Color = Color.Black,
                    DoorsCount = 4,
                    LicensePlate = "4E79514",
                    PassangersCount = 4,
                    Vendor = "Mazda" },

                new Car(){ Color = Color.BlueViolet,
                    DoorsCount = 3,
                    LicensePlate = "8A21257",
                    PassangersCount = 2,
                    Vendor = "BMW" },

                new Car(){ Color = Color.Black,
                    DoorsCount = 5,
                    LicensePlate = "5B12471",
                    PassangersCount = 5,
                    Vendor = "Škoda" },

                new Car(){ Color = Color.AliceBlue,
                    DoorsCount = 4,
                    LicensePlate = "4T22381",
                    PassangersCount = 4,
                    Vendor = "Renault" }
            };

            Cars.Add(car);

            string JSON = JsonConvert.SerializeObject(Cars, Formatting.Indented);

            try
            {
                File.WriteAllText("cars.json", JSON);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                List<Car> Cars2 = JsonConvert.DeserializeObject<List<Car>>(File.ReadAllText("cars.json"));
                foreach (Car c in Cars2) { Console.WriteLine(c.ToString()); }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            Console.ReadKey();
        }
    }

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
