using Microsoft.EntityFrameworkCore;
using BasicVersion1.Models;
using BasicVersion1.EfCore.Configuration;

namespace BasicVersion1.EfCore
{
    public class WorkShopDbContext : DbContext
    {

        public WorkShopDbContext(DbContextOptions<WorkShopDbContext> options) : base(options) { }
        public DbSet<EMPLOYEE> EMPLOYEE { get; set; }
        public DbSet<DEPARTMENT> DEPARTMENT { get; set; }
        public DbSet<POSITION> POSITION { get; set; }
        public DbSet<COMPANY> COMPANY { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(EMPLOYEEConfiguration).Assembly);
        }

    }
}


