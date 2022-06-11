namespace BasicVersion1.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        { }

        public DbSet<Models.EMPLOYEE> EMPLOYEE { get; set; }
        public DbSet<Models.POSITION> POSITION { get; set; }
        public DbSet<Models.DEPARTMENT> DEPARTMENT { get; set; }
        public DbSet<Models.COMPANY> COMPANY { get; set; }
    }
    
}
