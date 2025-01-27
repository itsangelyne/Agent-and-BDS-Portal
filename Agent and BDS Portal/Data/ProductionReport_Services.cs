using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Model;
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
        public async Task<List<Cgl_ProductionReport>>GetAllProductionMonitoringReportsAsync()
        {
            return await _applicationContext.tbl_cgl_ProductionMonitoringReport.ToListAsync();
        }
        public async Task<int> GetProductionMonitoringRowCountAsync()
        {
            return await _applicationContext.tbl_cgl_ProductionMonitoringReport.CountAsync();
        }
    }
}

