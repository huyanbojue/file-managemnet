<%@ Page Language="C#" MasterPageFile="~/BootstrapMasterPage.Master"  AutoEventWireup="true" CodeBehind="HomeUi.aspx.cs" Inherits="FileManagement.Ui.HomeUi" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Bootstrap Example</title>
    <meta charset="utf-8" />
    <meta name="viewport" content="width=device-width, initial-scale=1" />
    <link rel="stylesheet" href="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/css/bootstrap.min.css" />
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/1.11.3/jquery.min.js"></script>
    <script src="http://maxcdn.bootstrapcdn.com/bootstrap/3.3.4/js/bootstrap.min.js"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="container">
            <h2>Image Gallery</h2>
          
            <div class="row">
                <div class="col-md-4">
                    <a class="thumbnail">
                        <img src="../Images/CSV1.png" alt="Pulpit Rock" style="width: 150px; height: 150px" />
                    </a>
                </div>
                <div class="col-md-4">
                   <a class="thumbnail">
                        <img src="../Images/TextFile.png" alt="Moustiers Sainte Marie" style="width: 150px; height: 150px" />
                    </a>
                </div>
                <div class="col-md-4">
                    <a  class="thumbnail">
                        <img src="../Images/xml.png" alt="Cinque Terre" style="width: 150px; height: 150px" />
                    </a>
                </div>
                 
            </div>
            
        </div>
    </form>
</body>
</html>
    
</asp:Content>