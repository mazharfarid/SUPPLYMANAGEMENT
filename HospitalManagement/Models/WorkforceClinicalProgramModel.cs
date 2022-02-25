using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class WorkforceClinicalProgramModel
    {
        public int ClinicalProgramId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public string ProgramName { get; set; }
        public Nullable<int> Duration { get; set; }
    }
}