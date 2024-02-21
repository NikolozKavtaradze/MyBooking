using Microsoft.Extensions.DependencyInjection;
using MyBooking.Domain.Bookings;

namespace MyBooking.Application;

public static class DependancyInjection
{
    public static IServiceCollection AddApplication(this IServiceCollection services)
    {
        services.AddMediatR(configuration =>
        {
            configuration.RegisterServicesFromAssembly(typeof(DependancyInjection).Assembly);
        });

        services.AddTransient<PricingService>();

        return services;
    }
}