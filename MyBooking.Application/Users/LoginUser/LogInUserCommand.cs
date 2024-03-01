using MyBooking.Application.Abstractions.Messaging;
using MyBooking.Application.Users.LogInUser;

namespace MyBooking.Application.Users.LogInUser;

public sealed record LogInUserCommand(string Email, string Password)
    : ICommand<AccessTokenResponse>;