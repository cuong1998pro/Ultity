<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="WebsiteTinTuc.Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Tiêu đề nội dung chính</h1>
    <div id="ndcontent">
        <ul>
            <asp:Repeater ID="rpChiTiet" runat="server">
                <ItemTemplate>
                    <li>
                        <a href="/baiviet/chi-tiet.aspx?idbantin=<%# Eval("IDBanTin") %>&id=<%# Eval("ID") %>"><%# Eval("TieuDe") %></a>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</asp:Content>