using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Book
    {
        public string? ISBN { get; set; }
        public string? Title { get; set; }
        public string[]? Author { get; set; }
        public DateTime YearPublished { get; set; }
        public decimal Price { get; set; }
        public Book(string? iSBN, string? title, string[]? author, DateTime yearPublished, decimal price)
        {
            ISBN = iSBN;
            Title = title;
            Author = author;
            YearPublished = yearPublished;
            Price = price;
        }

        public override string ToString()
        {
            return $"ID : {ISBN} , Title : {Title}\n" +
                   $"The Authors : {string.Join(", ", Author ?? Array.Empty<string>())}\n" +
                   $"The YearPublished : {YearPublished.Month}/{YearPublished.Year}"+
                   $"The price is : {Price:C}";

        }
    }

    internal class BookFunctions 
    {
        public static string GetTitle(Book k)
        {
            return k.Title ?? string.Empty;
        }
        public static string GetAuthors (Book k)
        {
            return string.Join(", " , k.Author ?? Array.Empty<string>());
        }

        public static decimal GetPrice (Book k)
        {
            return k.Price;
        }
    }
    internal class LibraryEngine
    {
//        public delegate TResult BookDelegate<out TResult>(Book b);
        //public static void ProcessBooks<T>(List<Book> BList , BookDelegate<T> bookDelegate)
        //{
        //    foreach (var book in BList)
        //    {
        //        var result = bookDelegate(book);
        //        Console.WriteLine(result);
        //    }
        //}
        public static void ProcessBooks<T>(List<Book> BList, Func<Book , T> bookDelegate)
        {
            foreach (var book in BList)
            {
                var result = bookDelegate(book);
                Console.WriteLine(result);
            }
        }
    }
}
