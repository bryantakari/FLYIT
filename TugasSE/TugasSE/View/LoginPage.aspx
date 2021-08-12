<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginPage.aspx.cs" Inherits="TugasSE.View.LoginPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/style.css" />
    <link rel="stylesheet" href="./css/login.css" />
    <title>FlyIt | Login</title>
    <link rel="icon" href="./asset/logo_FlyIt.png"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="login-page">
            <div class="container">
                <div class="title">Login</div>
                <div class="content">
                    <div class="container-image">
                        <asp:Image src="./asset/logo_FlyIt.png" ID="Image1" runat="server" />
                    </div>
                    <div class="container-form">
                        <div>
                            <asp:Label ID="Label1" name="username" runat="server" Text="Username"></asp:Label>
                            <asp:TextBox CssClass="textbox" ID="username" name="username" runat="server"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="Label2" runat="server" Text="Password"></asp:Label>
                            <asp:TextBox CssClass="textbox" ID="password" runat="server"></asp:TextBox>
                        </div>
                        <div>
                            <asp:Label ID="Label3" runat="server" Text="Apartment Code"></asp:Label>
                            <asp:TextBox CssClass="textbox" ID="apartementId" runat="server"></asp:TextBox>
                        </div>
                        <asp:Label CssClass="alert-label" ID="lbl" runat="server" Text=""></asp:Label>
                        <asp:Button CssClass="login-button" ID="loginBtn" runat="server" Text="login" onClick="loginBtn_Click" />
                        <a class="forgot-password" href="./UnderConstructionPage.aspx">Forgot password?</a>
                    </div>
                </div>
            </div>
        </div>
        
    </form>
</body>
</html>
