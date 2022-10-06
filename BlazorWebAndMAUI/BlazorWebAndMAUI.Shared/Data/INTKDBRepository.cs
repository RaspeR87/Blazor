using BlazorWebAndMAUI.Shared.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebAndMAUI.Shared.Data
{
    public interface INTKDBRepository
    {
        public Task AddMnenje(Mnenje mnenje);

        public Task<List<Mnenje>> GetAllMnenje();
    }
}
