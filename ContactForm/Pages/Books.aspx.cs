using System;
using System.Data;
using System.Web.UI.WebControls;
using ContactForm.Entity;
using ContactForm.Service;
using Npgsql;

namespace ContactForm.Pages
{
    public partial class Books : System.Web.UI.Page
    {
        readonly DataBaseService dataBaseService = new DataBaseService();

        protected void Page_Load(object sender, EventArgs e)
        {
            AddBookButton.Click += OnAddBookButtonClick;

            BookGridView.RowDataBound +=  OnBookGridViewRowDataBound;
            BookGridView.RowEditing += OnBookGridViewRowEditing;
            BookGridView.RowDeleting += OnBookGridViewRowDeleting;
            BookGridView.RowUpdating += OnBookGridViewRowUpdating;
            BookGridView.RowCancelingEdit += OnBookGridViewRowCancelingEdit;
            BookGridView.DataSource = dataBaseService.GetBooks();
            if (!IsPostBack) { BookGridView.DataBind(); }
        }

        void UpdateData()
        {
            BookGridView.DataSource = dataBaseService.GetBooks();
            BookGridView.DataBind();
        }

        void OnBookGridViewRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType != DataControlRowType.Header) { return; }

            var rowCells = e.Row.Cells;
            var header = string.Empty;
            for (var i = 0; i < rowCells.Count; i++)
            {
                switch (rowCells[i].Text)
                {
                    case "id":
                        header = "№";
                        break;
                    case "name":
                        header = "Навзание";
                        break;
                    case "author":
                        header = "Автор";
                        break;
                    case "year":
                        header = "Год издания";
                        break;
                    case "publish_house":
                        header = "Издательство";
                        break;
                }
                rowCells[i].Text = header;
            }
        }
        
        void OnAddBookButtonClick(object sender, EventArgs e)
        {
            var name = NameTextBox.Text;
            var author = AuthorTextBox.Text;
            var year = Convert.ToInt32(YearTextBox.Text);
            var publishHouse = PublishHouseTextBox.Text;
            var bookEntity = new BookEntity(name, author, year, publishHouse);

            NameTextBox.Text = string.Empty;
            AuthorTextBox.Text = string.Empty;
            YearTextBox.Text = string.Empty;
            PublishHouseTextBox.Text = string.Empty;

            dataBaseService.AddBook(bookEntity);
            UpdateData();
        }

        void OnBookGridViewRowEditing(object sender, GridViewEditEventArgs e)
        {
            BookGridView.EditIndex = e.NewEditIndex;
            UpdateData();
        }

        void OnBookGridViewRowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            var values = e.Values;
            int id = Convert.ToInt32(values["id"]);
            dataBaseService.DeleteBook(id);
            UpdateData();
        }

        void OnBookGridViewRowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            if (BookGridView.Rows.Count <= e.RowIndex) { return; }

            var values = e.NewValues;
            var id = Convert.ToInt32(values["id"]);
            var name = values["name"].ToString();
            var author = values["author"].ToString();
            var year = Convert.ToInt32(values["year"]);
            var publishHouse = values["publish_house"].ToString();
            var bookEntity = new BookEntity(name, author, year, publishHouse) {ID = id};

            dataBaseService.UpdateBook(bookEntity);
            
            BookGridView.EditIndex = -1;
            UpdateData();
        }

        void OnBookGridViewRowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            BookGridView.EditIndex = -1;
        }
    }
}