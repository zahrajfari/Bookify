﻿namespace Bookify.Domain.Entities.Apartments;

public sealed record Address(
    string Country,
    string State,
    string ZipCode,
    string City,
    string Street);
