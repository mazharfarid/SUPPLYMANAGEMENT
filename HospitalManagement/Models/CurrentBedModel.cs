using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HospitalManagement.Models
{
    public class CurrentBedModel
    {
        public int CurrentBedID { get; set; }
         
        public int CategoryId { get; set; }
      
        public int SubCategoryId { get; set; }
        public SelectList CatagoryList { get; set; }
        public SelectList SubCatagoryList { get; set; }

        public int BedTypeId { get; set; }
        public bool Status { get; set; }
       
        public int Count { get; set; }
        public string Opex { get; set; }
    }
}