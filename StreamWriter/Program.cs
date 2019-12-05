using System;
using System.Collections;
using System.IO;

namespace Saving
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList books = new ArrayList();

            books.Add(new Book("The fellowship of the ring", "JRR Tolkein", 5));
            books.Add(new Book("The final empire", "Brandon Sanderson", 2));

            write("books.txt", books);
            Console.WriteLine("Complete");
        }

        public static void write(String filePath, ArrayList items)
        {
            using (StreamWriter w = new StreamWriter(filePath))
            {
                foreach (Book book in items)
                {
                    w.Write(book.toString());
                    w.Write("\n");
                }
            }
        }
    }
}
