﻿namespace Bookify.Domain.Entities.Users;

public sealed class RolePermission
{
    public int RoleId { get; set; }

    public int PermissionId { get; set; }
}
