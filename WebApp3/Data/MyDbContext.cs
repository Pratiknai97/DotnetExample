using Microsoft.EntityFrameworkCore;
using WebApp3.Model;

namespace WebApp3.Data
{
    public class MyDbContext : DbContext
    {
        public DbSet<Student> Student { get; set; }

        public MyDbContext(DbContextOptions<MyDbContext>options) : base(options) { }
    }
}
