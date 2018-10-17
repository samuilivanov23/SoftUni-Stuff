using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Libraryu
{
    public class LibraryIterator : IEnumerator<Book>
    {
        private IReadOnlyList<Book> books;

        private int index;

        public LibraryIterator(IReadOnlyList<Book> books)
        {
            this.books = books;
            Reset();
        }

        public Book Current => books[index];

        object IEnumerator.Current => Current;

        public void Dispose()
        {}

        public bool MoveNext()
        {
            index++;
            return index < this.books.Count;
        }

        public void Reset()
        {
            this.index = -1;
        }
    }
}
