using System;
using System.Collections.Generic;
using System.Dynamic;
using System.IO;
using System.Linq;
using System.Text;

namespace DefiningClasses
{
    public class StartUp
    {
        static void Main(string[] args)
        {

            int inputCount = int.Parse(Console.ReadLine());

            Family family = new Family();

            for (int i = 0; i < inputCount; i++)
            {
                string[] what = Console.ReadLine().Split().ToArray();

                Person person = new Person(what[0], int.Parse(what[1]));

                family.AddMember(person);
            }

            //   Console.WriteLine(family.GetOldestMember());


            HashSet<Person> hmmm = family.GetAllPeopleOver30();

            Console.WriteLine(string.Join(Environment.NewLine,hmmm));


        }
    }
}
