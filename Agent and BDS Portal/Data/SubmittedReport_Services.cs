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
       
    }
}
