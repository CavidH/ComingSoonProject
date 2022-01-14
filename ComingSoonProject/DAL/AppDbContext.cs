using ComingSoonProject.Models;
using Microsoft.EntityFrameworkCore;

namespace ComingSoonProject.DAL
{
    public class AppDbContext :DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }


        public DbSet<Setting> Settings { get; set; }
    }
}
