using System;
using System.Collections.Generic;
using System.Text;

namespace _04._30._2022__Practice_6_ci_gunu.Models
{
    class Library
    {
        private List<Book> _books;

        public List<Book> FindAllBooksByName(string name)
        {                        
            return _books.FindAll(x => x.Name.Contains(name));            
        }

        public void RemoveAllBooksByName(string name)
        {            
            _books.RemoveAll(e => e.Name.Contains(name));
        }

        public List<Book> SearchBooks(string value)
        {
            List<Book> cbooks = _books.FindAll(e => e.Name.Contains(value) || e.AuthorName.Contains(value) || e.PageCount.ToString().Contains(value));
            return cbooks;
        }

        public List<Book> FindAllBooksByPageCountRange(int min,int max)
        {
            return _books.FindAll(e => e.PageCount >= min && e.PageCount <= max);
        }
        public void RemoveBookByCode(string value)
        {
            Book book = _books.Find(x => x.Code == value);
            if (book!=null)
            {
                _books.Remove(book);
            }
        }


    }
}
