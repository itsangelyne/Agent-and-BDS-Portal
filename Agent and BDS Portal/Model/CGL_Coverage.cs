using System.ComponentModel.DataAnnotations;
using Agent_and_BDS_Portal.Data;
using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;
namespace Agent_and_BDS_Portal.Model
{
    public class CGL_Coverage
    {
          [Key]
            public int ID_Coverage { get; set; }

            public int ID_Insured { get; set; }
            public double Amount_Of_Insured { get; set; }
            public DateTime Effective_Date { get; set; }
            public DateTime Termination_Date { get; set; }
            public string Term_Of_Loan { get; set; }
            public int? Payment_Duration { get; set; }

            public string Mode_Of_Payment { get; set; }
            public double Premium_Orig { get; set; }
            public double Premium { get; set; }
            public string? Rider { get; set; }

        }
    }

