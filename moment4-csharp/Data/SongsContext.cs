using Microsoft.EntityFrameworkCore;
using moment4_csharp.Models;

namespace moment4_csharp.Data
{
    public class SongsContext : DbContext
    {
        public SongsContext(DbContextOptions<SongsContext> options) : base(options) 
        { }

        public DbSet<Songs> Songs { get; set; }
    }
}
