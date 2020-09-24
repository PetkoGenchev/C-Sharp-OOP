using System;
using System.Collections.Generic;
using System.Text;

namespace Classes07_PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public Pokemon[] pokemon { get; set; }


        public Trainer(string name,int numberOfBadge, Pokemon[] pokemons)
        {
            this.Name = name;
            this.NumberOfBadges = numberOfBadge;
            this.pokemon = pokemons;

        }

    }
}
