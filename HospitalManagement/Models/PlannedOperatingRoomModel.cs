using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class PlannedOperatingRoomModel
    {
        public int PlannedOperatingRoomId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public Nullable<System.DateTime> DateOfEstablishment { get; set; }
        public Nullable<int> Count { get; set; }
    }
}