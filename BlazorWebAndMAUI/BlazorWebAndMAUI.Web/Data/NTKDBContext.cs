using BlazorWebAndMAUI.Shared.Models;
using Microsoft.EntityFrameworkCore;
using System.Reflection.Metadata;
using System.Xml.Xsl;

namespace BlazorWebAndMAUI.Web.Data
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
