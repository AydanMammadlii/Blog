using BlankSolution.Core.Repositories;

namespace BlankSolution.API;

public static class ServiceRegistration
{
    public static void AddRepositories(this IServiceCollection services)
    {
        services.AddScoped<IBlogRepository, IBlogRepository>();
    }
}
