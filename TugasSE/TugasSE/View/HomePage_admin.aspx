<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="HomePage_admin.aspx.cs" Inherits="TugasSE.View.HomePage_admin" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <link rel="stylesheet" href="./css/style.css" />
    <link rel="stylesheet" href="./css/home.css" />
    <title>FlyIt | Home</title>
    <link rel="icon" href="./asset/logo_FlyIt.png"/>
    <script src="./js/jquery-3.6.0.min.js" type="text/javascript"></script>
    <script src="./js/modal.js" type="text/javascript"></script>
</head>
<body>
    <form id="form1" runat="server">
        <div class="home-page">
            <div class="upper">
                <a href="./HomePage_admin.aspx">
                    <asp:Image CssClass="logo-image" src="./asset/logo_FlyIt.png" ID="Image1" runat="server" />
                </a>
                <div class="role">
                    <asp:Label CssClass="role-text" ID="role" runat="server" Text="Admin"></asp:Label>
                </div>
                <asp:Button CssClass="edit-password" ID="Button5" runat="server" Text="Edit Password" onClick="Button5_Click"/>
                <asp:Button CssClass="logout" ID="Button6" runat="server" Text="Logout" onClick="Button6_Click"/>
            </div>
            <div class="container">
                <div class="content-top">
                    <div class="search">
                        <asp:TextBox CssClass="search-text-box" ID="TextBox1" placeholder="Search" runat="server"></asp:TextBox>
                        <asp:Button CssClass="search-button" ID="Button7" runat="server" Text="" OnClick="Button7_Click" />
                    </div>
                    
                    <div class="delivery-buttons">
                        <asp:Button CssClass="delivered-button" ID="Button1" runat="server" Text="Delivered" onClick="btnDelivered_Click" />
                        <asp:Button CssClass="not-delivered-button" ID="Button2" runat="server" Text="Not Delivered" onClick="btnNotDelivered_Click"/>
                    </div>
                </div>
                <div class="content-mid">
                    <asp:GridView CssClass="item-list" ID="GridView1" runat="server" AutoGenerateColumns="False" RowStyle-CssClass="rows" OnRowCommand="GridView1_RowCommand" >
                        <Columns>
                            <asp:BoundField Datafield="Item.ItemName" HeaderText="Item Name" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField Datafield="Item.ItemNote" HeaderText="Note" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField Datafield="User.RoomNumber" HeaderText="Room Number" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField Datafield="DateDelivery" HeaderText="Date" ItemStyle-HorizontalAlign="Center" />
                            <asp:BoundField DataField="Status" HeaderText="Status" ItemStyle-HorizontalAlign="Center" />
                            <asp:TemplateField HeaderText="Update" ItemStyle-HorizontalAlign="Center">
                                <ItemTemplate>
                                    <asp:Button CssClass="delete-button" ID="Button3" CommandName="DeleteItem" runat="server" Text="" onClick="Button3_Click"/>
                                    <asp:Button CssClass="update-button" ID ="Button4" CommandName="UpdateItem" runat="server" Text="" onClick="Button3_Click"/>
                                </ItemTemplate>
                            </asp:TemplateField>
                        </Columns>
                    </asp:GridView>
                </div>
                <div class="content-bottom">
                    <div class="total-item">
                        <asp:Label CssClass="total-item-text" ID="Label1" runat="server" Text="total item"></asp:Label>
                    </div>
                    <a class="insert-item" href="./InsertItemPage.aspx">
                        Insert Item
                    </a>
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
