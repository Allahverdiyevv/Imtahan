using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace WebApplication1.Models
{
    public class DataContext :IdentityDbContext
    {
      

        public DataContext(DbContextOptions<DataContext> options) :base(options) { }
       
        public DbSet<AppBay> AppBays { get; set; }
        public DbSet<AppUser> AppUsers { get; set; }
    }
}
