using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;

namespace CarManufacturer
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            var tires = new List<Tire[]>();

            while (true)
            {

                var input = Console.ReadLine().Split().ToArray();

                if (input[0] == "No")
                {
                    break;
                }

                var currTires = new Tire[4]
                {
                    new Tire(int.Parse(input[0]), double.Parse(input[1])),
                    new Tire(int.Parse(input[2]), double.Parse(input[3])),
                    new Tire(int.Parse(input[4]), double.Parse(input[5])),
                    new Tire(int.Parse(input[6]), double.Parse(input[7]))
                };

                tires.Add(currTires);

            }

            var engines = new List<Engine>();

            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();

                if (input[0] == "Engines")
                {
                    break;
                }


                engines.Add(new Engine(int.Parse(input[0]), double.Parse(input[1])));
            }

            var cars = new List<Car>();

            while (true)
            {
                var input = Console.ReadLine().Split().ToArray();

                if (input[0] == "Show")
                {
                    break;
                }

                cars.Add(new Car(
                    input[0],
                    input[1],
                    int.Parse(input[2]),
                    double.Parse(input[3]),
                    double.Parse(input[4]),
                    engines[int.Parse(input[5])],
                    tires[int.Parse(input[6])]
                    ));
            }

            foreach (var item in cars
                .Where(x => x.Year >= 2017)
                .Where(x => x.Engine.HorsePower > 330)
                .Where(x => x.Tire.Sum(y => y.Pressure) >= 9 && x.Tire.Sum(y => y.Pressure) <= 10))
            {

                item.Drive(20);
                Console.WriteLine(item.WhoAmI());
            }

        }
    }

}