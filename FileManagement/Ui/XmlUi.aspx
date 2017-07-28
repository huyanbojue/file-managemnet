<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="XmlUi.aspx.cs" Inherits="FileManagement.Ui.XmlUi" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; 
           Xml UI
           <br />
           <br />

            <br />
            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="xmlFileGenerateButton" runat="server" OnClick="xmlFileGenerateButton_Click" Text="XML File Generate From SqlDatabase " Width="296px" />
            &nbsp;&nbsp;&nbsp;<br />

            <br />
            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="xmlFileViewButton" runat="server" OnClick="xmlFileViewButton_Click" Text="Xml File Read And BindIt To GridView" Width="302px" />
            <br />
            <br />
            &nbsp; &nbsp;
        <asp:Button ID="updateButton" runat="server" OnClick="xmlFileViewByUploadButton_Click" Text="Xml File Read And Bind It To GridView By Upload" Width="306px" />
            &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
        <br />
            <br />
            &nbsp;&nbsp;&nbsp;
        <asp:Button ID="dataInsertButton" runat="server" OnClick="dataInsertButton_Click" Text="Xml File Data Insert Into Sql Databse" Width="298px" />
            <br />
            <br />
&nbsp;&nbsp;
        <asp:Button ID="dataInsertByUploadButton" runat="server" OnClick="dataInsertByUploadButton_Click" Text="Xm lFile Data Insert Into SqlDatabse By Upload" Width="298px" />
            <br />
            &nbsp;&nbsp;<br />
&nbsp; &nbsp;
        <asp:Button ID="dataInsertByUploadUsingSpButton" runat="server" OnClick="dataInsertByUploadUsingSpButton_Click" Text="Xm lFile Data Insert Into SqlDatabse By Upload Using Sp" Width="298px" />
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
