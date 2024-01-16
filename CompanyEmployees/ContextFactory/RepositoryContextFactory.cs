using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

public class RepositoryContextFactory : IDesignTimeDbContextFactory<RepositoryContext>
{

    /*
        In software development, a "factory" is a design pattern that's used to create objects.
         A factory is a class or method that has a responsibility of creating and returning instances of other classes.


    */
    public RepositoryContext CreateDbContext(string[] args)
    {
        var configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json")
            .Build();

        var builder = new DbContextOptionsBuilder<RepositoryContext>()
            .UseSqlServer(configuration.GetConnectionString("sqlConnection"));

        return new RepositoryContext(builder.Options);
    }
}