<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Student.aspx.cs" Inherits="WebApplication35.Student" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        .auto-style1 {
            width: 100%;
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
   
    <table class="auto-style1">
        <tr>
            <td colspan="3"><h1>Students Portal</h1></td>
        </tr>
        <tr>
            <td>Enter the User Name of the Student to know the Student Details:</td>
            <td>
                <asp:TextBox ID="txtId" runat="server"></asp:TextBox>
            </td>
            <td>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtId" ErrorMessage="Please Enter username to get Details" ForeColor="Red"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr>
            <td>
                
                &nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Get Details" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                
                <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
                
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                
                <asp:GridView ID="dgvStudents" runat="server" EnableViewState="False">
                </asp:GridView>
                
            </td>
            <td>
                &nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
