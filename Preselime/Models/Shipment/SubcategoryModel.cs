using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Preselime.Models.Shipment
{
    public class SubcategoryModel
    {
        public int Id { get; set; }
        public int CategoryId { get; set; }
        public String SubcategoryName {get; set;}
    }
}