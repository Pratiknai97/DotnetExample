using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using WebApp2.Controllers;
using WebApp2.Model;

namespace WebApp2.data
{
    public class Mydbcontext : DbContext
    {
      public DbSet<Product> product { get; set; }
        public DbSet<Employee> employee { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //base.OnConfiguring(optionsBuilder);
        //    optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2J37TFF\SQLEXPRESS; Initial Catalog=Learning;User Id=sa; password=sa123;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=true", options => options.EnableRetryOnFailure());
        //}
        public Mydbcontext(DbContextOptions<Mydbcontext> options) : base(options) { }
    }
}
