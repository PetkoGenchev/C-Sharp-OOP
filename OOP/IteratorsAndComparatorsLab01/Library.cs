using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Collections;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        private SortedSet<Book> books;



        public Library()
        {
            this.books = new SortedSet<Book>(new BookComparator());
        }

        public void Add(Book book)
        {
            this.books.Add(book);
        }


        public IEnumerator<Book> GetEnumerator()
        {
            return new BookIterator(this.books.ToList());
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }




        private class BookIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int index;

            public BookIterator(List<Book> books)
            {
                this.Reset();
                this.books = books;
            }


            public Book Current => this.books[this.index];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            => ++this.index < this.books.Count;
            

            public void Reset()
            {
                this.index = -1;
            }


        }


        private class LibraryIterator : IEnumerator<Book>
        {
            private List<Book> books;
            private int currentIndex;

            public LibraryIterator(List<Book> books)
            {
                this.Reset();
                this.books = books;
            }

            public Book Current => this.books[this.currentIndex];

            object IEnumerator.Current => this.Current;

            public void Dispose()
            {
            }

            public bool MoveNext()
            {
                throw new NotImplementedException();
            }

            public void Reset()
            {
                this.currentIndex = -1;
            }
        }





    }


}
