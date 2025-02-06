using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Data;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;
namespace Agent_and_BDS_Portal.Model
{
    public class CGL_Policy_Holder
    {
        [Key]
        public int ID_Policy_Holder { get; set; }
        public string Policy_Holder_Name { get; set; }
        public string Master_Polno { get; set; }
        public string Manager { get; set; }
        public string Bank_Address { get; set; }
        public string? Bank_Level { get; set; }
        public string? Bank_Status { get; set; }
    }
}
