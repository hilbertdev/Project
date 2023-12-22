
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore; 


public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddInfrastructureServices(this IServiceCollection services)
    {
        services.AddDbContext<DbContext>(options =>
        {
            options.UseMySql("Server=localhost;Database=Project;Trusted_Connection=True;");
        });

        return services;
    }
}
