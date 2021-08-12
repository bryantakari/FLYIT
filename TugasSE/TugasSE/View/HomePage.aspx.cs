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
    public partial class HomePage : System.Web.UI.Page
    {
        static List<ListDelivery> data = new List<ListDelivery>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                UserController.checkLogin();
                UserController.checkCustomer();

                
                if (Request["filter"] != null)
                {
                    data = ItemController.getItemDeliveryByFilter(Request["filter"].ToString());
                    role.Text = "Room " + UserController.getUserRoom().ToString();
                    Label1.Text = "Total Item " + ": " + data.Count;


                    
                }else if(Request["status"] != null)
                {
                   
                    data = ItemController.getItemDeliveryByStatus(Request["status"].ToString());
                    role.Text = "Room " + UserController.getUserRoom().ToString();
                    Label1.Text = "Total Item " + ": " + data.Count;
                }
                else
                {
                    data = ItemController.getItemDelivery();
                    role.Text = "Room " + UserController.getUserRoom().ToString();
                    Label1.Text = "Total Item " + ": " + data.Count;
                }
                GridView1.DataSource = data;
                GridView1.DataBind();

            }
            
            
        }

        protected void btnDelivered_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx?status=Done");
        }

        protected void btnNotDelivered_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx?status=Pending");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("HomePage.aspx?filter=" + TextBox1.Text);
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