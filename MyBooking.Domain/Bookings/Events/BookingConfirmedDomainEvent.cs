using MyBooking.Domain.Abstractions;

namespace MyBooking.Domain.Bookings.Events;

public record BookingConfirmedDomainEvent(Guid BookingId) : IDomainEvent;