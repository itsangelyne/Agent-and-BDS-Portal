using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Model;

namespace Agent_and_BDS_Portal.Data
{
    public class CGL_Health_Answer_Services
    {
        private readonly ApplicationDbContext _applicationContext;

        public CGL_Health_Answer_Services(ApplicationDbContext applicationDbContext)
        {
            _applicationContext = applicationDbContext;
        }
        public async Task<List<CGL_Health_Answer>> GetAllHealthAnswerAsync()
        {
            return await _applicationContext.CGL_Health_Answer.ToListAsync();
        }
    }
}
