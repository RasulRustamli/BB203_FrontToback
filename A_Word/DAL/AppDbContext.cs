using A_Word.Models;
using Microsoft.EntityFrameworkCore;

namespace A_Word.DAL
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> opt):base(opt)
        {

        }
       public DbSet<Service> Services { get; set; }
    }
}
