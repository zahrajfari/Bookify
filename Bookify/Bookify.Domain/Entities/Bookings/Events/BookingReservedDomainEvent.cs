﻿using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Entities.Bookings.Events;

public sealed record BookingReservedDomainEvent(Guid BookingId) : IDomainEvent;
