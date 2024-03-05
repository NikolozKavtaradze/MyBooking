using MyBooking.Domain.Users;

namespace MyBooking.Infrastructure.Authorization;

public sealed class UserRolesResponse
{
    public Guid Id { get; set; }
    public List<Role> Roles { get; init; } = [];
}