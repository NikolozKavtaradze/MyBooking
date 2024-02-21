using MyBooking.Domain.Abstractions;

namespace MyBooking.Domain.Users.Events;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;