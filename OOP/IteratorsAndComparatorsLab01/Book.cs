using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;
using System.Diagnostics.CodeAnalysis;

namespace IteratorsAndComparators
{
    public class Book : IComparable<Book>
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            this.Title = title;
            this.Year = year;
            this.Authors = authors.ToList();
        }



        public int CompareTo( Book other)
        {
            var compareByYear = this.Year.CompareTo(other.Year);

            if (compareByYear == 0)
            {
                return this.Title.CompareTo(other.Title);
            }
            return compareByYear;
        }


        public override string ToString()
        {
            return $"{this.Title} - {this.Year}";
        }
    }
}
