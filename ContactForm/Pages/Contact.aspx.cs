using System;
using System.Web.UI;

namespace ContactForm.Pages
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            loginButton.Click += OnLoginButtonClick;
        }

        void OnLoginButtonClick(object sender, EventArgs e)
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;

            if (string.IsNullOrEmpty(login) || string.IsNullOrEmpty(password)) { return; }

            Session["login"] = login;
            Session["password"] = password;
            Response.Redirect("ResultPage.aspx");
        }
    }
}