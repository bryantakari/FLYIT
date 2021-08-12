using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasSE.Model;
namespace TugasSE.Factory
{
    public class UserFactory
    {
        public static User GetSession()
        {
            User u = (User)HttpContext.Current.Session["User"];
            return u;
        } 

        
    }
}