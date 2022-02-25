using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class PlannedEquipmentModel
    {
        public int PlannedEquipmentId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int EquipmentTypeId { get; set; }
        public string Comments { get; set; }
        public Nullable<System.DateTime> DateOfPurchase { get; set; }
        public Nullable<int> Count { get; set; }
    }
}