<%@ Page Language="C#" MasterPageFile="~/BootstrapMasterPage.Master" AutoEventWireup="true" CodeBehind="Lesson02AXmlFileReadAndBindItToGridView.aspx.cs" Inherits="FileManagement.Ui.Lesson02AXmlFileReadAndBindItToGridView" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
        
            <br />
            <br />
            &nbsp;&nbsp;
            <asp:Button ID="Button1" runat="server" OnClick="showButton_Click" Text="Show Data in a Grid From xml file " Width="239px" />
            &nbsp;&nbsp;
           <asp:Button ID="Button2" runat="server" ForeColor="#33CC33" OnClick="backButton_Click" Text="Back" Width="115px" />
            <br />
            <br />
            <asp:GridView ID="productGridView" runat="server" AllowPaging="true" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000" AutoGenerateColumns="false" HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" OnPageIndexChanging="OnPageIndexChanging" RowStyle-BackColor="#A1DCF2">
                <Columns>
                    <asp:BoundField DataField="ProductCode" HeaderText="ProductCode" ItemStyle-Width="80" />
                    <asp:BoundField DataField="ProductName" HeaderText="ProductName" ItemStyle-Width="150" />
                    <asp:BoundField DataField="ProductQuantity" HeaderText="ProductQuantity" ItemStyle-Width="150" />
                </Columns>
            </asp:GridView>
            <br />
            <br />
            <br />
          </div>
          <script src="../Scripts/jquery-2.1.4.js"></script>
          <script src="../Scripts/bootstrap.js"></script>
    </form>

</asp:Content>
