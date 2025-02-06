using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Model;
namespace Agent_and_BDS_Portal.Data
{
    public class CGL_Insured_Services
    {
        private readonly ApplicationDbContext _applicationContext;

        public CGL_Insured_Services(ApplicationDbContext applicationDbContext)
        {
            _applicationContext = applicationDbContext;
        }
        public async Task<List<CGL_Insured>> GetAllCGL_INSUREDAsync()
        {
            return await _applicationContext.CGL_INSURED.ToListAsync();
        }
    }
}
