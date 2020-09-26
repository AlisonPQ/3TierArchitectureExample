namespace Layering.DataSource.SQL.DataContext
{
    using Microsoft.EntityFrameworkCore.Design;
    using Microsoft.EntityFrameworkCore;

    public class DatabaseContextFactory : IDesignTimeDbContextFactory<DatabaseContext>
    {
        public DatabaseContext CreateDbContext(string[] args)
        {
            AppConfiguration appConfiguration = new AppConfiguration();
            var optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
            optionsBuilder.UseSqlServer(appConfiguration.sqlConnectionString);
            return new DatabaseContext(optionsBuilder.Options);
        }
    }
}
