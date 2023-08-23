using Microsoft.EntityFrameworkCore;
using WebApp1.Model;

namespace WebApp1.data
{
    public class MyDbcontext :DbContext
    {
        public DbSet<Student> Student { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    // base.OnConfiguring(optionsBuilder);
        //   optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2J37TFF\SQLEXPRESS; Initial Catalog=Learning;User Id=sa; password=sa123;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=true", options => options.EnableRetryOnFailure());

        //}
        public MyDbcontext(DbContextOptions <MyDbcontext> options):base (options) { }    

        public DbSet <Employee> Employee { get; set; }
    }
}
