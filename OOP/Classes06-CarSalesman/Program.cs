using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Classes06_CarSalesman
{
    class Program
    {
        static void Main(string[] args)
        {

            var listOfCars = new List<Car>();
            var hashEngines = new HashSet<Engine>();


            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {
                var inputEng = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                Engine engine = null;

                string model = inputEng[0];
                int power = int.Parse(inputEng[1]);

                if (inputEng.Length == 4)
                {
                    int displacement = int.Parse(inputEng[2]);
                    string efficiency = inputEng[3];

                    engine = new Engine(model, power, displacement, efficiency);
                }
                else if (inputEng.Length == 2)
                {
                    engine = new Engine(model, power);
                }
                else if (inputEng.Length == 3)
                {
                    int displacement;

                    bool isItDisplacement = int.TryParse(inputEng[2], out displacement);

                    // We try to parse as INT to see if it is the right varuable, if it doesnt work, it is the other one

                    if (isItDisplacement)
                    {
                        engine = new Engine(model, power, displacement);
                    }
                    else
                    {
                        engine = new Engine(model, power, inputEng[2]);
                    }

                }

                hashEngines.Add(engine);
            }

            int m = int.Parse(Console.ReadLine());

            for (int i = 0; i < m; i++)
            {
                var inputCars = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToArray();


                Car car = null;

                string model = inputCars[0];
                Engine engine = hashEngines.First(e => e.Model == inputCars[1]);

                if (inputCars.Length == 4)
                {
                    int weight = int.Parse(inputCars[2]);
                    string color = inputCars[3];

                    car = new Car(model, engine, weight, color);
                }
                else if (inputCars.Length == 2)
                {
                    car = new Car(model, engine);
                }
                else if (inputCars.Length == 3)
                {
                    int weight;

                    bool isItWeight = int.TryParse(inputCars[2], out weight);

                    // We try to parse as INT to see if it is the right varuable, if it doesnt work, it is the other one

                    if (isItWeight)
                    {
                        car = new Car(model, engine, weight);
                    }
                    else
                    {
                        car = new Car(model, engine, inputCars[2]);
                    }

                }

                listOfCars.Add(car);

            }

            foreach (var item in listOfCars)
            {
                Console.WriteLine(item);
            }




        }
    }
}
