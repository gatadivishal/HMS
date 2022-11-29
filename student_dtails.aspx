<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="student_dtails.aspx.cs" Inherits="student_dtails" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">
<div>

    <asp:Label ID="u1" runat="server" Text="Label"></asp:Label></div>
 <center>
        &nbsp;</center>
    <center>
    
        <asp:GridView ID="GridView1" runat="server"></asp:GridView>
    
    </center>
    <center>
        <asp:LinkButton ID="LinkButton1" runat="server" OnClick="LinkButton1_Click">Edit</asp:LinkButton>
    </center>


</asp:Content>

