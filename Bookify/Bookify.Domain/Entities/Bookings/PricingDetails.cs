using Bookify.Domain.Entities.Shared;

namespace Bookify.Domain.Entities.Bookings;

public sealed record PricingDetails(
    Money PriceForPeriod,
    Money CleaningFee,
    Money AmenitiesUpCharge,
    Money TotalPrice);
