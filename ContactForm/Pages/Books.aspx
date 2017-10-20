<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="ContactForm.Pages.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center">
        <h1> Данные из таблицы "Книги"</h1>
        <asp:GridView runat="server" ID="BookGridView" BackColor="White"  AllowPaging="True">          
        </asp:GridView>
    </div>
</asp:Content>
