using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            var useRandom = new RandomList();
            Console.WriteLine(useRandom.ReturnRandomElement());
        }
    }


    public class RandomList : List<string>
    {
        private Random random = new Random();
        public string ReturnRandomElement()
        {
            var remove = random.Next(0, this.Count);
            var removingElement = this[remove];

            var index = random.Next(0, this.Count);
            var element = this[index];
            return element;


        }
    }
}
