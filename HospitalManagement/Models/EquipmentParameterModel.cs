using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class EquipmentParameterModel
    {
        public int EquipmentParameterId { get; set; }
        public int EquipmentTypeId { get; set; }
        public Nullable<int> AverageLifeTime { get; set; }
    }
}