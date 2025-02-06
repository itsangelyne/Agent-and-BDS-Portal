using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Model;

namespace Agent_and_BDS_Portal.Data
{
    public class CGL_Policy_Holder_Services
    {
            private readonly ApplicationDbContext _applicationContext;

            public CGL_Policy_Holder_Services(ApplicationDbContext applicationDbContext)
            {
                _applicationContext = applicationDbContext;
            }
        public async Task<List<CGL_Policy_Holder>> GetAllPolicyHolderAsync()
        {
            return await _applicationContext.CGL_Policy_Holder.ToListAsync();
        }

    }
}
