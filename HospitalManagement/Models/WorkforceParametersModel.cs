using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class WorkforceParametersModel
    {
        public int WorkforceParamterId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public Nullable<int> CurrentSpecialityId { get; set; }
        public Nullable<int> CurrentSubSpecialityId { get; set; }
        public Nullable<int> GradeId { get; set; }
        public string Gender { get; set; }
        public Nullable<double> AttritionRate { get; set; }
        public Nullable<double> AbsentismRate { get; set; }
        public Nullable<int> RetirementAge { get; set; }
        public Nullable<int> FTEPerDayHours { get; set; }
    }
}