using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookInformationApp.BLL;
using BookInformationApp.Models;

namespace BookInformationApp.UI
{
    public partial class AddBookUI : System.Web.UI.Page
    {
        BookManager manager = new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void saveButton_Click(object sender, EventArgs e)
        {
            Book aBook = new Book();
            aBook.Isbn = Convert.ToInt32(isbnTextBox.Text);
            aBook.Name = nameTextBox.Text;
            aBook.Author = authorTextBox.Text;

            string message = manager.Save(aBook);
            saveDetailsLabel.Text = message;
        }
    }
}