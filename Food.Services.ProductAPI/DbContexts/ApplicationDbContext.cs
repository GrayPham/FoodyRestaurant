
using Food.Services.ProductAPI.Model;
using Microsoft.EntityFrameworkCore;
namespace Food.Services.ProductAPI.DbContexts
{
    public class ApplicationDbContext : DbContext
    {
        //cto + 2tab
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
        public DbSet<Product> Products { get; set; }
    }
}
