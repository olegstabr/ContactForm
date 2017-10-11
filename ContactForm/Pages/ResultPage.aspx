<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="ResultPage.aspx.cs" Inherits="ContactForm.Pages.ResultPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <title>Результат</title>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Данные со страницы Contact</h1>
    <div>
        <asp:Label runat="server" ID="resultLabel"></asp:Label>
    </div>
    <hr/>
    <p align="center">Copyright © 2017 Лабораторная работа №1 | Киселева Л., Стабровский О.</p>
</asp:Content>
