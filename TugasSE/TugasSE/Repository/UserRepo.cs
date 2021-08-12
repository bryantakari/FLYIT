using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasSE.Model;
namespace TugasSE.Repository
{
    public class UserRepo
    {
        public static User GetUserByLogin(String username,String password,int apId)
        {
            DatabaseEntities db = new DatabaseEntities();
            return (from x in db.Users where x.ApartementId == apId 
                    && x.Username == username 
                    && x.Password == password select x).FirstOrDefault();
        }
        public static User getUserByUsername(String name)
        {
            DatabaseEntities db = new DatabaseEntities();
            return (from x in db.Users where x.Username == name select x).FirstOrDefault();
        }
        public static User GetUserByRoom(int room,int apartement)
        {
            DatabaseEntities db = new DatabaseEntities();
            return (from x in db.Users
                    where x.ApartementId == apartement && x.RoomNumber == room
                    select x).FirstOrDefault();
        }
    }
}