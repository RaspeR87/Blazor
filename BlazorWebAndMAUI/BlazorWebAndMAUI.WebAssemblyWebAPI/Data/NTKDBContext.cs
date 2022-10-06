using BlazorWebAndMAUI.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace BlazorWebAndMAUI.WebAssemblyWebAPI.Data
{
    public class NTKDBContext : DbContext
    {
        public NTKDBContext()
        {
        }

        public NTKDBContext(DbContextOptions<NTKDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Mnenje> Mnenjes { get; set; }
    }
}
