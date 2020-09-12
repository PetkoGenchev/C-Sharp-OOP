using System;
using System.Collections.Generic;

namespace CustomRandomList
{
    public class RandomList : List<string>
    {
        private Random random = new Random();

        public string RemoveRandomElement()
        {
            int element = random.Next(0, this.Count);
            string what = this[element];
            this.RemoveAt(element);
            return what;
        }
    }
}
