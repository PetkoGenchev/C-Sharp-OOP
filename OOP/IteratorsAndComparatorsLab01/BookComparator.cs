using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace IteratorsAndComparators
{
    public class BookComparator : IComparer<Book>
    {
        public int Compare(Book firstBook, Book secondBook)
        {
            int compareTitle = firstBook.Title.CompareTo(secondBook.Title);

            if (compareTitle == 0)
            {
                return secondBook.Year.CompareTo(firstBook.Year);
            }

            return compareTitle;
        }
    }
}
