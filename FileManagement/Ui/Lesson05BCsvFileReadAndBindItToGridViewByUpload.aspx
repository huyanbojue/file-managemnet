<%@ Page Language="C#" MasterPageFile="~/BootstrapMasterPage.Master" AutoEventWireup="true" CodeBehind="Lesson05BCsvFileReadAndBindItToGridViewByUpload.aspx.cs" Inherits="FileManagement.Ui.Lesson05BCsvFileReadAndBindItToGridViewByUpload" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>

<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
       <div>
            <br />
            <br />
            <span style="font-size: 14pt">&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; CSV File Data View In A GridView</span>
            <table border="0" style="margin-top: 20px; margin-bottom: 20px; font-family: Verdana; text-align: right; margin-left: 10%; font-size: 12pt;">

                <tr>
                    <td style="width: 164px; height: 21px; font-weight: bold; color: #758a85; font-size: small; font-family: Verdana;" align="left">
                        <span style="font-size: 10pt">File Name</span></td>
                    <td style="width: 5px; height: 21px; font-family: Verdana;"></td>
                    <td style="width: 243px; height: 21px; font-family: Verdana; text-align: left;">
                        <asp:FileUpload ID="FileUpload1" runat="server" Height="28px" Width="273px" />
                    </td>
                </tr>
                <tr style="font-family: Verdana">
                    <td colspan="3" style="text-align: center">&nbsp;</td>
                </tr>
                <tr style="font-family: Verdana">
                    <td colspan="2"></td>
                    <td align="left">&nbsp;
                        &nbsp;
                        <asp:Button ID="showButton" runat="server" OnClick="showButton_Click" Text="Show Data in a Grid From CSV file " Width="228px" />
                        &nbsp;
                        <asp:Button ID="backButton" runat="server" ForeColor="#33CC33" OnClick="backButton_Click" Text="Back" Width="115px" />
                        <br />
                    </td>
                </tr>
            </table>
            &nbsp;
            <asp:Label ID="msgLabel" runat="server"></asp:Label>
            <br />
            <br />
           <asp:GridView ID="GridView1" runat="server" AllowPaging="true" AlternatingRowStyle-BackColor="White" AlternatingRowStyle-ForeColor="#000"  HeaderStyle-BackColor="#3AC0F2" HeaderStyle-ForeColor="White" OnPageIndexChanging="OnPageIndexChanging" RowStyle-BackColor="#A1DCF2">
                
            </asp:GridView>
            <br />
            <br />
            <br />
     </div>
        <script src="../Scripts/jquery-2.1.4.js"></script>
        <script src="../Scripts/bootstrap.js"></script>
    </form>

</asp:Content>