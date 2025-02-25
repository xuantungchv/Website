﻿using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WebApi.Responsitory.Entity;

namespace WebApi.Responsitory
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
    }
}
