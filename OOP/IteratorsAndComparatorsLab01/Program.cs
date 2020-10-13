using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace IteratorsAndComparators
{
    class Program
    {
        static void Main(string[] args)
        {
            Book bookOne = new Book("Animal Farm", 2003, "George Orwell");
            Book bookTwo = new Book("The Documents in the Case", 2002, "Dorothy Sayers", "Robert Eustace");
            Book bookThree = new Book("The Documents in the Case", 1930);

            Library libraryOne = new Library();
            Library libraryTwo = new Library();
            libraryTwo.Add(bookOne);
            libraryTwo.Add(bookTwo);
            libraryTwo.Add(bookThree);

            foreach (var book in libraryTwo)
            {
                Console.WriteLine(book);
            }

        }
    }
}
