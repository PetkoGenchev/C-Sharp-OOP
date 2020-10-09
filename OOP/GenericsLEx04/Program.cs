using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsLEx04
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            var listOfStrings = new List<double>();

            for (int i = 0; i < n; i++)
            {
                var inputToList = double.Parse(Console.ReadLine());
                listOfStrings.Add(inputToList);

            }

            var itemToCompare = double.Parse(Console.ReadLine());

            var box = new Box<double>(listOfStrings);

            Console.WriteLine(box.BiggerElements(listOfStrings,itemToCompare));

        }
    }
}
