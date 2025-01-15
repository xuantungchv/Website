using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Ifrastructure.Responsitory.Entity;

namespace Ifrastructure.Responsitory
{
    public class WebappContext : IdentityDbContext<Users>
    {
        public DbSet<Users> Users {get;set;}
        public DbSet<ClassInfo> ClassInfos { get; set; }

        public WebappContext(DbContextOptions<WebappContext> options) :base(options)
        { 
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }
        //protected override void OnModelCreating(ModelBuilder builder)
        //{
        //    base.OnModelCreating(builder);
        //}
        //public override int SaveChanges()
        //{

        //    return base.SaveChanges();  
        //}
    }
}
