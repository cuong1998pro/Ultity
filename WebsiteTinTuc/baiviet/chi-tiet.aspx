<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="chi-tiet.aspx.cs" Inherits="WebsiteTinTuc.baiviet.chi_tiet" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <asp:Repeater ID="rpBanTin" runat="server">
        <ItemTemplate>
            <h1><%# Eval("TenBanTin") %></h1>
        </ItemTemplate>
    </asp:Repeater>
    <div id="ndcontent">
        <asp:Repeater ID="rpChiTiet" runat="server">
            <ItemTemplate>
                <h3 style="color: red"><%#  Eval("TieuDe")%></h3>
                <p style="text-align: right; font-style: italic">
                    Cập nhật: <%# DateTime.Parse(Eval("NgayDang").ToString()).ToString()%>
                    <br />
                    Số lần xem: <%# Eval("LanXem") %>
                </p>
                <%# Eval("NoiDung") %>
            </ItemTemplate>
        </asp:Repeater>

        <h3 style="color: blue">Các tin khác</h3>
        <ul>
            <asp:Repeater ID="rpRandom" runat="server">
                <ItemTemplate>
                    <li>
                        <a href="/baiviet/chi-tiet.aspx?idbantin=<%# Eval("IDBanTin") %>&id=<%# Eval("ID") %>"><%# Eval("TieuDe") %></a>
                    </li>
                </ItemTemplate>
            </asp:Repeater>
        </ul>
    </div>
</asp:Content>