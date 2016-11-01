<%@ Page Title="List Of Book" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="BookPage.aspx.vb" Inherits="SampleShopApp.BookPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Daftar Buku</h2><br />

    <asp:GridView runat="server" ID="dgvBuku" ItemType="BO.Book" SelectMethod="dgvBuku_GetData">
    </asp:GridView>
</asp:Content>
