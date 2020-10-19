using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparatorsTasks04
{
    public class Person<T> : IComparable<T>
    {

        public string Name { get; set; }
        public int Age { get; set; }
        public string Town { get; set; }

        public int CompareTo(T secondItem)
        {
            
        }
    }
}
