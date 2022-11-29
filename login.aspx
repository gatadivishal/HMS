<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="login.aspx.cs" Inherits="login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">

    <center>
    <table border="2">
    
        <tr>
        
            <td>
                <asp:Label ID="lblusername" runat="server" Text="USERNAME"></asp:Label>
            </td>
            <td>
                <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
            </td>
        </tr>
     <tr>
        
            <td>
                <asp:Label ID="lblpassword" runat="server" Text="PASSWORD"></asp:Label> 
            </td>
            <td>
                <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr>
        <td colspan="2">
            <asp:Button ID="btnlogin" runat="server" Text="Login" 
                onclick="btnlogin_Click" />
        </td>
        </tr>
    
    </table>
</center>
</asp:Content>

