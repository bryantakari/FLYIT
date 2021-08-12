<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UnderConstructionPage.aspx.cs" Inherits="TugasSE.View.UnderConstructionPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/style.css" />
    <link rel="stylesheet" href="./css/construction.css" />
    <title>FlyIt | Under Construction</title>
    <link rel="icon" href="./asset/logo_FlyIt.png"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="underconstruction-content">
            <asp:Image CssClass="underconstruction-img" src="./asset/under_construction.png" ID="Image1" runat="server" />
            <h1>This page is currently under construction</h1>
            <a href="./LoginPage.aspx">Go back to Login Page</a>
        </div>
    </form>
</body>
</html>
