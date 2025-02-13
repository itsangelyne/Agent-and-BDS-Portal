using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Model;

namespace Agent_and_BDS_Portal.Data
{
    public class CGL_Receipted_Services
    {
        private readonly ApplicationDbContext _applicationContext;

        public CGL_Receipted_Services(ApplicationDbContext applicationDbContext)
        {
            _applicationContext = applicationDbContext;
        }
        public async Task<List<CGL_Receipted>> GetAllCGL_Receiptedsync()
        {
            return await _applicationContext.CGL_Receipted.ToListAsync();
        }
    }
}
