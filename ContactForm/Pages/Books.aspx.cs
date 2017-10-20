using System;
using System.Data;
using System.Web.UI.WebControls;
using Npgsql;

namespace ContactForm.Pages
{
    public partial class Books : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            BookGridView.RowDataBound +=  OnBookGridViewRowDataBound;
            BookGridView.DataSource = GetBooks();
            BookGridView.DataBind();
        }

        DataTable GetBooks()
        {
            DataTable table = null;
            string connString = "server=localhost;user id=postgres;password=1234;database=POIS";
            string query = "SELECT * FROM BOOK";

            using (NpgsqlConnection connection = new NpgsqlConnection(connString))
            {
                try
                {
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {

                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        table = new DataTable();
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    Response.Write(e);
                }
            }

            return table;
        }

        void OnBookGridViewRowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType != DataControlRowType.Header) { return; }

            var rowCells = e.Row.Cells;
            string header = string.Empty;
            for (int i = 0; i < rowCells.Count; i++)
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
    }
}