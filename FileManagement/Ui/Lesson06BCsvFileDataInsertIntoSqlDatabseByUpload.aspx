<%@ Page Language="C#" MasterPageFile="~/BootstrapMasterPage.Master" AutoEventWireup="true" CodeBehind="Lesson06BCsvFileDataInsertIntoSqlDatabseByUpload.aspx.cs" Inherits="FileManagement.Ui.Lesson06BCsvFileDataInsertIntoSqlDatabseByUpload" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <form id="form1" runat="server">
        <div>
            <div class="" style="margin-top: 30px; font-weight: bold; color: black; font-style: normal; font-family: Verdana; text-align: center;">
                <span style="font-size: 14pt">&nbsp;&nbsp; CSV File Data Insert Into Sql Database By Upload</span>
            </div>

            <table border="0" style="margin-top: 20px; margin-bottom: 20px; font-family: Verdana; text-align: right; margin-left: 10%; font-size: 12pt;">

                <tr>
                    <td style="width: 164px; height: 21px; font-weight: bold; color: #758a85; font-size: small; font-family: Verdana;" align="left">
                        <span style="font-size: 10pt">File Name</span></td>
                    <td style="width: 5px; height: 21px; font-family: Verdana;"></td>
                    <td style="width: 243px; height: 21px; font-family: Verdana; text-align: left;">
                        <asp:FileUpload ID="FileUpload1" runat="server" />
                    </td>
                </tr>
                <tr style="font-family: Verdana">
                    <td colspan="3" style="text-align: center"></td>
                </tr>
                <tr style="font-family: Verdana">
                    <td colspan="2"></td>
                    <td align="left">&nbsp;
            <asp:Button ID="uploadButton" Text="Upload txt File" runat="server" OnClick="UploadXML" />
                        &nbsp;
                        <input type="reset" id="button_reset" name="cmdReset" onclick="return button_reset_onclick()" />&nbsp;<asp:Button ID="backButton" runat="server" ForeColor="#33CC33" OnClick="backButton_Click" Text="Back" Width="115px" />
                        &nbsp;<br />
                    </td>
                </tr>
            </table>
            <p>
                <asp:Label ID="lblMessage" runat="server" Font-Bold="True" Font-Size="Large" BorderStyle="None" Width="537px"></asp:Label>
            </p>
            <br />
            <br />
            <br />
        </div>
        <script src="../Scripts/jquery-2.1.4.js"></script>
        <script src="../Scripts/bootstrap.js"></script>
    </form>

</asp:Content>
