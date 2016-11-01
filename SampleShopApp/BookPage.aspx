<%@ Page Title="List Of Book" Language="vb" AutoEventWireup="false" MasterPageFile="~/Site.Master" CodeBehind="BookPage.aspx.vb" Inherits="SampleShopApp.BookPage" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <h2>Daftar Buku</h2><br />

    <asp:GridView runat="server" AutoGenerateColumns="False" CssClass="table table-stripped"
         ID="dgvBuku" ItemType="BO.Book" SelectMethod="dgvBuku_GetData">
        <Columns>
            <asp:BoundField DataField="BookID" HeaderText="ID" />
            <asp:BoundField DataField="Category.CategoryName" HeaderText="Category" />
            <asp:BoundField DataField="Title" HeaderText="Title" />
            <asp:BoundField DataField="Price" DataFormatString="{0:N0}" HeaderText="Price">
            <ItemStyle HorizontalAlign="Right" />
            </asp:BoundField>
            <asp:BoundField DataField="Author.FirstName" HeaderText="Author" />
        </Columns>
    </asp:GridView>
</asp:Content>
