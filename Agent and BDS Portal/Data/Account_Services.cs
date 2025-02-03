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
            return await _applicationContext.tbl_Account.ToListAsync();
        }

       

        // Add New Account
       public async Task<bool> AddNewAccountAsync(User account)
        {
            try
            {
                await _applicationContext.tbl_Account.AddAsync(account);
                await _applicationContext.SaveChangesAsync();
                return true;
            }
            catch
            {
                return false;
            }
        }

        // Update an Account
        public async Task UpdateAccountAsync(User account)
        {
            _applicationContext.tbl_Account.Update(account);
            await _applicationContext.SaveChangesAsync();
        }
    }
}
