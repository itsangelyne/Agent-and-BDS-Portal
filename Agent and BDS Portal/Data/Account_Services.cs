using Microsoft.EntityFrameworkCore;
using Agent_and_BDS_Portal.Context;
using Agent_and_BDS_Portal.Model;

namespace Agent_and_BDS_Portal.Data
{
    public class Account_Services
    {
        private readonly ApplicationDbContext _applicationContext;

        public Account_Services(ApplicationDbContext applicationDbContext)
        {
            _applicationContext = applicationDbContext;
        }

        // Get All Account List
        public async Task<List<User>> GetAllAccountsAsync()
        {
            return await _applicationContext.CGL_Bank_Account_Information.ToListAsync();
        }


        // Add New Account - nasa note codes
    }   
}
