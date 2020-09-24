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
        public static void Main(string[] args)
        {

            var dictionary = new Dictionary<string, Trainer>();

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
                    dictionary.Add(trainerName, new Trainer(trainerName));
                }

                dictionary[trainerName].pokemon.Add(pokemon);

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
                    TrainerChecking(dictionary, tournamentData);
                }
                else if (tournamentData == "Water")
                {
                    TrainerChecking(dictionary, tournamentData);
                }
                else if (tournamentData == "Electricity")
                {
                    TrainerChecking(dictionary, tournamentData);
                }

            }


            foreach (Trainer item in dictionary.Values.OrderByDescending( b =>b.NumberOfBadges))
            {
                Console.WriteLine(item);
            }


            static void TrainerChecking(Dictionary<string,Trainer> trainers, string tournamentData)
            {
                foreach (var item in trainers.Values)
                {
                    if (item.pokemon.Any(x => x.Element == tournamentData))
                    {
                        item.NumberOfBadges++;
                    }
                    else
                    {
                        for (int i = 0; i < item.pokemon.Count; i++)
                        {
                            item.pokemon[i].Health -= 10;

                            if (item.pokemon[i].Health <= 0)
                            {
                                item.pokemon.RemoveAt(i);
                                i--;
                            }
                        }
                    }
                }


            }

        }
    }
}
