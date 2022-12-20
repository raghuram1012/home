<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page2.aspx.cs" Inherits="home.page2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="2) Web forms are inherited from which class"></asp:Label>
<br />
<br />
<asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem>Master class</asp:ListItem>
    <asp:ListItem>Frame class</asp:ListItem>
    <asp:ListItem>Page class</asp:ListItem>
    <asp:ListItem>Browse class</asp:ListItem>
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
