using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasSE.Model;
using TugasSE.Factory;
namespace TugasSE.Repository
{
    public class ItemRepo
    {
        public static List<ListDelivery> getItemWithUser(User u)
        {
            DatabaseEntities db = new DatabaseEntities();
            return (from x in db.ListDeliveries where x.Username == u.Username select x).ToList();
        }

        public static List<ListDelivery> getAllItem()
        {
            DatabaseEntities db = new DatabaseEntities();
            return (from x in db.ListDeliveries select x).ToList(); 
        }
        
        public static void deleteItem(int id)
        {
            DatabaseEntities db = new DatabaseEntities();
            ListDelivery ld = (from x in db.ListDeliveries where x.ItemId == id select x).FirstOrDefault();
            Item i = ld.Item;
            db.ListDeliveries.Remove(ld);
            db.Items.Remove(i);
            db.SaveChanges();
        }

        public static void updateItem(int id,String name,String note)
        {
            DatabaseEntities db = new DatabaseEntities();
            ListDelivery ld = (from x in db.ListDeliveries where x.ItemId == id select x).FirstOrDefault();
            ld.Item.ItemName = name;
        }
        public static void AddItem(String name,String note,int room)
        {
            DatabaseEntities db = new DatabaseEntities();
            Item t = ItemFactory.createItem(name, note);
            db.Items.Add(t);
            db.SaveChanges();
            db.Items.Find(t.ItemId);
            ListDelivery ld = ItemFactory.createList(name,note,UserRepo.GetUserByRoom(room,UserFactory.GetSession().ApartementId),t.ItemId );
            db.ListDeliveries.Add(ld);
            db.SaveChanges();
        }
        public static void updateItem(int id,String name,String note,int room,String status)
        {
            DatabaseEntities db = new DatabaseEntities();
            ListDelivery ld = (from x in db.ListDeliveries where x.ItemId == id select x).FirstOrDefault();
            User u = (from x in db.Users where x.RoomNumber == room select x).FirstOrDefault();
            ld.Status = status;
            ld.Username = u.Username;
            Item i = (from x in db.Items where x.ItemId == ld.ItemId select x).FirstOrDefault();
            i.ItemName = name;
            i.ItemNote = note;
            db.SaveChanges();
        }

        public static ListDelivery getItemById(int itemid)
        {
            DatabaseEntities db = new DatabaseEntities();
            return (from x in db.ListDeliveries where x.ItemId == itemid select x).FirstOrDefault();
        }
        public static List<ListDelivery> getItemDeliveryByFilter(String filter)
        {
            DatabaseEntities db = new DatabaseEntities();
            User u = UserFactory.GetSession();
            return (from x in db.ListDeliveries where x.Item.ItemName.Contains(filter) && x.Username == u.Username select x).ToList();
        }
        public static List<ListDelivery> getItemDeliveryByStatus(String status)
        {
            DatabaseEntities db = new DatabaseEntities();
            User u = UserFactory.GetSession();
            List<ListDelivery> d = (from x in db.ListDeliveries where x.Status == status && x.Username == u.Username select x).ToList();
            System.Diagnostics.Debug.WriteLine("test: "+d.Count);
            return (from x in db.ListDeliveries where x.Status == status && x.Username == u.Username select x).ToList();
        }
        public static List<ListDelivery> getItemByStatus(String status)
        {
            DatabaseEntities db = new DatabaseEntities();
            return (from x in db.ListDeliveries where x.Status == status select x).ToList();
        }

        public static List<ListDelivery> getAllItemByFilter(String filter)
        {
            
            DatabaseEntities db = new DatabaseEntities();
            return (from x in db.ListDeliveries where x.Item.ItemName.Contains(filter) select x).ToList();
        }
    }
}