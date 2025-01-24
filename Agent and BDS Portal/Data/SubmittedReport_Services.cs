using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
namespace Agent_and_BDS_Portal.Data
{
    public class SubmittedReport_Services
    {
        private readonly ApplicationDbContext _applicationContext;

        public SubmittedReport_Services(ApplicationDbContext applicationDbContext)
        {
            _applicationContext = applicationDbContext;
        }
        // Get All Submitted Reports
        public async Task<List<Cgl_submittedReport>> GetAllSubmittedReportsAsync()
        {
            return await _applicationContext.tbl_cgl_SubmittedReport.ToListAsync();
        }
        // Get Row Count for Submitted Reports
        public async Task<int> GetSubmittedReportsRowCountAsync()
        {
            return await _applicationContext.tbl_cgl_SubmittedReport.CountAsync();
        }

    }
}
