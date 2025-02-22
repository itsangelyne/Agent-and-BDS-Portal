using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Model;
namespace Agent_and_BDS_Portal.Data
{
    public class CGL_Insurance_Status_Services
    {
        private readonly ApplicationDbContext _applicationContext;

        public CGL_Insurance_Status_Services(ApplicationDbContext applicationDbContext)
        {
            _applicationContext = applicationDbContext;
        }
        public async Task<List<CGL_Insured_Status>> GetAllCGL_Insurance_StatusAsync()
        {
            return await _applicationContext.CGL_Insured_Status.ToListAsync();
        }
    }
}
