<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TxtUi.aspx.cs" Inherits="FileManagement.Ui.TxtUi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
   <div>
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;Txt UI<br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />

            <br />
            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtFileGenerateButton" runat="server" OnClick="txtFileGenerateButton_Click" Text="Txt File Generate From SqlDatabase " Width="296px" />
            &nbsp;&nbsp;&nbsp;<br />

            <br />
            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="txtFileViewButton" runat="server" OnClick="txtFileViewButton_Click" Text="Txt File Read And BindIt To GridView" Width="302px" />
            <br />
            <br />
            &nbsp; &nbsp;
        <asp:Button ID="txtFileViewByUploadButton" runat="server" OnClick="txtFileViewByUploadButton_Click" Text="Txt File Read And Bind It To GridView By Upload" Width="306px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            <br />
            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="dataInsertButton" runat="server" OnClick="dataInsertButton_Click" Text="Txt File Data Insert Into Sql Databse" Width="301px" />
            <br />
            <br />
            &nbsp;&nbsp;
        <asp:Button ID="dataInsertByUploadButton" runat="server" OnClick="dataInsertByUploadButton_Click" Text="Txt File Data Insert Into SqlDatabse By Upload" Width="298px" />
            <br />
            <br />
            &nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <asp:Button ID="backButton" runat="server" ForeColor="#33CC33" OnClick="backButton_Click" Text="Back" Width="115px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;
            <br />
            <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
        </div>
    </form>
</body>
</html>
