using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Microsoft.Data.SqlClient;
using static Agent_and_BDS_Portal.Context.ApplicationDbContext;
namespace Agent_and_BDS_Portal.Data
{
    public class ProductionReport_Services
    {
        private readonly ApplicationDbContext _applicationContext;

        public ProductionReport_Services(ApplicationDbContext applicationDbContext)
        {
            _applicationContext = applicationDbContext;
        }
        
        // Method to count rows in tbl_cgl_ProductionMonitoringReport
        public async Task<int> GetProductionMonitoringRowCountAsync()
        {
            return await _applicationContext.tbl_cgl_ProductionMonitoringReport.CountAsync();
        }
    }
}

