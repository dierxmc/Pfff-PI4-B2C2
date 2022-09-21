using Microsoft.EntityFrameworkCore;
using NuGet.Protocol.Plugins;
using Pfff_PI4_B2C2.Models;

namespace Pfff_PI4_B2C2.Areas.Identity.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> contextOptions) : base(contextOptions)
        {

        }
        public DbSet<Camera> Camera { get; set; }
    }
}
