<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="WebsiteTinTuc.Register" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Đăng ký thành viên mới</h1>
    <div id="ndcontent">
        <h4>Tên đăng nhập</h4>
        <asp:TextBox ID="txtUsername" Width="300" Height="20" runat="server"></asp:TextBox>
        <h4>Mật khẩu</h4>
        <asp:TextBox ID="txtPassword" TextMode="Password" Width="300" Height="20" runat="server"></asp:TextBox>
        <h4>Nhập lại mật khẩu</h4>
        <asp:TextBox ID="txtNhapLai" TextMode="Password" Width="300" Height="20" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="btnRegister" Text="Đăng ký" runat="server" OnClick="btnRegister_Click" />
        <h4>
            <asp:Label ID="lblThongBao" runat="server" ForeColor="#FF3300" />
        </h4>
    </div>
</asp:Content>