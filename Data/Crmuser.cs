using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class Crmuser
{
    public int SysUserId { get; set; }

    public string LoginName { get; set; } = null!;

    public string? Password { get; set; }

    public string? Name { get; set; }

    public byte[]? Picture { get; set; }

    public string? Title { get; set; }

    public string DepartmentName { get; set; } = null!;

    public int? Age { get; set; }

    public string Gender { get; set; } = null!;

    public string? PhoneNo { get; set; }

    public string? CellNo { get; set; }

    public string? EmailAddress { get; set; }

    public int? SkillLevel { get; set; }

    public bool? IsActive { get; set; }

    public bool IsSupervisor { get; set; }

    public bool? IsLogin { get; set; }

    public DateTime? LastLogin { get; set; }

    public string? Notes { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }

    public bool? NeverExpire { get; set; }

    public DateTime? ExpireDate { get; set; }

    public bool? ChangePasswordNextLogin { get; set; }

    public string? DivisionName { get; set; }

    public bool? PasswordNeverExpire { get; set; }

    public virtual Department DepartmentNameNavigation { get; set; } = null!;

    public virtual Division? DivisionNameNavigation { get; set; }
}
