using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;

namespace Stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = ParseArray( ' ', ',');

            int rows = array[0];
            int columns = array[1];

            int[,] matrix = new int[rows, columns];

            for (int row = 0; row < rows; row++)
            {
                int[] currentRow = ParseArray(' ');

                for (int col = 0; col < columns; col++)
                {
                    matrix[row, col] = currentRow[col];

                }
            }


        }

        static int[] ParseArray(params char[] splitSymbols)

            => Console.ReadLine()
                .Split(splitSymbols, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

    }
}
