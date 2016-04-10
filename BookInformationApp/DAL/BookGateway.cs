using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookInformationApp.Models;

namespace BookInformationApp.DAL
{
    public class BookGateway
    {
        string connectionString = @"Server = .\SQLEXPRESS; Database = BookInformation_DB; Integrated Security = true;";

        public int Insert(Book aBook)
        {

            SqlConnection connection = new SqlConnection(connectionString);
            string query = "INSERT INTO BookList VALUES('" + aBook.Name + "', '" + aBook.Isbn + "', '" + aBook.Author + "')";
            
            connection.Open();

            SqlCommand aCommand = new SqlCommand(query, connection);

            int rowsAffected = aCommand.ExecuteNonQuery();
            connection.Close();

            return rowsAffected;
        }

        public bool IsIsbnNoExists(int isbn)
        {
            bool isIsbnNoExists = false;
            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM BookList WHERE ISBN = '" + isbn + "'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            if (reader.Read())
            {
                isIsbnNoExists = true;
            }

            return isIsbnNoExists;
        }

        public List<Book> GetAllBooks()
        {
            List<Book> books = new List<Book>();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM BookList";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {

                int isbn = Convert.ToInt32(reader["ISBN"].ToString());
                string name = reader["Name"].ToString();
                string author = reader["Author"].ToString();

                Book book = new Book(isbn, name, author);
                books.Add(book);
            }

            connection.Close();
            return books;
        }

        public List<Book> GetAllSearchResult(string searchText)
        {
            List<Book> books = new List<Book>();

            SqlConnection connection = new SqlConnection(connectionString);

            string query = "SELECT * FROM BookList WHERE Name LIKE '" + searchText + "%'";

            SqlCommand command = new SqlCommand(query, connection);

            connection.Open();

            SqlDataReader reader = command.ExecuteReader();

            while (reader.Read())
            {
                int isbn = Convert.ToInt32(reader["ISBN"].ToString());
                string name = reader["Name"].ToString();
                string author = reader["Author"].ToString();

                Book book = new Book(isbn, name, author);
                books.Add(book);
            }

            connection.Close();
            return books;
        }

    }
}
