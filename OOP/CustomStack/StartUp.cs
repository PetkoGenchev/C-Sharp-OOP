using System;
using System.Collections.Generic;

namespace CustomStack
{
    class StartUp
    {
        static void Main()
        {
            var stacking = new StackOfStrings();
        }
    }

    public class StackOfStrings : Stack<string>
    {
        public bool IsEmpty()
        {
            return this.Count == 0;
        }

        public void AddRange(IEnumerable<string> values)
        {
            foreach (var value in values)
            {
                this.Push(value);
            }
        }
    }
}
