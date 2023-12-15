using Apprisal.web.App_mvc_.Data;
using Microsoft.EntityFrameworkCore;

namespace Apprisal.web.App_mvc_.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            :base(options)
        {

        }
        public DbSet<ApprisalEnitity> Form { get; set; } = default!;
    }
}
