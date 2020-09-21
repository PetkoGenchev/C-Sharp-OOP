using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Classes04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var listOfCars = new List<Car>();

            for (int i = 0; i < n; i++)
            {
                var firstInput = Console
                    .ReadLine()
                    .Split()
                    .ToArray();

                var carmodel = firstInput[0];
                var carFuel = double.Parse(firstInput[1],CultureInfo.InvariantCulture);
                var carConsumption = double.Parse(firstInput[2],CultureInfo.InvariantCulture);

                listOfCars.Add(new Car(carmodel, carFuel, carConsumption));
            }

            while (true)
            {


                var commands = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (commands[0] == "End" )
                {
                    break;
                }

                var modelToUse = commands[1];
                var kilometeresToUse = int.Parse(commands[2]);


                foreach (var item in listOfCars.Where(x => x.Model == modelToUse))
                {
                    item.What(kilometeresToUse);
                }

            }


                Console.WriteLine(string.Join(Environment.NewLine, listOfCars));



        }
    }
}
