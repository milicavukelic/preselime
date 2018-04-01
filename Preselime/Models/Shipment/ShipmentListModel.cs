using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Preselime.Models.Shipment
{
    public class ShipmentListModel
    {
        public int ShipId { get; set; }
        public String Title { get; set; }
        public DateTime? DateFrom { get; set; }
        public DateTime? DateTo { get; set; }
        public String DestinationA { get; set; }
        public String DestinationB { get; set; }
        public String AuctionLenght { get; set; }
        public DateTime? DateStartBid { get; set; }
        public DateTime? DateEndBid { get; set; }

    }
}