<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.master" AutoEventWireup="true" CodeFile="edit_student_details.aspx.cs" Inherits="edit_student_details" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" Runat="Server">


 <center>
        <table border="2">
            <tr>
                <td>
                    <asp:Label ID="lblregno" runat="server" Text="Reg. No"></asp:Label>
                </td>
                <td style="width: 160px">
                    <asp:TextBox ID="txtregno" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtregno"
                        ErrorMessage="klfnfklndgnp"></asp:RequiredFieldValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblname" runat="server" Text="Name"></asp:Label>
                </td>
                <td style="width: 160px">
                    <asp:TextBox ID="txtname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbllastname" runat="server" Text="Lastname"></asp:Label>
                </td>
                <td style="width: 160px">
                    <asp:TextBox ID="txtlastname" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblusername" runat="server" Text="User Name"></asp:Label>
                </td>
                <td style="width: 160px">
                    <asp:TextBox ID="txtusername" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblpassword" runat="server" Text="Password"></asp:Label>
                </td>
                <td style="width: 160px">
                    <asp:TextBox ID="txtpassword" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblcategory" runat="server" Text="Category"></asp:Label>
                </td>
                <td style="width: 160px">
                    <asp:TextBox ID="txtcategory" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblclass" runat="server" Text="Class"></asp:Label>
                </td>
                <td style="width: 160px">
                    <asp:TextBox ID="txtclass" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lbljoiningdate" runat="server" Text="Joining Date"></asp:Label>
                </td>
                <td style="width: 160px">
                    <asp:TextBox ID="txtjoiningdate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblbirthdate" runat="server" Text="Birth Date"></asp:Label>
                </td>
                <td style="width: 160px">
                    <asp:TextBox ID="txtbirthdate" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
            <td colspan="2">
            <asp:Calendar ID="c1" runat="Server" OnSelectionChanged="c1_SelectionChanged"></asp:Calendar>
            
            </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblcontactno" runat="server" Text="Contact No"></asp:Label>
                </td>
                <td style="width: 160px">
                    <asp:TextBox ID="txtcontactno" runat="server"></asp:TextBox>
                </td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblemail" runat="server" Text="Email Id"></asp:Label>
                </td>
                <td style="width: 160px">
                    <asp:TextBox ID="txtemailid" runat="server"></asp:TextBox>
                </td>
                <td>
                    <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtemailid"
                        ErrorMessage="RegularExpressionValidator" ValidationExpression="\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"></asp:RegularExpressionValidator></td>
            </tr>
            <tr>
                <td>
                    <asp:Label ID="lblphoto" runat="server" Text="Photo"></asp:Label>
                </td>
                <td style="width: 160px">
                    <asp:Image ID="image1" runat="server" Height="100px" Width="80px" />
                </td>
            </tr>
            <tr>
                <td colspan = "2">
                    <asp:FileUpload ID="FileUpload1" runat="server" />
                </td>
            </tr>
            <tr>
                <td colspan="2">
                    <asp:Button ID="btnupdate" runat="server" Text="UPDATE" OnClick="btnupdate_Click1" />
                </td>
            </tr>
                      
            
        </table>
    </center>
</asp:Content>

