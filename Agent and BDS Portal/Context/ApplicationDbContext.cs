using Agent_and_BDS_Portal.Pages;
using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Model;
using Agent_and_BDS_Portal.Data;
namespace Agent_and_BDS_Portal.Context
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
              : base(options)
        {
        }

        public DbSet<User> CGL_Bank_Account_Information { get; set; }
        //public DbSet<Cgl_submittedReport> tbl_cgl_SubmittedReport { get; set; }
        //public DbSet<Cgl_ProductionReport> tbl_cgl_ProductionMonitoringReport { get; set; }


        public DbSet<CGL_CreditDebit> CGL_CreditDebit { get; set; }
        public DbSet<CGL_Policy_Holder> CGL_Policy_Holder { get; set; }
        public DbSet<CGL_Particulars> CGL_Particulars { get; set; }
        public DbSet<CGL_Insured> CGL_INSURED { get; set; }
        public DbSet<CGL_Receipted> CGL_Receipted { get; set; }
        public DbSet<CGL_Coverage> CGL_Coverage { get; set; }

        public DbSet<CGL_Health_Question> CGL_Health_Question { get; set; }
        public DbSet<CGL_Substandard_Rating> CGL_Substandard_Rating { get; set; }
        public DbSet<CGL_Health_Answer> CGL_Health_Answer { get; set; }

        public DbSet<CGL_COC> CGL_COC { get; set; }
        public DbSet<CGL_Beneficiary> CGL_Beneficiary { get; set; }
        public DbSet<CGL_Insured_Status> CGL_Insured_Status { get; set; }
        public DbSet<CGL_Image> CGL_Image { get; set; }

       

        public DbSet<CGL_Coverage> CGL_Coverage { get; set; }

    }

}