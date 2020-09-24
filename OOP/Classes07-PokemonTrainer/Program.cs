using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;
using System.Globalization;

namespace Classes07_PokemonTrainer
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                var inputData = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (inputData[0] == "Tournament")
                {
                    break;
                }


                var trName = inputData[0];
                var pokeName = inputData[1];
                var pokeElem = inputData[2];
                var pokeHealth = int.Parse(inputData[3]);

            }

        }
    }
}
