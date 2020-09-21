﻿using System;
using System.Collections.Generic;
using System.Text;

namespace DefiningClasses
{
    public class Person
    {
        private string name;
        private int age;

        public Person()
        {
            this.Name = "No name";
            this.Age = 1;
        }
        public string Name { get => name; set => name = value; }
        public int Age { get => age; set => age = value; }

        public Person(int age)
            : this()
        {
            this.Age = age;
        }

        public Person(string name, int age)
            : this(age)
        {
            this.Name = name;
        }

        public override string ToString()
        {
            return $"{this.Name} - {this.Age}";
        }




    }
}
