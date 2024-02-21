using MyBooking.Domain.Abstractions;

namespace MyBooking.Domain.Bookings.Events;

public record BookingRejectedDomainEvent(Guid BookingId) : IDomainEvent;