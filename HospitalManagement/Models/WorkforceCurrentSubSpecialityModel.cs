using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class WorkforceCurrentSubSpecialityModel
    {
        public int CurrentSubSpecialityId { get; set; }
        public Nullable<int> CurrentSpecialityId { get; set; }
        public string CurrentSubSpeciality { get; set; }
    }
}