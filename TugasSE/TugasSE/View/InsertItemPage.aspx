<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="InsertItemPage.aspx.cs" Inherits="TugasSE.View.InsertItemPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/style.css" />
    <link rel="stylesheet" href="./css/insert.css" />
    <title>FlyIt | Insert Item</title>
    <link rel="icon" href="./asset/logo_FlyIt.png"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="insertItem-page">
            <div class="upper">
                <a href="./HomePage_admin.aspx">
                    <asp:Image CssClass="logo-image" src="./asset/logo_FlyIt.png" ID="Image1" runat="server" />
                </a>
                <div class="role">
                    <asp:Label CssClass="role-text" ID="role" runat="server" Text="Admin"></asp:Label>
                </div>
            </div>
            
            <div class="container" >
                <a class="back-to-home" href="./HomePage_admin.aspx"><< Back to Home Page</a>
                <div class="title">Insert Item</div>

                <div class="container-form">
                    <div>
                        <asp:Label ID="Label3" name="room" runat="server" Text="Room Number (in numeric)"></asp:Label>
                        <asp:TextBox CssClass="textbox" ID="room" name="room" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="Label1" name="itemName" runat="server" Text="Item Name"></asp:Label>
                        <asp:TextBox CssClass="textbox" ID="itemName" name="itemName" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="Label2" runat="server" Text="Note"></asp:Label>
                        <asp:TextBox CssClass="textbox" ID="note" runat="server"></asp:TextBox>
                    </div>
                    <asp:Label CssClass="alert-label" ID="lbl" runat="server" Text=""></asp:Label>
                    <asp:Button CssClass="submit-button" ID="submitBtn" runat="server" Text="submit" OnClick="submitBtn_Click" />
                </div>
            </div>
            
            <div class="bottom">
                <a href="./UnderConstructionPage.aspx">
                    <asp:Image class="supportBtn" src="./asset/supportBtn.png" ID="Image2" runat="server" />
                </a>
            </div>
        </div>
    </form>
</body>
</html>
