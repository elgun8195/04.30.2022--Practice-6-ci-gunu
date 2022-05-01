using _04._30._2022__Practice_6_ci_gunu.Models;
using System;

namespace _04._30._2022__Practice_6_ci_gunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Programming");
            book.AuthorName = "Elgun Qocayerv";
            book.PageCount = 267;
            Console.WriteLine(book.Code);



            Library library = new Library();
            library.AddBook(book);

            library.FindAllBooksByName("Programming");
            library.FindAllBooksByPageCountRange(10, 300);
            library.RemoveAllBooksByName("Programming");
            library.SearchBooks("257");
            library.RemoveBookByCode("PR1");

        }
    }
}
