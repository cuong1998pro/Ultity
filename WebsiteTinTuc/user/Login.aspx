<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="WebsiteTinTuc.Login" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Đăng nhập hệ thống quản trị Website</h1>
    <div id="ndcontent">
        <h4>Tên đăng nhập</h4>
        <asp:TextBox ID="txtUsername" Width="300" Height="20" runat="server"></asp:TextBox>
        <h4>Mật khẩu</h4>
        <asp:TextBox ID="txtPassword" TextMode="Password" Width="300" Height="20" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnLogin" Text="Đăng nhập" runat="server" OnClick="btnLogin_Click" />
        <h4>
            <asp:Label ID="lblThongBao" runat="server" ForeColor="#FF3300" />
        </h4>
    </div>
</asp:Content>