using AbbeyWeb.Model;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace AbbeyWeb.Data
{
    public class ApplicationDbContext:DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options ): base (options)
        {
            
        }
        public DbSet<Category> Category { get; set; }

    }
}
