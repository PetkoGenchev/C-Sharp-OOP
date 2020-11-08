using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace xExamAdvanced01
{
    class Program
    {
        static void Main(string[] args)
        {
            var stackInput = new Stack<int>();
            var queueInput = new Queue<int>();

            string queueStringRemaining = null;
            string stackStringRemaining = null;

            int daturaBomb = 0;
            int cherryBomb = 0;
            int smokeDecoyBomb = 0;

            var inputForQueue = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            var inputforStack = Console.ReadLine()
                .Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var item in inputForQueue)
            {
                queueInput.Enqueue(item);
            }

            foreach (var item in inputforStack)
            {
                stackInput.Push(item);
            }

            var maxCount = Math.Min(queueInput.Count, stackInput.Count);


            for (int i = 0; i < maxCount; i++)
            {
                int elementQueue = queueInput.Dequeue();
                int elementStack = stackInput.Pop();

                int firstTotal = elementStack + elementQueue;

                bool isThereASuitableBomb = false;

                while (isThereASuitableBomb == false)
                {
                    if (firstTotal == 120 || firstTotal == 60 || firstTotal == 40)
                    {
                        isThereASuitableBomb = true;

                        if (firstTotal == 120)
                        {
                            smokeDecoyBomb++;
                        }
                        else if (firstTotal == 60)
                        {
                            cherryBomb++;
                        }
                        else
                        {
                            daturaBomb++;
                        }
                    }
                    else
                    {
                        if (firstTotal <= 0)
                        {
                            break;
                        }
                        else
                        {
                            firstTotal -= 5;
                        }
                    }
                }

                if (daturaBomb >= 3 && cherryBomb >= 3 && smokeDecoyBomb >= 3)
                {
                    CheckIfQueueAndStackAreEmpty(stackInput, queueInput, out queueStringRemaining, out stackStringRemaining);

                    Console.WriteLine("Bene! You have successfully filled the bomb pouch!");
                    PrintingEnd(queueStringRemaining, stackStringRemaining, daturaBomb, cherryBomb, smokeDecoyBomb);
                    return;
                }

            }

            CheckIfQueueAndStackAreEmpty(stackInput, queueInput, out queueStringRemaining, out stackStringRemaining);

            Console.WriteLine("You don't have enough materials to fill the bomb pouch.");
            PrintingEnd(queueStringRemaining, stackStringRemaining, daturaBomb, cherryBomb, smokeDecoyBomb);

        }



        private static void CheckIfQueueAndStackAreEmpty(Stack<int> stackInput, Queue<int> queueInput, out string queueStringRemaining, out string stackStringRemaining)
        {
            if (queueInput.Any())
            {
                queueStringRemaining = string.Join(", ", queueInput);
            }
            else
            {
                queueStringRemaining = "empty";
            }

            if (stackInput.Any())
            {
                stackStringRemaining = string.Join(", ", stackInput);
            }
            else
            {
                stackStringRemaining = "empty";
            }
        }



        private static void PrintingEnd(string queueStringRemaining, string stackStringRemaining, int daturaBomb, int cherryBomb, int smokeDecoyBomb)
        {
            Console.WriteLine($"Bomb Effects: {queueStringRemaining}");
            Console.WriteLine($"Bomb Casings: {stackStringRemaining}");
            Console.WriteLine($"Cherry Bombs: {cherryBomb}");
            Console.WriteLine($"Datura Bombs: {daturaBomb}");
            Console.WriteLine($"Smoke Decoy Bombs: {smokeDecoyBomb}");
        }
    }
}
