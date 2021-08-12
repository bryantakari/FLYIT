using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasSE.Model;
namespace TugasSE.Factory
{
    public class ItemFactory
    {
        public static Item createItem(String name,String note)
        {
            Item temp = new Item();
            temp.ItemName = name;
            temp.ItemNote = note;
            return temp;
        }

        public static ListDelivery createList(String name,String note,User u,int Id)
        {
            ListDelivery temp = new ListDelivery();
            temp.ItemId = Id;
            temp.Status = "Pending";
            temp.Username = u.Username;
            temp.DateDelivery = DateTime.Now;

            return temp;
        }
    }
}