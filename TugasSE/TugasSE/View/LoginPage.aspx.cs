using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using TugasSE.Controller;
namespace TugasSE.View
{
    public partial class LoginPage : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            password.Attributes["type"] = "password";
        }

        protected void loginBtn_Click(object sender, EventArgs e)
        {
            lbl.Text = UserController.checkLogin(username.Text,password.Text,apartementId.Text);
        }
    }
}