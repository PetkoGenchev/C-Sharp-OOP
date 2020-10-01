using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GenericsLEx03
{
    class StartUp
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();

            int n = int.Parse(Console.ReadLine());


            for (int i = 0; i < n; i++)
            {
                var input = Console.ReadLine();

                names.Add(input);

            }

            SwapIndex<string> swapIndex = new SwapIndex<string>(names);

            var indexToSwap = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToArray();

            swapIndex.Swap(names, indexToSwap[0], indexToSwap[1]);
            Console.WriteLine(swapIndex);

        }
    }
}
