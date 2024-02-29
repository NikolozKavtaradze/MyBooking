using MyBooking.Domain.Users;

namespace MyBooking.Application.Abstractions;

public interface IAuthenticationService
{
    Task<string> RegisterAsync(
        User user, 
        string password,
        CancellationToken cancellationToken = default);
}