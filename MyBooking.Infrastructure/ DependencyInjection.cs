using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MyBooking.Application.Abstractions.Clock;
using MyBooking.Application.Abstractions.Email;
using MyBooking.Infrastructure.Clock;
using MyBooking.Infrastructure.Email;

namespace MyBooking.Infrastructure;

public static class DependencyInjection
{
    public static IServiceCollection AddInfrastructure(
        this IServiceCollection services,
        IConfiguration configuration)
    {
        services.AddTransient<IDateTimeProvider, DateTimeProvider>();

        services.AddTransient<IEmailService, EmailService>();

        var connectionString = configuration.
            GetConnectionString("Database") ?? 
            throw new ArgumentNullException(nameof(configuration));

        services.AddDbContext<ApplicationDbContext>(options =>
        {
            options.UseNpgsql(connectionString).UseSnakeCaseNamingConvention();
        });

        return services;
    }
}