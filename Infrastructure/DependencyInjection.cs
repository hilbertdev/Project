namespace Project.Infrastructure;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;


public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services, IConfiguration configuration)
    {
        var connectionString = configuration.GetConnectionString("DefaultConnection");
        TestDatabaseConnection(connectionString!);
        services.AddDbContext<AutoTicketContext>(options =>
            options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString)));

        return services;
    }


    public static void  TestDatabaseConnection(string connectionString)
    {
        using (var dbContext = new AutoTicketContext(new DbContextOptionsBuilder<AutoTicketContext>().UseMySql(connectionString,ServerVersion.AutoDetect(connectionString)).Options))
        {
            try
            {
                dbContext.Database.OpenConnection();
                Console.WriteLine("Database connection successful!");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error connecting to the database: {ex.Message}");
            }
            finally
            {
                dbContext.Database.CloseConnection();
            }
        }
    }
}
