using System;
using System.Linq;

namespace IteratorsAndComparatorsTasks03
{
    class Program
    {
        static void Main(string[] args)
        {

            var inputArray = Console.ReadLine()
                .Split(new char[] { ' ', ',' },StringSplitOptions.RemoveEmptyEntries )
                .Select(int.Parse)
                .ToArray();

            Lake lake = new Lake(inputArray);

        }
    }
}
