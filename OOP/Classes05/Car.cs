using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Classes05
{
    class Car
    {
        public Cargo cargo { get; set; }
        public Tire[] tires { get; set; }

        public Engine engine { get; set; }

        public string model { get; set; }


        public Car(string model, Cargo cargo, Engine engine, Tire[] tires)
        {
            this.model = model;
            this.cargo = cargo;
            this.engine = engine;
            this.tires = tires;
        }




        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var listOfAllElements = new List<Car>();


            for (int i = 0; i < n; i++)
            {
                var inputArray = Console.ReadLine()
                    .Split()
                    .ToArray();

                var model = inputArray[0];
                var engineSpeed = int.Parse(inputArray[1]);
                var enginePower = int.Parse(inputArray[2]);
                var cargoWeight = int.Parse(inputArray[3]);
                var cargoType = inputArray[4];
                var tire1pressure = double.Parse(inputArray[5], CultureInfo.InvariantCulture);
                var tire1age = int.Parse(inputArray[6]);
                var tire2pressure = double.Parse(inputArray[7], CultureInfo.InvariantCulture);
                var tire2age = int.Parse(inputArray[8]);
                var tire3pressure = double.Parse(inputArray[9], CultureInfo.InvariantCulture);
                var tire3age = int.Parse(inputArray[10]);
                var tire4pressure = double.Parse(inputArray[11], CultureInfo.InvariantCulture);
                var tire4age = int.Parse(inputArray[12]);


                var cargos = new Cargo(cargoWeight, cargoType);
                var engines = new Engine(engineSpeed, enginePower);
                var tires = new Tire[4]
                {
                    new Tire(tire1pressure,tire1age),
                    new Tire(tire2pressure,tire2age),
                    new Tire(tire3pressure,tire3age),
                    new Tire(tire4pressure,tire4age)
                };

                var toAdd = new Car(model, cargos, engines, tires);
                listOfAllElements.Add(toAdd);
            }

            var typeToSearch = Console.ReadLine();

            if (typeToSearch == "fragile")
            {
                foreach (var item in listOfAllElements.Where(x => x.cargo.CargoType == "fragile")
                    .Where(y => y.tires.Min(z => z.TirePressure) < 1))
                {
                    Console.WriteLine(item.model);
                }
            }
            else if (typeToSearch == "flamable")
            {
                foreach (var item in listOfAllElements.Where(x => x.cargo.CargoType == "flamable")
                    .Where(y => y.engine.EnginePower > 250))
                {
                    Console.WriteLine(item.model);
                }
            }

        }
    }
}
