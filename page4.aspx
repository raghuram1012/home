<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page4.aspx.cs" Inherits="home.page4" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="4) Select extension of file in asp.net"></asp:Label>
<br />
<br />
<asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem>.asax</asp:ListItem>
    <asp:ListItem>.aspx</asp:ListItem>
    <asp:ListItem>.asdx</asp:ListItem>
    <asp:ListItem>.asfx</asp:ListItem>
</asp:RadioButtonList>
<br />
<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Back" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Next" />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
</asp:Content>
