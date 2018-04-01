using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Preselime.Models;
using Preselime.Models.Shipment;
using Domain;

namespace Preselime.Builders
{
    public static class ShipmentBuilder
    {
        public static ShipmentModel GetShipmentList(preselimeEntities db) {
            ShipmentModel model = new ShipmentModel();
            model.ShipmentListModel = new List<ShipmentListModel>();
            model.ShipmentListModel = db.Shipments.Select(m => new ShipmentListModel() {ShipId = m.ShipId, DestinationA = m.DestinationA, DestinationB = m.DestinationB, Title = m.Title, DateFrom = m.DateFrom, DateTo = m.DateTo, DateStartBid = m.DateStartBid, DateEndBid = m.DateEndBid}).ToList();
            foreach (var item in model.ShipmentListModel)
            {
                TimeSpan diff = ((DateTime)item.DateEndBid).Subtract((DateTime)item.DateStartBid);
                String days = diff.Days + "d ";
                String hours = diff.Hours != 0 ? diff.Hours.ToString() + "h " : "";
                String minutes = diff.Minutes != 0 ? diff.Minutes.ToString() + "m ":"";
                item.AuctionLenght = days + hours + minutes;
            }
            return model;
        }


    }
}