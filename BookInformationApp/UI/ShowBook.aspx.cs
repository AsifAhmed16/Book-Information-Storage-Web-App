using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BookInformationApp.BLL;

namespace BookInformationApp.UI
{
    public partial class ShowBookUI : System.Web.UI.Page
    {
        BookManager manager = new BookManager();
        protected void Page_Load(object sender, EventArgs e)
        {
            bookListGridView.DataSource = manager.GetAllBooks();
            bookListGridView.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            string searchText = nameSearchTextBox.Text;

            bookListGridView.DataSource = manager.GetAllSearchResult(searchText);
            bookListGridView.DataBind();
        }
    }
}