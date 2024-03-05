using MyBooking.Application.Abstractions.Messaging;

namespace MyBooking.Application.Users.GetLoggedInUser;

public sealed record GetLoggedInUserQuery : IQuery<UserResponse>;