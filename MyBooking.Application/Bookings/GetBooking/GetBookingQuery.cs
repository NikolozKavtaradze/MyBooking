using MyBooking.Application.Abstractions.Messaging;

namespace MyBooking.Application.Bookings.GetBooking;

public record GetBookingQuery(Guid BookingId) : IQuery<BookingResponse>;