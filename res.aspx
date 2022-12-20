<%@ Page Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="res.aspx.cs" Inherits="home.res" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <p>
    Thank you!!&nbsp;
    <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
</p>
    Your Mark =<asp:Label ID="Label3" runat="server" Text="Label"></asp:Label>
&nbsp;<p>
        your Answers
</p>
<p>
    <asp:GridView ID="GridView1" runat="server" Height="116px" Width="628px" OnSelectedIndexChanged="GridView1_SelectedIndexChanged">
    </asp:GridView>
</p>
    <p>
        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="click here to see coorect Answer" />
</p>
    <p>
        <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
</p>
    <p>
    &nbsp;&nbsp;&nbsp;
        <asp:GridView ID="GridView2" runat="server" Height="138px" Width="611px">
        </asp:GridView>
</p>
    <p>
        &nbsp;</p>
&nbsp;
</asp:Content>
