using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Model;


namespace Agent_and_BDS_Portal.Data
{
    public class CGL_COC_Services
    {
        private readonly ApplicationDbContext _applicationContext;

        public CGL_COC_Services(ApplicationDbContext applicationDbContext)
        {
            _applicationContext = applicationDbContext;
        }
        public async Task<List<CGL_COC>> GetAllCGL_COCAsync()
        {
            return await _applicationContext.CGL_COC.ToListAsync();
        }
    }
}
