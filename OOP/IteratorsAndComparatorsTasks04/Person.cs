using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparatorsTasks04
{
    public class Person : IComparable<Person>
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }



        public Person(string name, int age, string town)
        {
            this.Name = name;
            this.Age = age;
            this.Town = town;
        }
            


        public int CompareTo(Person secondPerson)
        {
            int result = 1;

            if (secondPerson != null)
            {
                result = this.Name.CompareTo(secondPerson.Name);

                if (result == 0)
                {
                    result = this.Age.CompareTo(secondPerson.Age);

                    if (result == 0)
                    {
                        result = this.Town.CompareTo(secondPerson.Town);
                    }
                }
            }
            return result;
        }
    }
}
