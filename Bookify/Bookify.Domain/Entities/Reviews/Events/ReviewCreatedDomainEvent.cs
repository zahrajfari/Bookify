using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Entities.Reviews.Events;

public sealed record ReviewCreatedDomainEvent(Guid ReviewId) : IDomainEvent;
