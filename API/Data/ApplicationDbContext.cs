using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace API.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions options) : base(options)
        {
            
        }

        public DbSet<AppUser> Users { get; set; }


        // protected override void OnModelCreating(ModelBuilder modelBuilder)
        // {
        //     base.OnModelCreating(modelBuilder);
        //     modelBuilder.Entity<AppUser>().HasData(
        //         new AppUser
        //         {
        //             Id = 1,
        //             UserName = "Tom",
                   
        //         },
        //         new AppUser
        //         {
        //             Id = 2,
        //             UserName = "Bob",
                   
        //         },
        //         new AppUser
        //         {
        //             Id = 3,
        //             UserName = "Ruth",
                   
        //         });
        // }
        
    }
}