using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsLEx03
{
    class StartUp
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            var listOfAllItems = new List<SwapIndex<string>>();

            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                var toBeAdded = new SwapIndex<string>(input);

                listOfAllItems.Add(toBeAdded);
            }

        }
    }
}
