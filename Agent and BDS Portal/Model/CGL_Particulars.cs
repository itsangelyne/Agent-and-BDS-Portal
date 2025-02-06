using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Data;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;
namespace Agent_and_BDS_Portal.Model
{
    public class CGL_Particulars
    {
        [Key]
        public int ID_Particulars {get; set;}
        public int ID_CB { get; set; }
        public string? Particulars { get; set; }
        public float? Amount { get; set; }
        public string? ADD_LESS { get; set; }
    }
}
