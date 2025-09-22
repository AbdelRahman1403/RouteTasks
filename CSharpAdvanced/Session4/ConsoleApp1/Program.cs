using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp1
{
    
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Question 1

            //Book b1 = new Book("978-0-13-110362-7", "The C Programming Language", new string[] { "Brian W. Kernighan", "Dennis M. Ritchie" }, new DateTime(1988, 3, 22), 65.99m);

            //Console.WriteLine(b1);
            //Console.WriteLine(BookFunctions.GetPrice(b1));
            //Console.WriteLine(BookFunctions.GetTitle(b1));
            //Console.WriteLine(BookFunctions.GetAuthors(b1));
            #endregion

            Book b1 = new Book("978-0-13-110362-7", "The C Programming Language", new string[] { "Brian W. Kernighan", "Dennis M. Ritchie" }, new DateTime(1988, 3, 22), 65.99m);
            Book b2 = new Book("978-0-201-83595-3", "Introduction to Algorithms", new string[] { "Thomas H. Cormen", "Charles E. Leiserson", "Ronald L. Rivest", "Clifford Stein" }, new DateTime(2009, 7, 31), 89.99m);
            Book b3 = new Book("978-0-596-52068-7", "Learning Python", new string[] { "Mark Lutz" }, new DateTime(2013, 6, 12), 54.99m);
            List<Book> Books = new List<Book> { b1, b2, b3 };
            //Build in delegate
            LibraryEngine.ProcessBooks(Books , BookFunctions.GetPrice);
            //Using Anonymous Method
            LibraryEngine.ProcessBooks(Books, delegate (Book b) { return b.ISBN; });

            //Using Lambda Expression
            LibraryEngine.ProcessBooks(Books,(Book b) => b.YearPublished.Year);
        }
    }
}
