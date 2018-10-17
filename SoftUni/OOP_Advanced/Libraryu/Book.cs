using System;
using System.Collections.Generic;
using System.Text;

namespace Libraryu
{
    public class Book
    {
        public string Title { get; set; }

        public int Year { get; set; }

        public List<string> Authors { get; set; }

        public Book(string title, int year, params string[] authors)
        {
            Authors = new List<string>(authors);
            Title = title;
            Year = year;
        }
    }
}
