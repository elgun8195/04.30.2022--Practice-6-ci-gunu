using System;
using System.Collections.Generic;
using System.Text;

namespace _04._30._2022__Practice_6_ci_gunu.Models
{
    class Book
    {
        private static int _id;
        private string _code;

        public string Name { get; set; }
        public string AuthorName { get; set; }
        public int PageCount { get; set; }
        public string Code
        {
            get
            {
                return _code;
            }
        }

        public Book(string name)
        {
            Name = name;
            
            _id++;
            _code = Name.Substring(0, 2).ToUpper() + _id;
            
        }
    }
}
