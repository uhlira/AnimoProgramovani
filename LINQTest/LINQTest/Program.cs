using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQTest
{
    public class Car 
    {
        public Color color = Color.White;
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Car> cars = new List<Car>
            {
                new Car() { color = Color.Black },
                new Car() { color = Color.Blue },
                new Car() { color = Color.Red },
                new Car() { color = Color.Blue },
                new Car() { color = Color.Red }
            };

            int result = cars.RemoveAll(x => x.color == Color.Red);

            Console.WriteLine(result);

            string json = Newtonsoft.Json.JsonConvert.SerializeObject(cars);
            cars = Newtonsoft.Json.JsonConvert.DeserializeObject<List<Car>>(json);

            Console.ReadLine();
        }
    }
}
