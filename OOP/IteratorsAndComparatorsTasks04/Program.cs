using System;
using System.Collections.Generic;
using System.Linq;

namespace IteratorsAndComparatorsTasks04
{
    class Program
    {
        static void Main(string[] args)
        {

            var persons = new List<Person>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "END")
                {
                    break;
                }

                var arrayOfInput = input
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                var newData = new Person(arrayOfInput[0], int.Parse(arrayOfInput[1]), arrayOfInput[2]);
                persons.Add(newData);

            }

            int elementIndex = int.Parse(Console.ReadLine());

            Person persontoCompare = persons[elementIndex - 1];

            int matches = 0;

            foreach (var item in persons)
            {
                if (persontoCompare.CompareTo(item) == 0)
                {
                    matches++;
                }
            }

            if (matches <= 1)
            {
                Console.WriteLine("No matches");
            }
            else
            {
                int noMatches = persons.Count - matches;
                Console.WriteLine($"{matches} {noMatches} {persons.Count}");
            }

        }
    }
}
