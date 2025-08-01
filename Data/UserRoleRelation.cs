using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class UserRoleRelation
{
    public int SysUrid { get; set; }

    public string LoginName { get; set; } = null!;

    public string RoleName { get; set; } = null!;

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public virtual Role RoleNameNavigation { get; set; } = null!;
}
