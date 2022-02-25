using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class CurrentEquipmentModel
    {
        public int CurrentEquipmentId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string EquipmentTypeId { get; set; }
        public int DailyOperatingHours { get; set; }
        public int OperationalHoursPerDay { get; set; }
        public int Downtime { get; set; }
        public System.DateTime DateofPurchase { get; set; }
        public Nullable<double> Price { get; set; }
        public string Opex { get; set; }
    }
}