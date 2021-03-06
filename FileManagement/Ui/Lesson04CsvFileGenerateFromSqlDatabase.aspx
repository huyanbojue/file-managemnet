﻿<%@ Page Language="C#" MasterPageFile="~/BootstrapMasterPage.Master" AutoEventWireup="true" CodeBehind="Lesson04CsvFileGenerateFromSqlDatabase.aspx.cs" Inherits="FileManagement.Ui.Lesson04CsvFileGenerateFromSqlDatabase" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <asp:Button ID="saveButton" runat="server" OnClick="saveButton_Click" Text="CsvFileGenerateFromSqlDatabase " Width="239px" />
            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="backButton" runat="server" ForeColor="#33CC33" OnClick="backButton_Click" Text="Back" Width="115px" />
            &nbsp;&nbsp;&nbsp;&nbsp;
            <asp:Label ID="messageLabel" runat="server" ForeColor="Red" Text="ShowMessage"></asp:Label>
            <br />
            <br />
            &nbsp;
            <asp:LinkButton ID="xmlLinkButton" runat="server" OnClick="xmlLinkButton_Click">Show xml File</asp:LinkButton>
            &nbsp;<asp:Label ID="xmlLabel" runat="server" ForeColor="Red" Text="ShowXmlData"></asp:Label>
            <br />
            <br />
            <br />
     </div>
        <script src="../Scripts/jquery-2.1.4.js"></script>
        <script src="../Scripts/bootstrap.js"></script>
    </form>

</asp:Content>
