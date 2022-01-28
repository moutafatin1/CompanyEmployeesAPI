using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace CompanyEmployeesAPI.ContextFactory;

// we use IDesignTimeDbContextFactory to separate the entity framework code needed
// for generating database tables at design-time(code first approach) from the entity framework code used
// by our application in runtime
public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
{
    public RepositoryContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<RepositoryContext>();
        var connectionString = configuration.GetConnectionString("sqlConnection");

        builder.UseSqlServer(connectionString, b => b.MigrationsAssembly("CompanyEmployeesAPI"));

        return new RepositoryContext(builder.Options);

    }
}
