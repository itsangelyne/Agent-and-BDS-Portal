using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Model;
namespace Agent_and_BDS_Portal.Data
{
    public class CGL_Substandard_Rating_Services
    {
       
            private readonly ApplicationDbContext _applicationContext;

            public CGL_Substandard_Rating_Services(ApplicationDbContext applicationDbContext)
            {
                _applicationContext = applicationDbContext;
            }
            public async Task<List<CGL_Substandard_Rating>> GetAllSubstandardRatingAsync()
            {
                return await _applicationContext.CGL_Substandard_Rating.ToListAsync();
            }
        }
}
