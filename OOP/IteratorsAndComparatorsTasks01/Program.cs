using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace IteratorsAndComparatorsTasks01
{
    class Program
    {
        static void Main(string[] args)
        {


            var listOfData = new List<string>();

            var inputArray = Console.ReadLine()
                    .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

            if (inputArray.Length > 1)
            {
                for (int i = 1; i < inputArray.Length; i++)
                {
                    listOfData.Add(inputArray[i]);
                }
            }
            var listIterator = new ListyIterator<string>(listOfData);

            var indexToUse = 0;

            while (true)
            {
                var inputCommand = Console.ReadLine();
                

                if (inputCommand == "END")
                {
                    break;
                }

                if (inputCommand == "Move")
                {
                    Console.WriteLine(listIterator.Move(listOfData, indexToUse + 1));
                    indexToUse++;
                }
                else if (inputCommand == "HasNext")
                {
                    Console.WriteLine(listIterator.HasNext(listOfData, indexToUse));
                }
                else if (inputCommand == "Print")
                {
                    listIterator.Print(listOfData, indexToUse);
                }
            }

        }
    }
}
