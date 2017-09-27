using System;
using System.Web;
using System.Web.UI;

namespace ContactForm.Pages
{
    public partial class ResultPage : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var session = HttpContext.Current.Session;
            bool isLogin = !(session["login"] == null || session["password"] == null);

            resultLabel.Text = !isLogin ? "Вы не отправляли информацию со страницы Contanct" : $"Вы ввели логин - {session["login"]} и пароль - {session["password"]}";
        }
    }
}