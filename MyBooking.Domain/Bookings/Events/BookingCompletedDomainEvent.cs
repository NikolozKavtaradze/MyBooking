using MyBooking.Domain.Abstractions;

namespace MyBooking.Domain.Bookings.Events;

public record BookingCompletedDomainEvent(Guid BookingId) : IDomainEvent;