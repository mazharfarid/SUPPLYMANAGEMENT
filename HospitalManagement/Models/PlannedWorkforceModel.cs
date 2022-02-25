using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class PlannedWorkforceModel
    {
        public int PlannedWorkforceId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public Nullable<int> CurrentSpecialityId { get; set; }
        public Nullable<int> CertifiedSpecialityId { get; set; }
        public Nullable<int> CertifiedSubSpecialityId { get; set; }
        public Nullable<int> GradeId { get; set; }
        public Nullable<System.DateTime> YearOfJoining { get; set; }
        public Nullable<int> Count { get; set; }
    }
}