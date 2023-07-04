using System.Diagnostics;
using Common;
using Dal.EF;
using DAL.EF.Core;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace DI;

public static class DependencyHelper
{
    public static void RegisterServices(IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.EnableDetailedErrors();
            options.EnableSensitiveDataLogging();

            string defaultConnectionString =
                new SqlConnectionStringBuilder(configuration, "Default").ToString();

            options.UseMySql(defaultConnectionString,
                ServerVersion.AutoDetect(defaultConnectionString)
            );
        });
        
        services.AddSingleton(_ => configuration);

        services.AddSingleton<IClock>(new Clock());
        services.AddHttpClient();
    }
    
    public static void Replace<TService, TImplementation>(this IServiceCollection serviceCollection)
        where TService : class
        where TImplementation : class, TService
    {
        ServiceDescriptor existedDescriptor = serviceCollection.Single(d => d.ServiceType == typeof(TService));

        if (serviceCollection.Remove(existedDescriptor))
        {
            serviceCollection.Add(new ServiceDescriptor(typeof(TService), typeof(TImplementation),
                existedDescriptor.Lifetime));
        }
        else
        {
            throw new ReplaceServiceException($"Could not remove the {typeof(TService)}");
        }
    }
}