using System;
using System.Collections.Generic;
using System.Text;

namespace Classes07_PokemonTrainer
{
    public class Trainer
    {
        public string Name { get; set; }
        public int NumberOfBadges { get; set; }
        public List<Pokemon> pokemon { get; set; }


        public Trainer(string name)
        {
            this.Name = name;
            this.NumberOfBadges = 0;
            this.pokemon = new List<Pokemon>();

        }

        public override string ToString()
        {
            return $"{this.Name} {this.NumberOfBadges} {this.pokemon.Count}";
        }
    }
}
