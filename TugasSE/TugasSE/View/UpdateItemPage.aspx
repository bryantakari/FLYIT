<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="UpdateItemPage.aspx.cs" Inherits="TugasSE.View.UpdateItemPage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/style.css" />
    <link rel="stylesheet" href="./css/update.css" />
    <title>FlyIt | Update Item</title>
    <link rel="icon" href="./asset/logo_FlyIt.png"/>
</head>
<body>
    <form id="form1" runat="server">
        <div class="updateItem-page">
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
                <div class="title">Update Item</div>

                <div class="container-form">
                    <div>
                        <asp:Label ID="Label1" name="itemName" runat="server" Text="Item Name"></asp:Label>
                        <asp:TextBox ID="itemName" CssClass="textbox" name="itemName" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="Label2" runat="server" Text="Note"></asp:Label>
                        <asp:TextBox ID="itemNote" CssClass="textbox" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="Label3" runat="server" Text="Room Number"></asp:Label>
                        <asp:TextBox ID="itemRoom" CssClass="textbox" runat="server"></asp:TextBox>
                    </div>
                    <div>
                        <asp:Label ID="Label4" runat="server" Text="Status"></asp:Label>
                        <asp:TextBox ID="itemStatus" CssClass="textbox" runat="server"></asp:TextBox>
                    </div>
                    <asp:Label CssClass="alert-label" ID="lbl" runat="server" Text=""></asp:Label>
                    <asp:Button CssClass="submit-button" ID="submitBtn" runat="server" Text="submit" onClick="submitBtn_Click" />
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
