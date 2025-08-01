using System;
using System.Collections.Generic;

namespace CMSRestAPI.Data;

public partial class ActivityCode
{
    public int SysActivityCodeId { get; set; }

    public string ActivityCode1 { get; set; } = null!;

    public string ActivityCodeType { get; set; } = null!;

    public string? Description { get; set; }

    public bool IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? ModifiedOn { get; set; }

    public string? ModifiedBy { get; set; }
}
