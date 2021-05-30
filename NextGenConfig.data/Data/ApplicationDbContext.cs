using Microsoft.EntityFrameworkCore;
using NextGenConfig.entities.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NextGenConfig.data.Data
{
    public class ApplicationDbContext : DbContext
    {
        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //        optionsBuilder.UseMySql
        //    //            (@"server=localhost; port=3306; database=testEntity; user=root; password=lara1234$; Persist Security Info=False; Connect Timeout=300");
        //}
        //public ApplicationDbContext()
        //    :base()
        //{

        //}
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SystemProfile> SystemProfiles { get; set; }
    }
}
