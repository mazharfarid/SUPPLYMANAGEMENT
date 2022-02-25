using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class BedsParametersModel
    {
        public int BedParameterId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int BedTypeId { get; set; }
        public Nullable<double> DecommissionRate { get; set; }
        public Nullable<double> ClosureRate { get; set; }
        public Nullable<double> PriceOfBed { get; set; }
    }
}