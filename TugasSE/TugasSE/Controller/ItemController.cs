using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasSE.Model;
using TugasSE.Handler;

namespace TugasSE.Controller
{
    public class ItemController
    {
        public static List<ListDelivery> getItemDelivery()
        {   
   
            return ItemHandler.getItemByUser();
        }
        public static List<ListDelivery> getAllItem()
        {
            return ItemHandler.getAllItem();
        }
        public static String addItem(String name,String note,String room)
        {
            String note1 = "";
            int count = 0;

            if (name == null)
            {
                note1 += "Username cannot be empty!<br />";
            }
            else count++;
            if (note == null)
            {
                note1 += "Password cannot be empty!<br />";
            }
            else count++;

            bool roomVal = int.TryParse(room, out int Parsed);
            if (!roomVal)
            {
                note1 += "Room Invalid!<br />";
            }
            else count++;
            if(count == 3)
            {
                ItemHandler.addItem(name, note, int.Parse(room));
                HttpContext.Current.Response.Redirect("HomePage_admin.aspx");
            }

            return note1;
        }
        public static void deleteItem(ListDelivery ld)
        {
            ItemHandler.deleteItem(ld.ItemId);
            HttpContext.Current.Response.Redirect("HomePage_admin.aspx");
        }
        
        public static ListDelivery getItemById(int itemId)
        {
            return ItemHandler.getItemById(itemId);
        }
        public static int totalItem()
        {
            User u = UserHandler.GetSession();
            if(u.UserRole.RoleName.Equals("Admin"))
            {
                return getAllItem().Count();
            }else if (u.UserRole.RoleName.Equals("Customer"))
            {
                return getItemDelivery().Count();
            }
            return -1;
        }
        public static int totalItemByFilter(String filter)
        {
            User u = UserHandler.GetSession();
            if (u.UserRole.RoleName.Equals("Admin"))
            {
                return getAllItemByFilter(filter).Count();
            }
            else if (u.UserRole.RoleName.Equals("Customer"))
            {
                return getItemDeliveryByFilter(filter).Count();
            }
            return -1;
        }
        public static List<ListDelivery> getItemDeliveryByFilter(String filter)
        {
            return ItemHandler.getItemDeliveryByFilter(filter);
        }
        public static List<ListDelivery> getAllItemByFilter(String filter)
        {
            return ItemHandler.getAllItemByFilter(filter);
        }
        public static String updateItem(int id, String name, String note, String room, String status)
        {
            int count = 0;
            if (status.Equals("Pending") || status.Equals("Done"))
            {
                count++;
            }
            else
            {
                return "Status must be Pending or Done only<br />";
            }
            bool test = int.TryParse(room, out int Parsed);
            if (test)
            {
                count++;
            }
            else
            {
                return "Room Field must be numeric<br />";
            }

            if (note != null)
            {
                count++;
            }
            else
            {
                return "Note must be filled!<br />";
            }

            if (name != null)
            {
                count++;
            }
            else
            {
                return "Name must not empty!<br />";
            }

            if (count == 4)
            {
                ItemHandler.updateItem(id, name, note, int.Parse(room), status);
                HttpContext.Current.Response.Redirect("HomePage_admin.aspx");
            }
            return "";
        }
        public static List<ListDelivery> getItemByStatus(String status)
        {
            return ItemHandler.getItemByStatus(status);
        }

        public static List<ListDelivery> getItemDeliveryByStatus(String status)
        {
            return ItemHandler.getItemDeliveryByStatus(status);
        }

    }
}