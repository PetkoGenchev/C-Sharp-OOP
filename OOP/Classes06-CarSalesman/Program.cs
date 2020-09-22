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
            var hashCars = new HashSet<Engine>();


            int n = int.Parse(Console.ReadLine());



            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine()
                    .Split(' ',StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                
            }

        }
    }
}
