using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class PlannedBedsModel
    {
        public int PlannedBedId { get; set; }
        public int SubCategoryId { get; set; }
        public int BedTypeId { get; set; }
        public Nullable<System.DateTime> PlannedYearofPurchase { get; set; }
        public Nullable<int> Count { get; set; }
    }
}