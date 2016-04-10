using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookInformationApp.DAL;
using BookInformationApp.Models;

namespace BookInformationApp.BLL
{
    public class BookManager
    {
        BookGateway bookGateway = new BookGateway();

        public List<Book> GetAllBooks()
        {
            List<Book> books = bookGateway.GetAllBooks();
            return books;
        }

        public string Save(Book aBook)
        {
            string message = "";

            bool isRegNoExists = bookGateway.IsIsbnNoExists(aBook.Isbn);

            if (isRegNoExists)
            {
                message = "ISBN No already exists!";

            }
            else
            {

                int rowsAffected = bookGateway.Insert(aBook);

                if (rowsAffected > 0)
                {
                    message = "Saved successfully";
                }
                else
                {
                    message = "Sorry! Insertion failed.";
                }
            }

            return message;
        }


        public List<Book> GetAllSearchResult(string searchText)
        {
            List<Book> books = bookGateway.GetAllSearchResult(searchText);
            return books;
        }
    }
}