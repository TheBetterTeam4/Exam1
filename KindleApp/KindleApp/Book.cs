using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KindleApp
{
    public class Book
    {
        public string BookName { get; set; }
        public int LastPage { get; set; }
        public List<Bookmark> BookMarks { get; set; }
        public List<string> BookPages { get; set; }

        public Book(string a, int b, List<Bookmark> c, List<string> d)
        {
            BookName = a;
            LastPage = b;
            BookMarks = c;
            BookPages = d;
        }
    }
}
