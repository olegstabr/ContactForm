<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Contact.aspx.cs" Inherits="ContactForm.Contact" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <h1>Регистрация</h1>
            <table>
                <tr>
                    <td>Логин:</td>
                    <td>
                        <asp:TextBox runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td>Логин:</td>
                    <td>
                        <asp:TextBox runat="server"></asp:TextBox>
                    </td>
                </tr>
                <tr>
                    <td colspan="2">
                        <asp:Button runat="server" Text="Регистрация"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
