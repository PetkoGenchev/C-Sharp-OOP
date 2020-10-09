using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;


namespace GenericsLEx05
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstInput = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            if (firstInput.Count > 4)
            {
                firstInput[3] = $"{firstInput[3]} {firstInput[4]}";
                firstInput.RemoveAt(4);
            }

            firstInput[0] = $"{firstInput[0]} {firstInput[1]}";
            firstInput.RemoveAt(1);

            var tupleOne = new Tuple<string, string, string>(firstInput[0], firstInput[1], firstInput[2]);

            var secondInput = Console.ReadLine().Split().ToArray();

            bool isHeDrunk = true;
            if (secondInput[2] == "not")
            {
                isHeDrunk = false;
            }

            var tupleTwo = new Tuple<string, int,bool>(secondInput[0], int.Parse(secondInput[1]),isHeDrunk);


            var thirdInput = Console.ReadLine().Split().ToArray();

            var tupleThree = new Tuple<string, double,string>(thirdInput[0], double.Parse(thirdInput[1],CultureInfo.InvariantCulture),thirdInput[2]); ;

            Console.WriteLine(tupleOne);
            Console.WriteLine(tupleTwo);
            Console.WriteLine(tupleThree);
        
        
        }
    }
}
