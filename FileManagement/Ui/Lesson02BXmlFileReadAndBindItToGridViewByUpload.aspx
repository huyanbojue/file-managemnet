<%@ Page Language="C#" MasterPageFile="~/BootstrapMasterPage.Master" AutoEventWireup="true" CodeBehind="Lesson02BXmlFileReadAndBindItToGridViewByUpload.aspx.cs" Inherits="FileManagement.Ui.Lesson02BXmlFileReadAndBindItToGridViewByUpload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
            <br />
            <br />
            <span style="font-size: 14pt">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; Xml File Data View in a Grid View</span>
            <table border="0" style="margin-top: 20px; margin-bottom: 20px; font-family: Verdana; text-align: right; margin-left: 10%; font-size: 12pt;">

                <tr>
                    <td style="font-weight: bold; color: #758a85; font-size: small; font-family: Verdana;" align="left" >
                        <span style="font-size: 10pt">File Name</span></td>
                    <td style="font-family: Verdana;" ></td>
                    <td style="font-family: Verdana; text-align: left;" >
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr style="font-family: Verdana">
                    <td colspan="3" style="text-align: center">&nbsp;</td>
                </tr>
                <tr style="font-family: Verdana">
                    <td colspan="2"></td>
                    <td align="left">&nbsp;
                        &nbsp;
                        <asp:Button ID="Button1" runat="server" OnClick="showButton_Click" Text="Show Data in a Grid From xml file " Width="239px" />
                        &nbsp;
              <asp:Button ID="Button2" runat="server" ForeColor="#33CC33" OnClick="backButton_Click" Text="Back" Width="115px" />
                        &nbsp;
                        <br />
                    </td>
                </tr>
            </table>
            &nbsp;
            <asp:Label ID="msgLabel" runat="server"></asp:Label>
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




