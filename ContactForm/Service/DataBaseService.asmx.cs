using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Services;
using ContactForm.Entity;
using Npgsql;

namespace ContactForm.Service
{
    /// <summary>
    /// Summary description for DataBaseService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class DataBaseService : System.Web.Services.WebService
    {
        static string CONN_STRING = "server=localhost;user id=postgres;password=1234;database=POIS";

        [WebMethod]
        public string HelloWorld()
        {
            return "Hello World";
        }

        [WebMethod]
        public DataTable GetBooks()
        {
            DataTable table = null;
            string query = "SELECT * FROM BOOK";

            using (NpgsqlConnection connection = new NpgsqlConnection(CONN_STRING))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {

                        NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command);
                        table = new DataTable();
                        adapter.Fill(table);
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }

            return table;
        }

        [WebMethod]
        public void AddBook(BookEntity book)
        {
            string query = $"INSERT INTO BOOK(NAME, AUTHOR, YEAR, PUBLISH_HOUSE) VALUES('{book.Name}', '{book.Author}', {book.Year}, '{book.PublishHouse}')";
            using (NpgsqlConnection connection = new NpgsqlConnection(CONN_STRING))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        [WebMethod]
        public void UpdateBook(BookEntity book)
        {
            string query = $"UPDATE BOOK SET NAME = '{book.Name}', AUTHOR='{book.Author}', YEAR={book.Year}, PUBLISH_HOUSE='{book.PublishHouse}' WHERE ID = {book.ID}";
            using (NpgsqlConnection connection = new NpgsqlConnection(CONN_STRING))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }

        [WebMethod]
        public void DeleteBook(int id)
        {
            string query = $"DELETE FROM BOOK  WHERE ID = {id}";
            using (NpgsqlConnection connection = new NpgsqlConnection(CONN_STRING))
            {
                try
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        command.ExecuteNonQuery();
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine(e);
                }
            }
        }
    }
}
