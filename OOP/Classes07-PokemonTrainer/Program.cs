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

            var dictionary = new Dictionary<string, List<Pokemon>>();

            while (true)
            {
                var inputData = Console.ReadLine()
                    .Split()
                    .ToArray();

                if (inputData[0] == "Tournament")
                {
                    break;
                }


                string trainerName = inputData[0];
                string pokemonName = inputData[1];
                string pokemonElem = inputData[2];
                int pokemonHealth = int.Parse(inputData[3]);

                var pokemon = new Pokemon(pokemonName, pokemonElem, pokemonHealth);

                if (!dictionary.ContainsKey(trainerName))
                {
                    dictionary.Add(trainerName, new List<Pokemon>());
                }

                dictionary[trainerName].Add(pokemon);




            }



            while (true)
            {
                var tournamentData = Console.ReadLine();

                if (tournamentData == "End")
                {
                    break;
                }
                else if (tournamentData == "Fire")
                {

                }
                else if (tournamentData == "Water")
                {

                }
                else if (tournamentData == "Electricity")
                {

                }

            }

        }
    }
}
