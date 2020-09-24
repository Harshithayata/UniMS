<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Fee.aspx.cs" Inherits="WebApplication35.Fee" %>
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
            <td colspan="3"><h1>Fee Payment</h1></td>
        </tr>
        <tr>
            <td>Enter your Student Id:</td>
            <td>
                <asp:TextBox ID="txtId" runat="server" OnTextChanged="TextBox1_TextChanged"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Enter User Name:</td>
            <td>
                <asp:TextBox ID="txtuname" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Enter Father Name:</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Fee Amount to be paid:</td>
            <td>
                <asp:TextBox ID="txtfee" runat="server"></asp:TextBox>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>Mode of Payment:</td>
            <td>
                <asp:DropDownList ID="ddlPayment" runat="server">
                    <asp:ListItem>Cash Payment</asp:ListItem>
                    <asp:ListItem>Telegraphic or mail</asp:ListItem>
                    <asp:ListItem>Money Order</asp:ListItem>
                    <asp:ListItem>Bill of Exchange</asp:ListItem>
                    <asp:ListItem>Primissory Note</asp:ListItem>
                    <asp:ListItem>Bank Draft</asp:ListItem>
                </asp:DropDownList>
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>&nbsp;</td>
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Pay" />
            </td>
            <td>&nbsp;</td>
        </tr>
        <tr>
            <td>
                <asp:Label ID="lblMsg" runat="server" Text="Label"></asp:Label>
            </td>
            <td>&nbsp;</td>
            <td>&nbsp;</td>
        </tr>
    </table>
</asp:Content>
