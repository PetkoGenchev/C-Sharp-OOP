using System;

namespace CustomRandomList
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var exitVariable = new RandomList();
            Console.WriteLine(exitVariable.RemoveRandomElement());
        }
    }
}
