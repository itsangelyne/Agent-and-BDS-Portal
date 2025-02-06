using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Model;
namespace Agent_and_BDS_Portal.Data
{
    public class CGL_CreditDebit_Services
    {
        private readonly ApplicationDbContext _applicationContext;

        public CGL_CreditDebit_Services(ApplicationDbContext applicationDbContext)
        {
            _applicationContext = applicationDbContext;
        }
        public async Task<List<CGL_CreditDebit>> GetAllCGL_CreditDebitAsync()
        {
            return await _applicationContext.CGL_CreditDebit.ToListAsync();
        }

    }
}
