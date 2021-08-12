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
    public partial class HomePage_admin : System.Web.UI.Page
    {
        static List<ListDelivery> data = new List<ListDelivery>();
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (!Page.IsPostBack)
            {
                UserController.checkLogin();
                UserController.checkAdmin();
                if (Request["filter"] != null)
                {
                    data = ItemController.getAllItemByFilter(Request["filter"].ToString());
                    role.Text = "Admin";
                    Label1.Text = "Total Item " + ": " + data.Count;

                    
                }else if (Request["status"] != null)
                {
                    data = ItemController.getItemByStatus(Request["status"].ToString());
                    role.Text = "Admin";
                    Label1.Text = "Total Item " + ": " + data.Count;
                }
                else
                {
                    data = ItemController.getAllItem();                 
                    role.Text = "Admin";
                    Label1.Text += ": " + ItemController.totalItem();
                    Label1.Text = "Total Item " + ": " + data.Count;
                    System.Diagnostics.Debug.WriteLine("Test");
                    System.Diagnostics.Debug.WriteLine(data.Count);
                }
                GridView1.DataSource = data;
                GridView1.DataBind();
            }
        }

        protected void btnDelivered_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage_admin.aspx?status=Done");
        }

        protected void btnNotDelivered_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage_admin.aspx?status=Pending");
        }

        protected void GridView1_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            
            GridViewRow gvr = (GridViewRow)btn.NamingContainer;
            System.Diagnostics.Debug.WriteLine(data.Count);
            ListDelivery ld = data.ElementAt(gvr.RowIndex);
            System.Diagnostics.Debug.WriteLine(ld.Item.ItemName);
            if(btn.CommandName.Equals("UpdateItem") == true)
            {
                Response.Redirect("UpdateItemPage.aspx?itemId=" + ld.ItemId);
            }
            else
            {
                ItemController.deleteItem(ld);
            }
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage_admin.aspx?filter="+TextBox1.Text);
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            UserController.logOut();
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("UnderConstructionPage.aspx");
        }
    }
}