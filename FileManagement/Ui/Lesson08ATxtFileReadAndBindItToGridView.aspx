<%@ Page Language="C#" MasterPageFile="~/BootstrapMasterPage.Master" AutoEventWireup="true" CodeBehind="Lesson08ATxtFileReadAndBindItToGridView.aspx.cs" Inherits="FileManagement.Ui.Lesson08ATxtFileReadAndBindItToGridView" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
    <div>
            <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show Data in a Grid From txt Tidle file " Width="239px" />
            &nbsp;
        <asp:Button ID="backButton" runat="server" ForeColor="#33CC33" OnClick="backButton_Click" Text="Back" Width="115px" />
            <br />
            <br />

            <asp:GridView ID="GridView1" runat="server" AllowPaging="true" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" OnPageIndexChanging="OnPageIndexChanging" RowStyle-BackColor="#A1DCF2">
            </asp:GridView>
            <br />
            <br />
        </div>
        <script src="../Scripts/jquery-2.1.4.js"></script>
        <script src="../Scripts/bootstrap.js"></script>
    </form>

</asp:Content>
