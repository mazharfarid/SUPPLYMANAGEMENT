using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class CurrentOperatingRoomModel
    {
        public int OperatingRoomRecordId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public Nullable<int> OperatingRoomId { get; set; }
        public Nullable<int> DailyOperatingHours { get; set; }
        public Nullable<int> OperationalDaysPerWeek { get; set; }
        public Nullable<int> DownTime { get; set; }
        public Nullable<double> Price { get; set; }
        public string Opex { get; set; }
    }
}