using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class SubCategoryModel
    {
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string HospitalName { get; set; }
    }
}