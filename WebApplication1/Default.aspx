<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <asp:Button ID="Button1" runat="server" Text="Cliccami" OnClick="Button1_Click"/>
        <asp:Label ID="Label1" runat="server" Text="Nome Candidato"></asp:Label>
    </main>

</asp:Content>
