using BlazorTest.Shared.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorTest.Server.Context
{
    public class AppDbContext : DbContext
    {

        public AppDbContext(DbContextOptions options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().
                HasOne(u => u.Role).
                WithMany(x => x.Users).
                HasForeignKey(x => x.RoleId);
        }

        public DbSet<Role> Roles { get; set; }
        public DbSet<User> Users { get; set; }
    }


}
