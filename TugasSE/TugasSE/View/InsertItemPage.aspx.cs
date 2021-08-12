using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasSE.Controller;


namespace TugasSE.View
{
    public partial class InsertItemPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                UserController.checkLogin();
                UserController.checkAdmin();
            }
        }

        protected void submitBtn_Click(object sender, EventArgs e)
        {
            lbl.Text = ItemController.addItem(itemName.Text,note.Text,room.Text);
        }
    }
}