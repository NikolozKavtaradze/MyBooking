using MyBooking.Domain.Shared;

namespace MyBooking.Domain.Bookings;

public sealed record PricingDetails(Money PriceForPeriod, Money CleaningFee, Money AmenitiesUpCharge, Money TotalPrice);