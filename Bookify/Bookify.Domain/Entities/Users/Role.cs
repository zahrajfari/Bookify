using Bookify.Domain.Abstractions;

namespace Bookify.Domain.Entities.Users;

public sealed class Role : Entity
{
    public static readonly Role Registered = new(1, "Registered");

    public Role(int id, string name)
    {
        Id = id;
        Name = name;
    }

    public int Id { get; init; }

    public string Name { get; init; }

    public ICollection<User> Users { get; init; } = new List<User>();

    public ICollection<Permission> Permissions { get; init; } = new List<Permission>();
}