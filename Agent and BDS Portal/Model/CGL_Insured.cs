using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Data;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;

namespace Agent_and_BDS_Portal.Model
{
    public class CGL_Insured
    {
        [Key]
        public int ID_Insured { get; set; }
        
        public string DCHS { get; set; }
        public int ID_Policy_Holder { get; set; }
        public string First_Name { get; set; }
        public string? Middle_Name { get; set; }
        public string Last_Name { get; set; }
        public string? Suffix { get; set; }
        public string Civil_Status { get; set; }
        public string Gender { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }

        public string Address { get; set; }
        public string Contact_Number { get; set; }
        public string Email_Address { get; set; }

        public int Age { get; set; }
        public DateTime Date_Of_Birth { get; set; }
        public string Place_Of_Birth { get; set; }
        public string Nationality { get; set; }
        public string TIN_SSS_GSIS_NO { get; set; }

        public string Source_Of_Funds { get; set; }
        public string Nature_of_Self_Employment_Business { get; set; }
        public string Address_Of_Business_or_Employer { get; set; }

        public string Occupation_And_Livelihood { get; set; }

        public string? Pregnant { get; set; }
        public string? How_Many_Months { get; set; }
        public string? Image { get; set; }

        public string? Type { get; set; }
    }
}

