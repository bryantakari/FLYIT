using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using TugasSE.Repository;
using TugasSE.Model;
using TugasSE.Factory;

namespace TugasSE.Handler
{
    public class ItemHandler
    {
        public static List<ListDelivery> getItemByUser()
        {
            return ItemRepo.getItemWithUser(UserFactory.GetSession());
        }
        public static List<ListDelivery> getAllItem()
        {
            return ItemRepo.getAllItem();
        }
        public static void addItem(String name,String note,int room)
        {
            ItemRepo.AddItem(name,note,room);
        }
        public static List<ListDelivery> getItemByStatus(String status)
        {
            return ItemRepo.getItemByStatus(status);
        }
        public static List<ListDelivery> getItemDeliveryByStatus(String status)
        {
            return ItemRepo.getItemDeliveryByStatus(status);
        }
        public static void deleteItem(int id)
        {
            ItemRepo.deleteItem(id);
        }
        
        public static List<ListDelivery> getItemDeliveryByFilter(String filter)
        {
            return ItemRepo.getItemDeliveryByFilter(filter);
        }
        public static List<ListDelivery> getAllItemByFilter(String filter)
        {
            return ItemRepo.getAllItemByFilter(filter);
        }
        public static void updateItem(int id,String name,String note,int room,String status)
        {
            ItemRepo.updateItem(id, name, note, room, status);
        }
        public static ListDelivery getItemById(int itemid)
        {
            return ItemRepo.getItemById(itemid);
        }
    }
}