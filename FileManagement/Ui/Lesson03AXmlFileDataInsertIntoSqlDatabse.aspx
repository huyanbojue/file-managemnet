<%@ Page Language="C#" MasterPageFile="~/BootstrapMasterPage.Master" AutoEventWireup="true" CodeBehind="Lesson03AXmlFileDataInsertIntoSqlDatabse.aspx.cs" Inherits="FileManagement.Ui.Lesson03AXmlFileDataInsertIntoSqlDatabse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form2" runat="server">
         <br />
         <br />
        <div>
            &nbsp;
        <br />
            &nbsp;<asp:Button ID="Button1" runat="server" OnClick="insertButton_Click" Text="Xml File Data Insert Into Sql Databse" Width="239px" />
            &nbsp;&nbsp;
        <asp:Button ID="Button2" runat="server" ForeColor="#33CC33" OnClick="backButton_Click" Text="Back" Width="115px" />
            <br />
            <br />
            &nbsp;
        <asp:Label ID="messageLabel" runat="server" ForeColor="Red" Text="ShowMessage"></asp:Label>
            <br />
            <br />
            <br />
           
        </div>
        <script src="../Scripts/jquery-2.1.4.js"></script>
        <script src="../Scripts/bootstrap.js"></script>
    </form>

</asp:Content>

