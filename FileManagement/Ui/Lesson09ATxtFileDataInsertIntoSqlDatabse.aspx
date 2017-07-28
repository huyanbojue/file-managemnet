<%@ Page Language="C#" MasterPageFile="~/BootstrapMasterPage.Master"  AutoEventWireup="true" CodeBehind="Lesson09ATxtFileDataInsertIntoSqlDatabse.aspx.cs" Inherits="FileManagement.Ui.Lesson09ATxtFileDataInsertIntoSqlDatabse" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
   <div>
    <asp:Button ID="insertButton" runat="server" OnClick="insertButton_Click" Text="Txt File Data Insert Into Sql Databse" Width="239px" />
        &nbsp;&nbsp;
        <asp:Button ID="backButton" runat="server" ForeColor="#33CC33" OnClick="backButton_Click" Text="Back" Width="115px" />
        <br />
        <br />
        <asp:Label ID="messageLabel" runat="server" ForeColor="Red" Text="ShowMessage"></asp:Label>

            <br />
            <br />
        </div>
        <script src="../Scripts/jquery-2.1.4.js"></script>
        <script src="../Scripts/bootstrap.js"></script>
    </form>

</asp:Content>
