using BlazorWebAndMAUI.Shared.Models;
using BlazorWebAndMAUI.WebAssemblyWebAPI.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace BlazorWebAndMAUI.WebAssemblyWebAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MnenjeController : Controller
    {
        private readonly NTKDBContext _dbContext;

        public MnenjeController(NTKDBContext dbContext)
        {
            _dbContext = dbContext;

            _dbContext.Database.EnsureCreated();
        }

        [HttpGet]
        public async Task<List<Mnenje>> GetAllMnenje()
        {
            return await _dbContext.Mnenjes.ToListAsync();
        }

        [HttpPost]
        public async Task AddMnenje(Mnenje mnenje)
        {
            _dbContext.Add(mnenje);
            await _dbContext.SaveChangesAsync();
        }
    }
}