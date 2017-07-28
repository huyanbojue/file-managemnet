<%@ Page Title="" Language="C#" MasterPageFile="~/BootstrapMasterPage.Master" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="FileManagement.Ui.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <form id="form1" runat="server">
    <br/>
     <div style="height: 173px; width: 739px">
     <asp:Button ID="Button1" runat="server" Text="Button" />
    <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox> 
    </div>
   <script src="../Scripts/jquery-2.1.4.js"></script>
    <script src="../Scripts/bootstrap.js"></script>
   
    </form>
</asp:Content>
