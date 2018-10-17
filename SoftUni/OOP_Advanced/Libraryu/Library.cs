using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Libraryu
{
    class Library : IEnumerable<Book>
    {
        private List<Book> Books { get; set; }

        public Library(params Book[] books)
        {
            Books = new List<Book>(books);
        }

        public IEnumerator<Book> GetEnumerator()
        {
            return LibraryIterator(Books);
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
