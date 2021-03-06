//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Domain
{
    using System;
    using System.Collections.Generic;
    
    public partial class Shipment
    {
        public Shipment()
        {
            this.ShipMoveTypes = new HashSet<ShipMoveType>();
        }
    
        public int ShipId { get; set; }
        public string UserId { get; set; }
        public Nullable<int> CategoryId { get; set; }
        public Nullable<int> SubcategoryId { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> DateFrom { get; set; }
        public Nullable<System.DateTime> DateTo { get; set; }
        public string DestinationA { get; set; }
        public string DestinationAddressA { get; set; }
        public string DestinationB { get; set; }
        public string DestinationAddressB { get; set; }
        public Nullable<System.DateTime> DateStartBid { get; set; }
        public Nullable<System.DateTime> DateEndBid { get; set; }
        public Nullable<decimal> Budget { get; set; }
        public string Comment { get; set; }
    
        public virtual Category Category { get; set; }
        public virtual ICollection<ShipMoveType> ShipMoveTypes { get; set; }
    }
}
