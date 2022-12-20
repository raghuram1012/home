<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="page5.aspx.cs" Inherits="home.page5" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Label ID="Label1" runat="server" Text="5) Select protocol is used to call a web service"></asp:Label>
<br />
<br />
<asp:RadioButtonList ID="RadioButtonList1" runat="server">
    <asp:ListItem>Stp</asp:ListItem>
    <asp:ListItem>Ftp</asp:ListItem>
    <asp:ListItem>Smtp</asp:ListItem>
    <asp:ListItem>Http</asp:ListItem>
</asp:RadioButtonList>
<br />
<asp:Button ID="Button2" runat="server" OnClick="Button2_Click" style="width: 46px" Text="Back" />
&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
<asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="submit" />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
<br />
</asp:Content>
