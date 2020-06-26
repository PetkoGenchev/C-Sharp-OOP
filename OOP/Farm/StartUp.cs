﻿using System;

namespace Farm
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            Dog dog = new Dog();
            dog.Eat();
            dog.Bark();

            Cat cat = new Cat();
            cat.Eat();
            cat.Meow();

        }
    }

    public class Animal
    {
        public void Eat()
        {
            System.Console.WriteLine("eating...");
        }

    }

    public class Dog : Animal
    {
        public void Bark()
        {
            System.Console.WriteLine("barking...");
        }

    }


    public class Cat : Animal
    {
        public void Meow()
        {
            System.Console.WriteLine("meowing...");
        }

    }
}
