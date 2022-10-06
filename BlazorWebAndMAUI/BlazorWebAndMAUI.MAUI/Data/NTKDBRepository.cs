using BlazorWebAndMAUI.Shared.Data;
using BlazorWebAndMAUI.Shared.Models;
using SQLite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAndMAUI.MAUI.Data
{
    public class NTKDBRepository : INTKDBRepository
    {
        string _dbPath;
        private SQLiteAsyncConnection conn;

        private async Task Init()
        {
            if (conn != null)
                return;

            conn = new SQLiteAsyncConnection(_dbPath);
            await conn.CreateTableAsync<Mnenje>();
        }

        public NTKDBRepository(string dbPath)
        {
            _dbPath = dbPath;
        }

        public async Task AddMnenje(Mnenje mnenje)
        {
            await Init();

            await conn.InsertAsync(mnenje);
        }

        public async Task<List<Mnenje>> GetAllMnenje()
        {
            await Init();

            return await conn.Table<Mnenje>().ToListAsync();
        }
    }
}
