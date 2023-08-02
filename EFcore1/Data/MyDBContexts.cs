using EFcore1.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcore1.Data
{
    internal class MyDBContexts:DbContext
    {
        public DbSet<Student> Student { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-2J37TFF\SQLEXPRESS; Initial Catalog=Learning;User Id=sa; password=sa123;MultipleActiveResultSets=true;Encrypt=false;TrustServerCertificate=true", options => options.EnableRetryOnFailure());
        }
    }
}
