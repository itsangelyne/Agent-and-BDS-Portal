using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Data;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;

namespace Agent_and_BDS_Portal.Model
{
    public class CGL_Receipted
    {
        [Key]
        public int ID_CB { get; set; }
        public int ID_Policy_Holder { get; set; }
        public string DCHS_From { get; set; }
        public string DCHS_To { get; set; }
        public DateTime Period_From { get; set; }
        public DateTime Period_To { get; set; }
        public decimal Gross_Pay { get; set; }
        public decimal Net_Pay { get; set; }
    }
}
