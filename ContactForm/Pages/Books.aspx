﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Menu.Master" AutoEventWireup="true" CodeBehind="Books.aspx.cs" Inherits="ContactForm.Pages.Books" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div align="center">
        <h1>Данные из таблицы "Книги"</h1>
        <asp:GridView runat="server" ID="BookGridView"  AllowPaging="True" CellPadding="4" ForeColor="#333333" GridLines="None"
            AutoGenerateDeleteButton="True" AutoGenerateEditButton="True">
            <AlternatingRowStyle BackColor="White" ForeColor="#284775" />
            <EditRowStyle BackColor="#999999" />
            <FooterStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <HeaderStyle BackColor="#5D7B9D" Font-Bold="True" ForeColor="White" />
            <PagerStyle BackColor="#284775" ForeColor="White" HorizontalAlign="Center" />
            <RowStyle BackColor="#F7F6F3" ForeColor="#333333" />
            <SelectedRowStyle BackColor="#E2DED6" Font-Bold="True" ForeColor="#333333" />
            <SortedAscendingCellStyle BackColor="#E9E7E2" />
            <SortedAscendingHeaderStyle BackColor="#506C8C" />
            <SortedDescendingCellStyle BackColor="#FFFDF8" />
            <SortedDescendingHeaderStyle BackColor="#6F8DAE" />
        </asp:GridView>
        <h3>Добавить новую книгу</h3>
        <table>
            <tr>
                <th>Название</th>
                <th>Автор</th>
                <th>Год издания</th>
                <th>Издательство</th>
                <th></th>
            </tr>
            <tr>
                <td><asp:TextBox runat="server" ID="NameTextBox"></asp:TextBox></td>
                <td><asp:TextBox runat="server" ID="AuthorTextBox"></asp:TextBox></td>
                <td><asp:TextBox runat="server" ID="YearTextBox" TextMode="Number"></asp:TextBox></td>
                <td><asp:TextBox runat="server" ID="PublishHouseTextBox"></asp:TextBox></td>
                <td><asp:Button runat="server" ID="AddBookButton" Text="Добавить"/></td>
            </tr>
        </table>
    </div>
</asp:Content>
