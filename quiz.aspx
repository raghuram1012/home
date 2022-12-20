<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="quiz.aspx.cs" Inherits="home.quiz" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="1) .What is MVC?"></asp:Label>
<br />
<br />
<asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem>Framework</asp:ListItem>
    <asp:ListItem>WebApplication</asp:ListItem>
    <asp:ListItem>Software</asp:ListItem>
    <asp:ListItem>Browser</asp:ListItem>
</asp:RadioButtonList>
<br />&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
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
