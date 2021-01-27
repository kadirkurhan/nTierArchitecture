using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using myApiProject.DataAccess.Concrete.EntityFrameworkCore.Mapping;
using myApiProject.Entities.Concrete;

namespace myApiProject.DataAccess.Concrete.EntityFrameworkCore.Context
{
    public class JwtContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=(localdb)\\mssqllocaldb; database=JwtDb; user id=sa; password=1;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AppUserMap());
            modelBuilder.ApplyConfiguration(new AppRoleMap());
            modelBuilder.ApplyConfiguration(new AppUserRoleMap());
            modelBuilder.ApplyConfiguration(new ProductMap());
          
        }

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<AppRole> AppRoles { get; set; }
        public DbSet<AppUserRole> AppUserRoles { get; set; }
        public DbSet<Product> Products { get; set; }
    }
}
