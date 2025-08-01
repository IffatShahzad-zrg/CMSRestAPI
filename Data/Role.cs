using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Role
{
    public int SysRoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public string RoleScreen { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual RolePermission? RolePermission { get; set; }

    public virtual ICollection<UserRoleRelation> UserRoleRelations { get; set; } = new List<UserRoleRelation>();
}
