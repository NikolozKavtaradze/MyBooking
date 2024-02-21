using MyBooking.Domain.Abstractions;

namespace MyBooking.Domain.Bookings.Events;

public record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;