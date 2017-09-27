<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ContactForm.Contact" %>

<!DOCTYPE html>

<html>
<head runat="server">
    <title>Главная</title>
    
    <!-- Compiled and minified CSS -->
    <link rel="stylesheet" href="~/css/materialize.css" />
    <link rel="stylesheet" href="~/css/style.css" />
    
    <!-- Import jQuery -->
    <script type="text/javascript" src="https://code.jquery.com/jquery-3.2.1.min.js"></script>
    <!-- Compiled and minified JavaScript -->
    <script src="~/js/materialize.min.js"></script>
          
</head>
<body>
    <nav>
        <div class="nav-wrapper">
            <a href="#" class="brand-logo">Лого</a>
            <ul id="nav-mobile" class="right hide-on-med-and-down">
                <li><a href="#">Пункт 1</a></li>
                <li><a href="#">Пункт 2</a></li>
                <li><a href="#">Пункт 3</a></li>
            </ul>
        </div>
    </nav>
    <form id="form1" runat="server">
        <div class="container">
            <div class="row">
                <main>
                    <center>
                        <div class="container">
                            <div  class="z-depth-3 y-depth-3 x-depth-3 grey black-text lighten-4 row" style="display: inline-block; padding: 32px 48px 0px 48px; border: 1px; margin-top: 0;">    
                                <div class="section"><i class="mdi-alert-error red-text"></i></div>
                                <h3>Авторизация</h3>
                                <div class="row">
                                    <div class="input-field col s12">
                                        <asp:Label runat="server" style="float: left; font-weight: bold">Логин</asp:Label>
                                        <asp:TextBox runat="server" ID="loginTextBox" ClientIDMode="Static"></asp:TextBox>
                                    </div>
                                </div>
                                <div class="row">
                                    <div class="input-field col m12">
                                        <asp:Label runat="server" style="float: left; font-weight: bold">Пароль</asp:Label>
                                        <asp:TextBox runat="server" ID="passwordTextBox" ClientIDMode="Static" TextMode="Password"></asp:TextBox>
                                    </div>
                                    <label style="float: right;">
                                        <a><b style="color: #F5F5F5;">Forgot Password?</b></a>
                                    </label>
                                </div>
                                <br/>
                                <center>
                                    <div class="row">
                                        <asp:Button runat="server" Text="Войти" ID="loginButton" class="btn waves-effect waves-light" />
                                    </div>
                                </center>
     
                            </div>
                            <p align="center">© 2017 Лабораторная работа №1 | Киселева Л., Стабровский О.</p>
                        </div>
                    </center>
                </main>
            </div>
        </div>
    </form>
</body>
</html>
