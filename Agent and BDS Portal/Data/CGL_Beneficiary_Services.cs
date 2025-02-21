using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Model;
namespace Agent_and_BDS_Portal.Data
{
    public class CGL_Beneficiary_Services
    {
            private readonly ApplicationDbContext _applicationContext;

            public CGL_Beneficiary_Services(ApplicationDbContext applicationDbContext)
            {
                _applicationContext = applicationDbContext;
            }
            public async Task<List<CGL_Beneficiary>> GetAllCGL_BeneficiaryAsync()
            {
                return await _applicationContext.CGL_Beneficiary.ToListAsync();
            }
        }
}
