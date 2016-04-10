using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BookInformationApp.Models
{
    public class Book
    {
        public Book(int isbn, string name, string author)
        {
            Name = name;
            Isbn = isbn;
            Author = author;
        }

        public Book()
        {
           
        }
        public string Name { get; set; }
        public int Isbn { get; set; }
        public string Author { get; set; }
    }
}