using System.Collections.Generic;

namespace IteratorsAndComparators
{
    class Library
    {
        public List<Book> Books { get; set; }

        public Library(params Book[] books)
        {
            this.Books = new List<Book>(books);
        }
    }
}
