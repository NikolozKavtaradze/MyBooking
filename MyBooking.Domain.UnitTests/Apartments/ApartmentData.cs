using MyBooking.Domain.Apartments;
using MyBooking.Domain.Shared;

namespace MyBooking.Domain.UnitTests.Apartments;

public class ApartmentData
{
    public static Apartment Create(Money price, Money? cleaningFee = null) => new(
        Guid.NewGuid(),
        new Name("Apartment"),
        new Description("Description"),
        new Address("Country", "State", "ZipCode", "City", "Street"),
        price,
        cleaningFee ?? Money.Zero(),
        []);
}