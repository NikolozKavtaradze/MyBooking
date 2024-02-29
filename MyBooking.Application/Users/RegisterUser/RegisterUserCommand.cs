using MyBooking.Application.Abstractions.Messaging;

namespace MyBooking.Application.Users.RegisterUser;

public record RegisterUserCommand(
    string Email,
    string FirstName,
    string LastName,
    string Password) : ICommand<Guid>;