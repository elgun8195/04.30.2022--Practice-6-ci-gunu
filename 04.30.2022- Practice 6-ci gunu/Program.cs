using _04._30._2022__Practice_6_ci_gunu.Models;
using System;

namespace _04._30._2022__Practice_6_ci_gunu
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book("Programming");
            Console.WriteLine(book.Code);
        }
    }
}
