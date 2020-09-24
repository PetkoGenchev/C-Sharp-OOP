﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Classes07_PokemonTrainer
{
    public class Pokemon
    {
        public string Name { get; set; }
        public string Element { get; set; }
        public int Health { get; set; }
        public Trainer trainerName { get; set; }


        public Pokemon(string name, string element, int health)
        {
            this.Name = name;
            this.Element = element;
            this.Health = health;
        }

        public Pokemon(string name, string element, int health, Trainer trainer)
            :this(name,element,health)
        {
            this.trainerName = trainer;
        }
    }
}