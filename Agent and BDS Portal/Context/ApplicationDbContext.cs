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

    }

}