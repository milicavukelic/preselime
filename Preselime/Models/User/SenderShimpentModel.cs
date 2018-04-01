using Preselime.Models.Shared;
using Preselime.Models.Shipment;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Preselime.Models.User
{
    public class SenderShipmentModel
    {
        public IList<SubcategoryModel> SubcategoryList { get; set; }
        public int SubcategoryId { get; set; }
        public IList<ItemList> PickupFloorList { get; set; }
        public int SelectedPickupFloor { get; set; }
        public IList<ItemList> DeliveryFloorList { get; set; }
        public int SelectedDeliveryFloor { get; set; }
        public int PickupElevator { get; set; }
        public int DeliveryElevator { get; set; }
        public String Title { get; set; }
        public DateTime DateFrom { get; set; }
        public String DestinationA { get; set; }
        public DateTime DateTo { get; set; }
        public String DestinationB { get; set; }
    }
}