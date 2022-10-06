using BlazorWebAndMAUI.Shared.Data;
using BlazorWebAndMAUI.Shared.Models;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAndMAUI.Web.Data
{
    public class NTKDBRepository : INTKDBRepository
    {
        private readonly NTKDBContext _dbContext;

        public NTKDBRepository(NTKDBContext dbContext) 
        {
            _dbContext = dbContext;

            _dbContext.Database.EnsureCreated();
        }

        public async Task AddMnenje(Mnenje mnenje)
        {
            _dbContext.Add(mnenje);
            await _dbContext.SaveChangesAsync();
        }

        public async Task<List<Mnenje>> GetAllMnenje()
        {
            return await _dbContext.Mnenjes.ToListAsync();
        }
    }
}
