using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasSE.Model;
using TugasSE.Factory;
using TugasSE.Repository;
namespace TugasSE.Handler
{
    public class UserHandler
    {
        public static User GetSession()
        {
            return UserFactory.GetSession();
        }
        public static User checkLogin(String username,String password,int apId)
        {
            return UserRepo.GetUserByLogin(username,password,apId);
        }

        public static User getUserByUsername(String name)
        {
            return UserRepo.getUserByUsername(name);
        }
    }
}