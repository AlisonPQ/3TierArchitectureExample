namespace Layering.DataSource.SQL.DataContext
{
    using Layering.DataSource.SQL.Entities;
    using Microsoft.EntityFrameworkCore;

    public class DatabaseContext : DbContext
    {
        public class OptionsBuild
        {
            public OptionsBuild()
            {
                settings = new AppConfiguration();
                optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                optionsBuilder.UseSqlServer(settings.sqlConnectionString);
                dbOptions = optionsBuilder.Options;
            }

            public DbContextOptionsBuilder<DatabaseContext> optionsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> dbOptions { get; set; }
            private AppConfiguration settings { get; set; }
        }

        public static OptionsBuild options = new OptionsBuild();
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options) { }

        // DB sets go here
        public DbSet<Product> Products { get; set; } 
        public DbSet<Recipe> Recipes { get; set; }
    }
}
