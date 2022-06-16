using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

               
        public DbSet<EMPLOYEE> EMPLOYEEs { get; set; }
        public DbSet<POSITION> POSITIONs { get; set; }
        public DbSet<DEPARTMENT> DEPARTMENTs { get; set; }
        public DbSet<COMPANY> COMPANYs{ get; set; }

    }
}
