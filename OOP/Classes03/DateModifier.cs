using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;

namespace Classes03
{
    class DateModifier
    {
        static void Main(string[] args)
        {

            var input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            var input2 = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            double resultingStuff = RandomTesting.CalculateDays(input, input2);

            Console.WriteLine(resultingStuff);


        }


    }
}