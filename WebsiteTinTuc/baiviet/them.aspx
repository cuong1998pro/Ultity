<%@ Page Title="" Language="C#" MasterPageFile="~/Home.Master" AutoEventWireup="true" CodeBehind="them.aspx.cs" Inherits="WebsiteTinTuc.baiviet.them" %>
<%@ Register Assembly="CKEditor.NET" Namespace="CKEditor.NET" TagPrefix="CKEditor" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Thêm bài viết mới
    </h1>
    <div id="ndcontent">
        <h4>Chọn bản tin:</h4>
        <asp:DropDownList ID="drBanTin" Width="607px" Height="24px" runat="server"></asp:DropDownList>
        <h4>Tiêu đề bản tin:</h4>
        <asp:TextBox ID="txtTieuDe" runat="server" Width="600px" Height="20px"></asp:TextBox>
        <h4>Nội dung bản tin</h4>
        <CKEditor:CKEditorControl ID="txtNoiDung" runat="server" Height="198px" Width="607px"></CKEditor:CKEditorControl>
      
        <asp:Label ID="lblThongBao" Visible="false" runat="server" Text="" ForeColor="Red"></asp:Label>
         <br />
        <br />
        <asp:Button Text="Cập nhật" ID="btnCapNhat" runat="server" OnClick="btnCapNhat_Click" />
    </div>
</asp:Content>