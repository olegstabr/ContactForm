<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ContactForm.Pages.Contact" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Авторизация</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
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
</asp:Content>
