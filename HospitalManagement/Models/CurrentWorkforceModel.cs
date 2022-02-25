using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HospitalManagement.Models
{
    public class CurrentWorkforceModel
    {
        public int CurrentWorkforceId { get; set; }
        public int CategoryId { get; set; }
        public int SubCategoryId { get; set; }
        public int EmployeeId { get; set; }
        public string EmployeeName { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public Nullable<System.DateTime> DateofBirth { get; set; }
        public Nullable<System.DateTime> DateofHire { get; set; }
        public Nullable<int> CurrentJobTypeId { get; set; }
        public Nullable<int> CurrentSpecialityId { get; set; }
        public Nullable<int> CurrentSubSpecialityId { get; set; }
        public Nullable<int> CertifiedJobTypeId { get; set; }
        public Nullable<int> CertifiedSpecialityId { get; set; }
        public Nullable<int> CertifiedSubSpecialityId { get; set; }
        public Nullable<int> GradeId { get; set; }
        public Nullable<bool> PermanentStatus { get; set; }
        public string Program { get; set; }
        public Nullable<System.DateTime> ProgramStartDate { get; set; }
        public Nullable<double> YearlySalary { get; set; }
        public Nullable<int> NumberOfHoursPerDay { get; set; }
    }
}