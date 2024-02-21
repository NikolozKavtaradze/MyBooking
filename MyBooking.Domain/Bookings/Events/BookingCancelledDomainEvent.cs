using MyBooking.Domain.Abstractions;

namespace MyBooking.Domain.Bookings.Events;

public record BookingCancelledDomainEvent(Guid BookingId) : IDomainEvent;