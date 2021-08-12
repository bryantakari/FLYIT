using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasSE.Model;
using TugasSE.Handler;
namespace TugasSE.Controller
{
    public class UserController
    {
        public static void checkLogin()
        {
            if(UserHandler.GetSession() == null)
            {
                HttpContext.Current.Response.Redirect("LoginPage.aspx");
            }
        }
        
        public static User getSession()
        {
            return UserHandler.GetSession();
        }
        
        public static void checkCustomer()
        {
            User u = UserHandler.GetSession();
            if (!u.UserRole.RoleName.Equals("Customer"))
            {
                HttpContext.Current.Response.Redirect("HomePage.aspx");
            }
        }

        public static void checkAdmin()
        {
            User u = UserHandler.GetSession();
            if (!u.UserRole.RoleName.Equals("Admin"))
            {
                HttpContext.Current.Response.Redirect("HomePage.aspx");
            }
        }

        public static String checkLogin(String username,String password,String apartementId)
        {
            String error = "";
            int count = 0;
            if (username.Equals(""))
            {
                error += "Username Cannot Be Empty <br />";
            }
            else count++;

            if (password.Equals(""))
            {
                error += "Password Cannot Be Empty <br />";
            }
            else count++;
            int tryparsed = 0;
            bool numeric = int.TryParse(apartementId,out tryparsed);
            if (numeric == false)
            {
                error += "Apartement Code Must be Numeric <br />";
            }
            else count++;

            if(count == 3)
            {
                User u = UserHandler.checkLogin(username, password, int.Parse(apartementId));
                if(u == null)
                {
                    error += "Username Not Found!<br />Please check your username,password and Apartement Code<br />";
                }
                else
                {
                    if(u.RoleId == 1)
                    {
                        HttpContext.Current.Session.Add("User", u);
                        HttpContext.Current.Response.Redirect("HomePage.aspx");
                    }
                    else if(u.RoleId == 2)
                    {
                        HttpContext.Current.Session.Add("User", u);
                        HttpContext.Current.Response.Redirect("HomePage_admin.aspx");
                    }
                    
                }
            }

            return error;
        }
        public static void logOut()
        {
            HttpContext.Current.Session.Remove("User");
            HttpContext.Current.Response.Redirect("LoginPage.aspx");
        }
        public static int getUserRoom()
        {
            return UserHandler.GetSession().RoomNumber;
        }
    }
}