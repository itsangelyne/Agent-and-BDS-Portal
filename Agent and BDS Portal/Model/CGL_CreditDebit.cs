using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Data;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;

namespace Agent_and_BDS_Portal.Model
{
    public class CGL_CreditDebit
    {
        [Key]
        public int ID_CB { get; set; }
        public int ID_Policy_Holder { get; set; }
        public string DCHS_From { get; set; }
        public string DCHS_To { get; set; }
        public DateTime Period_From { get; set; }
        public DateTime Period_To { get; set; }
        public double Gross_Pay { get; set; }
        public double Net_Pay { get; set; }
        public int Total_Application { get; set; }
        public  double Total_Coverage { get; set; }
        public DateTime Submitted_Date { get; set; }
        public string Submitted_By { get; set; }
        public string Receipt { get; set; }

    }
}
