using Preselime.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Domain;
using Preselime.Models.Shipment;
using Preselime.Models.Shared;

namespace Preselime.Builders
{
    public static class SenderDashboardBuilder
    {
        public static SenderShipmentModel GetSenderShipmentModel(preselimeEntities db)
        {
            SenderShipmentModel model = new SenderShipmentModel();
            model.SubcategoryList = db.Subcategories.Where(c => c.CategoryId == 1).Select(c => new SubcategoryModel() { Id = c.Id, CategoryId = c.CategoryId, SubcategoryName = c.Name }).ToList();
            model.PickupFloorList = new List<ItemList>();
            ItemList item = new ItemList();
            item.Id = 0;
            item.Name = "--Izaberi--";
            model.PickupFloorList.Add(item);
            item = new ItemList();
            item.Id = 1;
            item.Name = "1";
            model.PickupFloorList.Add(item);
            item = new ItemList();
            item.Id = 2;
            item.Name = "2";
            model.PickupFloorList.Add(item);
            item = new ItemList();
            item.Id = 3;
            item.Name = "3+";
            model.PickupFloorList.Add(item);
            model.DeliveryFloorList = new List<ItemList>();
            item = new ItemList();
            item.Id = 0;
            item.Name = "--Izaberi--";
            model.DeliveryFloorList.Add(item);
            item = new ItemList();
            item.Id = 1;
            item.Name = "1";
            model.DeliveryFloorList.Add(item);
            item = new ItemList();
            item.Id = 2;
            item.Name = "2";
            model.DeliveryFloorList.Add(item);
            item = new ItemList();
            item.Id = 3;
            item.Name = "3+";
            model.DeliveryFloorList.Add(item);
            return model;
        }
    }
}