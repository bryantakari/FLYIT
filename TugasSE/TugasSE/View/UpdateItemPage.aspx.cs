using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasSE.Controller;
using TugasSE.Model;

namespace TugasSE.View
{
    public partial class UpdateItemPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserController.checkLogin();
                UserController.checkAdmin();
                ListDelivery temp = ItemController.getItemById(int.Parse(Request["itemId"].ToString()));
                itemName.Text = temp.Item.ItemName;
                itemNote.Text = temp.Item.ItemNote;
                itemRoom.Text = temp.User.RoomNumber.ToString();
                itemStatus.Text = temp.Status;
                
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            lbl.Text = ItemController.updateItem(int.Parse(Request["itemId"].ToString()),itemName.Text, itemNote.Text, itemRoom.Text, itemStatus.Text);
        }
    }
}