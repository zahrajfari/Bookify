﻿using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Entities.Users.Events;

public sealed record UserCreatedDomainEvent(Guid UserId) : IDomainEvent;