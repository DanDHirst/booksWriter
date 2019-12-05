using System;
using System.Collections.Generic;
using System.Text;

namespace Saving
{
    class Book
    {
        String name;
        String author;
        int copies;

        public Book (String name, String author, int copies)
        {
            this.name = name;
            this.author = author;
            this.copies = copies;
        }

        public String toString()
        {
            return String.Format("{0}\n{1}\n{2}", name, author, copies);
        }
    }
}
